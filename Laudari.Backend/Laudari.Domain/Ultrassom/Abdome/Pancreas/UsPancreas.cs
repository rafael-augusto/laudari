using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Pancreas
{
    public class UsPancreas : IBaseUltrassom

    {

        public EnumUsPancreasClassificacao Classificacao { get; set; }
        public bool CheckCabeca { get; set; }
        public bool CheckCorpo { get; set; }
        public bool CheckCauda { get; set; }

        public int TamanhoCabeca { get; set; }
        public int TamanhoCorpo { get; set; }
        public int TamanhoCauda { get; set; }

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }


        public UsPancreas()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }


        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            //var textoBaseConclusao = TextDescConc.TextFormatConclusao;

            var frasePancreasNormal = "Pâncreas de dimensões normais, contornos regulares e ecotextura homogênea. Não há dilatação do ducto pancreático.";
            var frasePancreasParcialmenteAcessivel = "Pâncreas parcialmente visibilizado devido à interposição de alças intestinais.";
            var frasePancreasInacessivel = "Pâncreas inacessível devido à interposição gasosa de alças intestinais.";
            var frasePancreatiteAguda = "Pâncreas de aspecto heterogêneo, com espessura aumentada e ecogenicidade reduzida do parênquima.";

            switch (Classificacao)
            {
                case EnumUsPancreasClassificacao.Normal:
                    textoBaseOrigem = frasePancreasNormal;
                    break;
                case EnumUsPancreasClassificacao.ParcilmenteAcessivel:
                    textoBaseOrigem = frasePancreasParcialmenteAcessivel;
                    break;
                case EnumUsPancreasClassificacao.Inacessivel:
                    textoBaseOrigem = frasePancreasInacessivel;
                    break;
                case EnumUsPancreasClassificacao.PancreatiteAguda:
                    textoBaseOrigem = frasePancreatiteAguda;
                    break;
            }

            bool[] checkMedidas = { CheckCabeca, CheckCorpo, CheckCauda };
            int countCheckMedidas = checkMedidas.Count(t => t);
            if (Classificacao != EnumUsPancreasClassificacao.Inacessivel && countCheckMedidas > 0)
            {              
                var textoExpessuraPancreatica = " A espessura pancreática foi mensurada em{fraseMedida}.";

                if (countCheckMedidas == 1)
                {
                    if (CheckCabeca)
                        textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{fraseMedida}", " {tamanhoCabeca} cm na cabeça");

                }
                else if (countCheckMedidas == 2)
                {
                    if (CheckCabeca && CheckCorpo)
                        textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{fraseMedida}", " {tamanhoCabeca} cm na cabeça e {tamanhoCorpo} cm no corpo");
                    if (CheckCabeca && CheckCauda)
                        textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{fraseMedida}", " {tamanhoCabeca} cm na cabeça e {tamanhoCauda} cm na cauda");
                    if (CheckCorpo && CheckCauda)
                        textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{fraseMedida}", " {tamanhoCorpo} cm no corpo e {tamanhoCauda} cm na cauda");
                }
                else if (countCheckMedidas == 3)
                {
                    textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{fraseMedida}", " {tamanhoCabeca} cm na cabeça, {tamanhoCorpo} cm no corpo e {tamanhoCauda} cm na cauda");

                }

                textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{tamanhoCabeca}", TamanhoCabeca.ToString());
                textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{tamanhoCorpo}", TamanhoCorpo.ToString());
                textoExpessuraPancreatica = textoExpessuraPancreatica.Replace("{tamanhoCauda}", TamanhoCauda.ToString());

                textoBaseOrigem += textoExpessuraPancreatica;
            }

            TextDescConc.TextFormatBase = textoBaseOrigem;

            return TextDescConc;
        }

    }
}
