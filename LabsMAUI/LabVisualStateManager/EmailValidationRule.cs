using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabVisualStateManager
{
    public class EmailValidationRule : IValidationRule<string>
    {
        public string ValidationMessage { get ; set ; }

        public bool Check(string value)
        {
            if (value is string str)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(str);
                return match.Success;
            }
            return true;
        }
    }
}
