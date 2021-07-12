using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.AortaRetroperitoneo
{
    public enum AortaClassificacao
    {
        [Description("normal")]
        Normal = 0,
        [Description("ateromatosa")]
        Ateromatosa = 1,
        [Description("ateromatorsa ectasiada")]
        AteromatorsaEctasiada = 2,
        [Description("aneurisma")]
        Aneurisma = 3,
        [Description("inacessivel")]
        Inacessivel = 4
    }

    public enum AortaAneurisma
    {
        [Description("fusiforme")]
        Fusiforme = 0,
        [Description("secular")]
        Secular = 1
    }

    public enum AortaLocalAneurisma
    {
        [Description("infrarenal")]
        Infrarenal = 0,
        [Description("terco medio")]
        TercoMedio = 1,
        [Description("terco proximal")]
        TercoProximal = 2,
        [Description("terco distal")]
        TercoDistal = 3,
        [Description("junto bifurcacao")]
        JuntoBifurcacao = 4
    }
}
