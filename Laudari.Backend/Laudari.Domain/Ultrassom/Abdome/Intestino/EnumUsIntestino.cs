using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Intestino
{
    public enum TipoDiverticulite
    {
        [Description("sigmoide")]
        Sigmoide = 0,
        [Description("cólon descendente")]
        ColonDescendente = 1,
    }
}
