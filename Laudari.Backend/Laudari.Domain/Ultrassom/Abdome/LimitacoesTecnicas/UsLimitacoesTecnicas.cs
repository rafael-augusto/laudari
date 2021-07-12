using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.LimitacoesTecnicas
{
    public class UsLimitacoesTecnicas : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }

        public UsLimitacoesTecnicas()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }

        public EnumClassificacaoLimitacaoTecnica Classificacao { get; set; }



        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            //var textoBaseConclusao = TextDescConc.TextFormatConclusao;

            #region Frases
            var fraseMeteorismoIntestinal = "Exame limitado parcialmente por distensão gasosa intestinal.";
            var fraseBiotipo = "Exame parcialmente prejudicado por limitações técnicas inerentes ao biotipo.";
            var fraseMeteorismoBiotipo = "Exame parcialmente prejudicado por distensão gasosa intestinal e limitações técnicas inerentes ao biotipo.";

            #endregion


            switch (Classificacao)
            {
                case EnumClassificacaoLimitacaoTecnica.MeteorismoIntestinal:
                    textoBaseOrigem += fraseMeteorismoIntestinal;
                    break;
                case EnumClassificacaoLimitacaoTecnica.Biotipo:
                    textoBaseOrigem += fraseBiotipo;
                    break;
                case EnumClassificacaoLimitacaoTecnica.MeteorismoBiotipo:
                    textoBaseOrigem += fraseMeteorismoBiotipo;
                    break;
            }

            TextDescConc.TextFormatBase = textoBaseOrigem;

            return TextDescConc;

        }

        public string MontaConclusao()
        {
            return "";
        }
    }



}
