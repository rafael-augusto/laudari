using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Bexiga
{
    public enum BexigaClassificacao
    {
        [Description("normal")]
        Normal = 0,
        [Description("trabeculada")]
        Trabeculada = 1,
        [Description("repleção Insuficiente")]
        replecaoInsuficiente = 2
    }
}
