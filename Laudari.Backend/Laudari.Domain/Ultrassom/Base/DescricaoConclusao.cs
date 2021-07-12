using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Base
{
    public class DescricaoConclusao
    {
        public string TextFormatBase { get; set; }
        public string TextFormatConclusao { get; set; }

        public DescricaoConclusao ()
        {
            TextFormatBase = "";
            TextFormatConclusao = "";
        }
    }
}
