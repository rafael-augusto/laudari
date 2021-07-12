using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Baco
{
    public enum BacoClassificacaoEnum
    {
        [Description("normal")]
        Normal = 0,
        [Description("aumentado")]
        Aumentado = 1,
        [Description("ausente")]
        Ausente = 2,
    }

    public enum BacoEcoTexturaEnum
    {
        [Description("homogênea")]
        Homogenea = 0,
        [Description("heterogênea")]
        Heterogenea = 1,
    }
}
