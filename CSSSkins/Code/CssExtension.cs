using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSkins
{
    public static class CssExtension
    {
        public static int ToNumber(this string text)
        {
            int.TryParse(text.Replace("px", "").Replace("-", ""), out int result);
            return result;
        }
    }
}
