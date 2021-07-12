using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Intestino
{
    public class UsIntestino : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }


        public TipoDiverticulite tipoDiverticulite { get; set; }

        public bool ColecaoDiversiculite { get; set; }
        public bool Diverticulite { get; set; }
        public decimal? Calibre { get; set; }
        public bool Apendicite { get; set; }
        public bool ApendiceColecao { get; set; }

        public UsIntestino()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }



        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            //var textoBaseConclusao = TextDescConc.TextFormatConclusao;
            //compoe a conclusao
            //Achados sugestivos de processo inflamatório apendicular.
            //Achados sugestivos de processo inflamatório diverticular.


            #region Frases Classificação
            var fraseApendicite = " Imagem tubuliforme em fundo cego na fossa ilíaca direita, não compressível, com {Calibre} cm de diâmetro, associada a aumento da ecogenicidade da gordura adjacente{ColecaoApendice}.";
            var fraseDiverticulite = " Presença de imagem diverticular com espessamento parietal em topografia do {tipoDiverticulite}, associada a aumento da ecogenicidade da gordura adjacente{ColecaoDiverticulite}.";
            var complementoColecao = " e acompanhada de pequena coleção líquida";





            #endregion


            if (Apendicite)
            {
                textoBaseOrigem = "<p>";
                textoBaseOrigem += fraseApendicite;
                textoBaseOrigem += "</p>";
            }
            if (Diverticulite)
            {
                textoBaseOrigem += "<p>";
                textoBaseOrigem += fraseDiverticulite;
                textoBaseOrigem += "</p>";
            }

            textoBaseOrigem = textoBaseOrigem.Replace("{Calibre}", (Calibre.GetValueOrDefault(0) / 10).ToString("F2"));



            if (ApendiceColecao)
                textoBaseOrigem = textoBaseOrigem.Replace("{ColecaoApendice}", complementoColecao);
            else
                textoBaseOrigem = textoBaseOrigem.Replace("{ColecaoApendice}", "");

            switch (tipoDiverticulite)
            {
                case TipoDiverticulite.Sigmoide:
                    textoBaseOrigem = textoBaseOrigem.Replace("{tipoDiverticulite}", tipoDiverticulite.GetDescription());
                    break;
                case TipoDiverticulite.ColonDescendente:
                    textoBaseOrigem = textoBaseOrigem.Replace("{tipoDiverticulite}", tipoDiverticulite.GetDescription());
                    break;
            }
            if (ColecaoDiversiculite)
                textoBaseOrigem = textoBaseOrigem.Replace("{ColecaoDiverticulite}", complementoColecao);
            else
                textoBaseOrigem = textoBaseOrigem.Replace("{ColecaoDiverticulite}", "");

            TextDescConc.TextFormatBase = textoBaseOrigem;
            return TextDescConc;

        }

        public string MontaConclusao()
        {
            return "";
        }

    }
}
