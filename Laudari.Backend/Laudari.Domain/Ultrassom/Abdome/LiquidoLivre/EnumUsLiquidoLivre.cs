using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.LiquidoLivre
{
    public enum liquidoLibreClassificacao
    {
        [Description("ausente")]
        Ausente = 0,
        [Description("no abdome")]
        Abdome = 1,
        [Description("na pelve")]
        Pelve = 2,
        [Description("na fossa hepatorrenal")]
        FossaHepatorrenal = 3,
        [Description("no flanco direito")]
        FlancoDireito = 4,
        [Description("no flanco esquerdo")]
        FlancoEsquerdo = 5,
        [Description("na fossa ilíaca direita")]
        FossaIliacaDireita = 6,
        [Description("na fossa ilíaca esquerda")]
        FossaIliacaEsquerda = 7
    }

    public enum liquidoLivreQtd
    {
        [Description("pequena quantidade")]
        PequenaQtd = 0,
        [Description("moderada quantidade")]
        ModeradaQtd = 1,
        [Description("grande quantidade")]
        GrandeQtd = 2
    }
}
