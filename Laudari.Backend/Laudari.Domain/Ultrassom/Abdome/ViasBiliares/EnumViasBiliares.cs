using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.ViasBiliares
{
    public enum ViasBiliaresColedoco
    {
        [Description("normal")]
        Normal = 0,
        [Description("ectasiado")]
        Ectasiado = 1
    }
}
