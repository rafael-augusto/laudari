using Laudari.Domain.Helpers;
using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Baco
{
    public class UsBaco : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }


        public BacoClassificacaoEnum Classificacao { get; set; }
        public BacoEcoTexturaEnum Ecotextura { get; set; }
        public bool Dimensao { get; set; }
        public decimal DimensaoA { get; set; }
        public decimal DimensaoB { get; set; }
        public bool CitarIndice { get; set; }
        public bool BacoAcessorio { get; set; }
        public decimal DimensaoAcessorioA { get; set; }
        public decimal DimensaoAcessorioB { get; set; }
        public bool Calcificacao { get; set; }
        public decimal DimensaoCalcificacao { get; set; }

        private decimal IndiceEsplenico { get; set; }

        public UsBaco()
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
            var fraseBacoAcessorio = " Presença de baço acessório (variação anatômica) medindo {dimensaoAcessorioA} x {dimensaoAcessorioB} cm.";
            var fraseFraseAumentadas = "Baço com dimensões aumentadas, contornos regulares e ecotextura {ecotextura}";
            var fraseBacoCalcificacao = " Nota-se calcificação parenquimatosa medindo {dimensaoCalsificacao} cm, de provável natureza sequelar.";
            var fraseBacoEsplenectomia = "Baço não caracterizado (esplenectomia)."; //ausente
            var fraseBacoNormal = "Baço com dimensões normais, contornos regulares e ecotextura homogênea.";

            var fraseDimensoesBaco = " Mede {dimensaoA} x {dimensaoB} cm em seu maior e menor eixo";
            var fraseIndiceEsplenico = " (índice esplênico uniplanar = {indiceEsplenico})";

            #endregion


            switch (Classificacao)
            {
                case BacoClassificacaoEnum.Normal:
                    textoBaseOrigem += fraseBacoNormal;
                    break;
                case BacoClassificacaoEnum.Aumentado:
                    textoBaseOrigem += fraseFraseAumentadas;
                    break;
                case BacoClassificacaoEnum.Ausente:
                    textoBaseOrigem += fraseBacoEsplenectomia;
                    break;
            }
            textoBaseOrigem = textoBaseOrigem.Replace("{ecotextura}", Ecotextura.GetDescription());
            if(Dimensao)
            {
                textoBaseOrigem += fraseDimensoesBaco;
                textoBaseOrigem = textoBaseOrigem.Replace("{dimensaoA}", (DimensaoA / 10).ToString("F2"));
                textoBaseOrigem = textoBaseOrigem.Replace("{dimensaoB}", (DimensaoB / 10).ToString("F2"));
  
            }
            if(CitarIndice)
            {
                textoBaseOrigem += fraseIndiceEsplenico;
                IndiceEsplenico = (DimensaoA/10) * (DimensaoB/10);
                textoBaseOrigem = textoBaseOrigem.Replace("{indiceEsplenico}", IndiceEsplenico.ToString("F2"));

            }
            textoBaseOrigem += ".";
            if(Calcificacao)
            {
                textoBaseOrigem += fraseBacoCalcificacao;
                textoBaseOrigem = textoBaseOrigem.Replace("{dimensaoCalsificacao}", (DimensaoCalcificacao / 10).ToString("F2"));
             
            }
            if (BacoAcessorio)
            {
                textoBaseOrigem += fraseBacoAcessorio;
                textoBaseOrigem = textoBaseOrigem.Replace("{dimensaoAcessorioA}", (DimensaoAcessorioA / 10.00M).ToString("F2"));
                textoBaseOrigem = textoBaseOrigem.Replace("{dimensaoAcessorioB}", (DimensaoAcessorioB / 10.00M).ToString("F2"));

            }
            TextDescConc.TextFormatBase = textoBaseOrigem;
            return TextDescConc;

        }

    }
}
