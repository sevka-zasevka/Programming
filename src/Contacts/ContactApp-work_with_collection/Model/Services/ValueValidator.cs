using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_work_with_collection.Model.Services
{
    internal static class ValueValidator
    {
        public static void ValidationOnLenght(string value, int maxLength, string name)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException($"{name} must be less than {maxLength} characters.");
            }
        }

        public static bool ValidationOnContent(string value, string content, string name)
        {
            if (!value.Contains(content))
            {
                //throw new ArgumentException($"{name} must contain the {content}.");
                return false;
            }
            return true;
        }
    }
}
