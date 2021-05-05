using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            //Make my content bold
            return $"<strong>{content}</strong>";
        }
    }
}
