using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class StringFunctions
    {
        //System.String string
        //int System.Int32
       
        public String StringCombine(string sent1, string sent2)
        {
            return string.Concat(sent1, " ", sent2);
        }
        public string Table(int num)
        {
             StringBuilder sb = new StringBuilder();
             
            for(int x= 1; x <= 10; x++)
            {
                sb.AppendLine($"{num} * {x} = {num * x}");
            }
            return sb.ToString();
        }

    }
}
