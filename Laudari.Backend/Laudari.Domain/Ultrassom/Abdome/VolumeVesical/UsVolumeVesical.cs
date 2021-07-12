using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.VolumeVesical
{
    public class UsVolumeVesical : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }


        public decimal? EspessuraVolMiccional { get; set; }
        public bool NaoCitarVolMiccional { get; set; }
        
        public decimal? EspessuraResiduo { get; set; }
        public bool NaoCitarResiduo { get; set; }


        public UsVolumeVesical()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }



        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            //var textoBaseConclusao = TextDescConc.TextFormatConclusao;

            #region Frases Classificação
            var fraseVolumeVesicalMiccional = "<p>Volume vesical pré - miccional estimado em {volumeMiccional} cm³.</p>";
            var fraseVolumeVesicalResiduo = "<p>Resíduo vesical pós - miccional muito acentuado({volumeResiduo} cm³).</p>";

            #endregion

            if (!NaoCitarVolMiccional)
                textoBaseOrigem += fraseVolumeVesicalMiccional.Replace("{volumeMiccional}", EspessuraVolMiccional.GetValueOrDefault(0).ToString("F2"));
            if (!NaoCitarResiduo)
                textoBaseOrigem += fraseVolumeVesicalResiduo.Replace("{volumeResiduo}", EspessuraResiduo.GetValueOrDefault(0).ToString("F2"));

            TextDescConc.TextFormatBase = textoBaseOrigem;

            return TextDescConc;

        }
    }
}
