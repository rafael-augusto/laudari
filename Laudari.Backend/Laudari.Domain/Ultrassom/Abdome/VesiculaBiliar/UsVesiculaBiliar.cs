using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laudari.Domain.Helpers;

namespace Laudari.Domain.Ultrassom.Abdome.VesiculaBiliar
{
    public class UsVesiculaBiliar : IBaseUltrassom
    {

        public List<KeyText> ComposicaoChaveTexto { get; set; }

        public VesiculaClassificacao Classificacao { get; set; }

        public ClassificadorQuantidade QuantidadeCalculo { get; set; }
        public decimal? DimensaoCalculo { get; set; }
        public decimal? DimensaoACalculo { get; set; }
        public decimal? DimensaoBCalculo { get; set; }
        public bool Colecistite { get; set; }

        public ClassificadorQuantidade QuantidadePolipo { get; set; }
        public decimal? DimensaoPolipo { get; set; }
        public decimal? DimensaoPolipoMaior { get; set; }

        public bool Colesterolose { get; set; }

        public DescricaoConclusao TextDescConc { get; set; }

        private static UsVesiculaBiliar VesiculaPadrao { get; set; }

        static UsVesiculaBiliar()
        {
            VesiculaPadrao = new UsVesiculaBiliar
            {
                Classificacao = VesiculaClassificacao.Normal,

                QuantidadeCalculo = ClassificadorQuantidade.Nenhum,
                DimensaoCalculo = 7,
                DimensaoACalculo = 3,
                DimensaoBCalculo = 4,
                Colecistite = false,
                QuantidadePolipo = ClassificadorQuantidade.Nenhum,
                DimensaoPolipo = 3,
                DimensaoPolipoMaior = 4,

                Colesterolose = false,
            };
        }

        public UsVesiculaBiliar()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }

        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            var textoBaseConclusao = TextDescConc.TextFormatConclusao;

            #region Frases Classificação
            var fraseVesiculaBiliarNormal = "Vesícula biliar com forma e dimensões normais, paredes finas e regulares, apresentando conteúdo anecogênico sem imagens calculosas.";
            var fraseVesiculaBiliarVazia = "Vesícula biliar vazia, sem condições satisfatórias para análise.";
            var fraseVesiculaBiliarAusente = "Vesícula biliar não caracterizada (status pós-cirúrgico).";

            #endregion

            #region Frases Calculo
            var fraseVesiculaCalculoUnico = " Vesícula biliar com forma e dimensões normais, paredes finas e regulares, apresentando uma imagem calculosa em seu interior, móvel às mudanças de decúbito, medindo {descritivoCalculo}.";
            var fraseVesiculaCalculoMultiplos = " Vesícula biliar com forma e dimensões normais, paredes finas e regulares, apresentando imagens calculosas em seu interior, móveis às mudanças de decúbito, medindo de {descritivoCalculo}.";
            var fraseVesiculaColecistiteCalculoUnico = " Vesícula biliar distendida, com paredes espessadas, apresentando uma imagem calculosa fixa no infundíbulo, medindo de {descritivoCalculo}.";
            var fraseVesiculaColecistiteCalculoMultiplos = " Vesícula biliar distendida, com paredes espessadas, apresentando múltiplas imagens calculosas em seu interior, medindo de {descritivoCalculo}.";
            #endregion

            #region Frases Polipos
            var fraseVesiculaPolipoUnico = " Imagem polipoide hiperecogênica aderida à parede da vesícula, medindo {descritivoPolipo}.";
            var fraseVesiculaPolipoMultiplos = " Imagens polipoides hiperecogênicas aderidas às paredes da vesícula, medindo de {descritivoPolipo}.";
            var fraseVesiculaColesterolose = " Há focos hiperecogênicos puntiformes fixos na parede vesicular, determinando reverberação posterior do feixe acústico.";
            #endregion

            #region Frases Conclusão
            var fraseConclusaoVesiculaVazia = "Vesícula biliar vazia.";
            var fraseConclusaoVesiculaAusente = "Colecistectomia.";
            var fraseConclusaoVesicularCalculo = "Colecistopatia calculosa.";
            var fraseConclusaoVesucularPolipo = "Imagem compatível com pólipo na vesícula biliar.";
            var fraseConclusaoVesiculaColesterolose = "Sinais de colesterolose vesicular.";
            #endregion

            #region Classificacao Vesicula
            switch (Classificacao)
            {
                case VesiculaClassificacao.Normal:
                    textoBaseOrigem += fraseVesiculaBiliarNormal;
                    break;
                case VesiculaClassificacao.Vazia:
                    textoBaseOrigem += fraseVesiculaBiliarVazia;
                    textoBaseConclusao = fraseConclusaoVesiculaVazia;
                    break;
                case VesiculaClassificacao.Ausente:
                    textoBaseOrigem += fraseVesiculaBiliarAusente;
                    textoBaseConclusao = fraseConclusaoVesiculaAusente;

                    break;
            }
            #endregion

            #region Calculo

            if (DimensaoCalculo.HasValue && QuantidadeCalculo != ClassificadorQuantidade.Nenhum)
            {
                var textoCalculos = "";
                switch (QuantidadeCalculo)
                {
                    case ClassificadorQuantidade.Unico:
                        var fraseVesiculaCalculoUnicotmp = "";
                        if (Colecistite)
                            fraseVesiculaCalculoUnicotmp = fraseVesiculaColecistiteCalculoUnico;
                        else
                            fraseVesiculaCalculoUnicotmp = fraseVesiculaCalculoUnico;

                        textoCalculos += fraseVesiculaCalculoUnicotmp.Replace("{descritivoCalculo}", (DimensaoCalculo.Value / 10).ToString() + " cm");

                        break;
                    case ClassificadorQuantidade.Multiplos:
                        var fraseVesiculaCalculoMultiplostmp = "";
                        if (Colecistite)
                            fraseVesiculaCalculoMultiplostmp = fraseVesiculaColecistiteCalculoMultiplos;
                        else
                            fraseVesiculaCalculoMultiplostmp = fraseVesiculaCalculoMultiplos;
                        textoCalculos += fraseVesiculaCalculoMultiplostmp.Replace("{descritivoCalculo}", (DimensaoACalculo.GetValueOrDefault(0) / 10).ToString() + " a " + (DimensaoBCalculo.GetValueOrDefault(0) / 10).ToString() + " cm");
                        break;
                }

                textoBaseOrigem += textoCalculos;
                textoBaseConclusao = fraseConclusaoVesicularCalculo;
            }
            #endregion

            #region Polipos

            if (DimensaoPolipo.HasValue && QuantidadePolipo != ClassificadorQuantidade.Nenhum)
            {
                var textoPolipos = "";
                switch (QuantidadePolipo)
                {
                    case ClassificadorQuantidade.Unico:
                        textoPolipos += fraseVesiculaPolipoUnico.Replace("{descritivoPolipo}", (DimensaoPolipo.Value / 10).ToString() + " cm");
                        textoBaseConclusao += fraseConclusaoVesucularPolipo;
                        break;
                    case ClassificadorQuantidade.Multiplos:
                        textoPolipos += fraseVesiculaPolipoMultiplos.Replace("{descritivoPolipo}", (DimensaoPolipo.Value / 10).ToString() + " a " + (DimensaoPolipoMaior.GetValueOrDefault(0) / 10).ToString() + " cm");
                        textoBaseConclusao += fraseConclusaoVesucularPolipo.Replace("pólipo", "pólipos");
                        break;
                    case ClassificadorQuantidade.Colesterolose:
                        if (QuantidadePolipo != ClassificadorQuantidade.Colesterolose)
                        textoPolipos += fraseVesiculaColesterolose;
                        textoBaseConclusao += fraseConclusaoVesiculaColesterolose;
                        break;
                }

                textoBaseOrigem += textoPolipos;
            }
            #endregion

            TextDescConc.TextFormatBase = textoBaseOrigem;
            TextDescConc.TextFormatConclusao = textoBaseConclusao;

            return TextDescConc;

        }
    }

}
