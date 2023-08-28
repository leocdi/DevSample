using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.ComponentModel.DataAnnotations;

namespace DevSample
{
    public class MyModelMetadataProvider : IValidationMetadataProvider
    {
        //https://stackoverflow.com/questions/59284038/how-to-localize-standard-error-messages-of-validation-attributes-in-asp-net-core
        public void CreateValidationMetadata(ValidationMetadataProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            var validators = context.ValidationMetadata.ValidatorMetadata;

            // add [Required] for value-types (int/DateTime etc)
            // to set ErrorMessage before asp.net does it
            var theType = context.Key.ModelType;
            var underlyingType = Nullable.GetUnderlyingType(theType);

            if (theType.IsValueType &&
                underlyingType == null && // not nullable type
                validators.Where(m => m.GetType() == typeof(RequiredAttribute)).Count() == 0)
            {
                validators.Add(new RequiredAttribute());
            }
            foreach (var obj in validators)
            {
                if (!(obj is ValidationAttribute attribute))
                {
                    continue;
                }
                //fillErrorMessage<RequiredAttribute>(attribute,
                //    "zzzYou must fill in '{0}'.");
                fillErrorMessage<MinLengthAttribute>(attribute,
                    "zzMin length of '{0}' is {1}.");
                fillErrorMessage<MaxLengthAttribute>(attribute,
                    "zzMax length of '{0}' is {1}.");
                fillErrorMessage<EmailAddressAttribute>(attribute,
                    "zzzInvalid email address.", true);
                // other attributes like RangeAttribute, CompareAttribute, etc
            }
        }
        private void fillErrorMessage<T>(object attribute, string errorMessage,
            bool forceOverriding = false)
            where T : ValidationAttribute
        {
            if (attribute is T validationAttribute)
            {
                if (forceOverriding ||
                    (validationAttribute.ErrorMessage == null
                    && validationAttribute.ErrorMessageResourceName == null))
                {
                    validationAttribute.ErrorMessage = errorMessage;
                }
            }
        }
    }
}
