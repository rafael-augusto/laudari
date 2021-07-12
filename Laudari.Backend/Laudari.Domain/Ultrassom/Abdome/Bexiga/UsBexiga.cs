using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Bexiga
{
    public class UsBexiga : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }


        public BexigaClassificacao Classificacao { get; set; }
        public bool NaoCitar { get; set; }


        public UsBexiga()
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
            var fraseBexigaNormal = "Bexiga com boa repleção, paredes finas e regulares, conteúdo anecogênico.";
            var fraseBexigaEsforco = "Bexiga com boa repleção, de conteúdo anecogênico, apresentando paredes difusamente espessadas e trabeculadas.";
            var fraseBexigaReplecaoParcial = "Bexiga com repleção insuficiente para análise.";

            #endregion

            if (!NaoCitar)
            {
                switch (Classificacao)
                {
                    case BexigaClassificacao.Normal:
                        textoBaseOrigem = fraseBexigaNormal;
                        break;
                    case BexigaClassificacao.Trabeculada:
                        textoBaseOrigem = fraseBexigaEsforco;
                        break;
                    case BexigaClassificacao.replecaoInsuficiente:
                        textoBaseOrigem = fraseBexigaReplecaoParcial;
                        break;
                }
            }
            else
                return new DescricaoConclusao() ;
            TextDescConc.TextFormatBase = textoBaseOrigem;
            return TextDescConc;

        }

    }
}
