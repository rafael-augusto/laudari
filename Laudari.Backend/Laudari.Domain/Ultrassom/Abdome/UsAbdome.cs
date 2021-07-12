using Laudari.Domain.Ultrassom.Abdome.AortaRetroperitoneo;
using Laudari.Domain.Ultrassom.Abdome.Baco;
using Laudari.Domain.Ultrassom.Abdome.Bexiga;
using Laudari.Domain.Ultrassom.Abdome.Figado;
using Laudari.Domain.Ultrassom.Abdome.Intestino;
using Laudari.Domain.Ultrassom.Abdome.LimitacoesTecnicas;
using Laudari.Domain.Ultrassom.Abdome.LiquidoLivre;
using Laudari.Domain.Ultrassom.Abdome.Pancreas;
using Laudari.Domain.Ultrassom.Abdome.RinsUreteres;
using Laudari.Domain.Ultrassom.Abdome.VesiculaBiliar;
using Laudari.Domain.Ultrassom.Abdome.ViasBiliares;
using Laudari.Domain.Ultrassom.Abdome.VolumeVesical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome
{
    public class UsAbdome
    {
        public UsLimitacoesTecnicas UsLimitacoesTecnicas { get; set; }
        public UsFigado UsFigado { get; set; }
        public UsPancreas UsPancreas { get; set; }
        public UsBaco UsBaco { get; set; }
        public UsViasBiliares UsViasBiliares { get; set; }
        public UsVesiculaBiliar UsVesiculaBiliar { get; set; }
        public UsAorta UsAorta { get; set; }
        public UsIntestino UsIntestino { get; set; }
        public UsBexiga UsBexiga { get; set; }
        public UsLiquidoLivre UsLiquidoLivre { get; set; }
        public UsVolumeVesical UsVolumeVesical { get; set; }
        public UsRinsUreteres UsRinsUreteres { get; set; }
        private string styles { get; set; }
        private string laudo { get; set; }
        private string tituloLaudo { get; set; }
        private string conclusao { get; set; }
        private string retorno { get; set; }
        public UsAbdome()
        {
            styles = @"

            <style>
            .titulo{

            }
            
            h4{
                text-align:center;
            }

            p{
                margin:0px;
                line-height:1.3;
            }
                



            </style>
            ";
        }
        public string GeraLaudo()
        {
 
            tituloLaudo += "ULTRASSONOGRAFIA DO ABDOME TOTAL";
            var formatoParagrafo = "<p>{paragrafo}</p>";

            if (UsLimitacoesTecnicas != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsLimitacoesTecnicas.MontaDescricao().TextFormatBase);
            if (UsFigado != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsFigado.MontaDescricao().TextFormatBase);
            if (UsPancreas != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsPancreas.MontaDescricao().TextFormatBase);
            if (UsBaco != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsBaco.MontaDescricao().TextFormatBase);
            if (UsVesiculaBiliar != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsVesiculaBiliar.MontaDescricao().TextFormatBase);
            if (UsViasBiliares != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsViasBiliares.MontaDescricao().TextFormatBase);
            if (UsAorta != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsAorta.MontaDescricao().TextFormatBase);
            if (UsIntestino != null)
                laudo +=  UsIntestino.MontaDescricao().TextFormatBase;
            if (UsRinsUreteres != null)
            { 
                laudo += formatoParagrafo.Replace("{paragrafo}", UsRinsUreteres.MontaDescricao().TextFormatBase);
                if (UsRinsUreteres.IncluirDopplerArteriasRenais)
                    tituloLaudo += "<br/>DOPPLER DE ARTÉRIAS RENAIS";
            }
            if (UsBexiga != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsBexiga.MontaDescricao().TextFormatBase);
            if (UsVolumeVesical != null)
                laudo += UsVolumeVesical.MontaDescricao().TextFormatBase;
            if (UsLiquidoLivre != null)
                laudo += formatoParagrafo.Replace("{paragrafo}", UsLiquidoLivre.MontaDescricao().TextFormatBase);



            conclusao +=  "<h5>Conclusões</h5>";
            if (UsFigado != null)
                conclusao += formatoParagrafo.Replace("{paragrafo}", UsFigado.MontaDescricao().TextFormatConclusao);
            if (UsVesiculaBiliar != null)
                conclusao += formatoParagrafo.Replace("{paragrafo}", UsVesiculaBiliar.MontaDescricao().TextFormatConclusao);
            if (UsAorta != null)
                conclusao += formatoParagrafo.Replace("{paragrafo}", UsAorta.MontaDescricao().TextFormatConclusao);
            if (UsRinsUreteres != null)
                conclusao += formatoParagrafo.Replace("{paragrafo}", UsRinsUreteres.MontaConclusao());


            retorno += styles;
            retorno += "<h4>"+tituloLaudo+"</h4>";
            retorno += laudo;
            retorno += conclusao;

            return retorno;

        }
    }
}
