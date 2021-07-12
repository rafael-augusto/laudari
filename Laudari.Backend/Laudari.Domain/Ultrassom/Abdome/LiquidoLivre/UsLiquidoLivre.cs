using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.LiquidoLivre
{
    public class UsLiquidoLivre : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }


        public liquidoLibreClassificacao Classificacao { get; set; }
        public liquidoLivreQtd Quantidade { get; set; }


        public UsLiquidoLivre()
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
            var fraseLiquidoLivreAusente = "Ausência de líquido livre.";
            var fraseLiquidoLivre = "Nota-se {quantidade} de líquido livre {local}.";

            #endregion
            if (Classificacao == liquidoLibreClassificacao.Ausente)
                textoBaseOrigem = fraseLiquidoLivreAusente;
            else
            {
                textoBaseOrigem = fraseLiquidoLivre;
                textoBaseOrigem = textoBaseOrigem.Replace("{local}", Classificacao.GetDescription());
                textoBaseOrigem = textoBaseOrigem.Replace("{quantidade}", Quantidade.GetDescription());

            }

            TextDescConc.TextFormatBase = textoBaseOrigem;
            return TextDescConc;

        }

    }
}
