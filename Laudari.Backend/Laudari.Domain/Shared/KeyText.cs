using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Shared
{
    public class KeyText
    {
        public string Key { get; set; }
        public string Text { get; set; }

        public string ReplaceParameters(IEnumerable<string> parameters)
        {
            return String.Format(Text, parameters);
        }
    }
}
