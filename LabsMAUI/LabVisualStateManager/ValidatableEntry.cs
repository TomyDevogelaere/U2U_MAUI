using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVisualStateManager
{
    internal class ValidatableEntry : Entry
    {

        public IValidationRule<string> ValidationRule
        {
            get { return (IValidationRule<string>)GetValue(ValidationRuleProperty);}
            set { SetValue(ValidationRuleProperty, value); }
        }
   
        public static readonly BindableProperty ValidationRuleProperty =
            BindableProperty.Create("ValidationRule", typeof(IValidationRule<string>), typeof(ValidatableEntry), propertyChanged:OnValidationRuleChanged);

        public bool IsValid
        {
            get { return (bool)GetValue(IsValidProperty); }
            set { SetValue(IsValidProperty, value); }
        }

        public static readonly BindableProperty IsValidProperty =
            BindableProperty.Create("IsValid", typeof(bool), typeof(ValidatableEntry), propertyChanged:OnIsValidChanged);

        private static void OnIsValidChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var isValid = (bool)newValue;
            if (isValid)
            {
                VisualStateManager.GoToState((ValidatableEntry)bindable, "Valid");
            }
            else
            {
                VisualStateManager.GoToState((ValidatableEntry)bindable, "InValid");
            }
        }

        private static void OnValidationRuleChanged(BindableObject bindable, object newValue, object oldValue)
        {
            if (newValue is IValidationRule<string> rule)
            {
                var entry = (ValidatableEntry)bindable;
                entry.ApplyValidationRule(entry.Text);
            }
        }

        private void ApplyValidationRule(string text)
      => IsValid = ValidationRule?.Check(text) ?? true;

        protected override void OnTextChanged(string oldValue, string newValue)
        {
            base.OnTextChanged(oldValue, newValue);
            if(ValidationRule != null)
            {
                ApplyValidationRule(newValue);
            }
        }
    }
}
