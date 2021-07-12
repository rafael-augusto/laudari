using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laudari.Domain.Helpers;

namespace Laudari.Domain.Ultrassom.Abdome.Figado
{
    public class UsFigado : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }

        public UsFigado()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }


        public FigadoClassificacao Classificacao { get; set; }
        public DimensoesDescritivo DimensaoDescritivo { get; set; }
        public GrauEsteatose GrauEsteatose { get; set; }
        public TipoHepatopatiaCronica TipoHepatopatiaCronica { get; set; }

        public ClassificadorQuantidade QuantidadeCistos { get; set; }
        public decimal? DimensaoCisto { get; set; }
        public SegmentoFigado SegmentoCisto { get; set; }

        public bool LoboDireito { get; set; }
        public bool LoboEsquerdo { get; set; }
        public bool LoboCaudado { get; set; }

        public decimal DimensaoLoboDireito { get; set; }
        public decimal DimensaoLoboEsquerdo { get; set; }
        public decimal DimensaoLoboCaudado { get; set; }

        public ClassificadorQuantidade QuantidadeNodulos { get; set; }
        public ClassificacaoNoduloFigado ClassificacaoNodulo { get; set; }
        public decimal DimensaoANodulo { get; set; }
        public decimal DimensaoBNodulo { get; set; }
        public ClassificacaoContorno ClassificacaoContornoNodulo { get; set; }
        public SegmentoFigado SegmentoANodulo { get; set; }
        public SegmentoFigado SegmentoBNodulo { get; set; }
        public EnfaseMultiplosNodulos EnfaseNodulo { get; set; }
        public bool CalcificacaoGrosseira { get; set; }
        public decimal DimensaoCalcificacao { get; set; }
        public SegmentoFigado SegmentoCalcificacao { get; set; }

        public bool SistemaPorta { get; set; }
        public bool CalibreVeiaPorta { get; set; }
        public decimal? DimensaoCalibreVeiaPorta { get; set; }
        public bool CalibreVeiaEsplenica { get; set; }
        public decimal? DimensaoCalibreVeiaEsplenica { get; set; }

        public bool IncluirDoppler { get; set; }
        public FluxoPortal FluxoPortal { get; set; }
        public decimal? VelocidadeVeiaPorta { get; set; }

        public bool CheckVelocidadeVeiaEsplenica { get; set; }
        public decimal? VelocidadeVeiaEsplenica { get; set; }

        public bool ColateraisPequenaCurvaturaGastrica { get; set; }
        public bool ColateraisHiloEsplenico { get; set; }
        public bool RecanalizacaoVeiaParaumbilical { get; set; }

        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            var textoBaseConclusao = TextDescConc.TextFormatConclusao;

            #region Frases Classificação
            var fraseFigadoNormal = "Fígado com dimensões {fraseDimensaoFigado}, contornos regulares, bordas finas e ecotextura homogênea.";
            var fraseFigadoEsteatoseGrauNaoEspecificado = "Fígado com dimensões {fraseDimensaoFigado}, contornos regulares e bordas finas, apresentando aumento difuso da ecogenicidade que determina atenuação posterior do feixe acústico.";
            var fraseFigadoEsteatoseDiscreta = "Fígado com dimensões {fraseDimensaoFigado}, contornos regulares e bordas finas, apresentando discreto aumento difuso da ecogenicidade.";
            var fraseFigadoEsteatoseModerada = "Fígado com dimensões {fraseDimensaoFigado}, contornos regulares e bordas finas, apresentando aumento difuso da ecogenicidade que determina atenuação posterior do feixe acústico.";
            var fraseFigadoEsteatoseAcentuada = "Fígado com dimensões {fraseDimensaoFigado}, contornos regulares e bordas finas, apresentando acentuado aumento da ecogenicidade do parênquima que determina atenuação posterior do feixe acústico, limitando a detecção de lesões focais.";
            var fraseFigadoHepatopatiaCronica = "Fígado com dimensões {fraseDimensaoFigado}, contornos serrilhados, bordas rombas e ecotextura difusamente heterogênea.";
            var fraseFigadoHepatopatiaIncipiente = "Fígado com dimensões {fraseDimensaoFigado} e ecotextura difusamente heterogênea, com bordas discretamente rombas, conservando contornos regulares.";

            #endregion

            #region Frases Cistos
            var fraseFigadoCistoUnico = " Cisto de conteúdo anecogênico, com paredes finas e contornos regulares, medindo{descritivoCisto}.";
            var fraseFigadoMultiplosCistos = " Cistos de conteúdo anecogênico, com paredes finas e contornos regulares, medindo até{descritivoCisto}.";
            #endregion

            #region Frases Nódulos
            var fraseFigadoNoduloUnico = " Nódulo{descricaoNodulo}.";
            var fraseFigadoDoisNodulos = " Presença de dois nódulos{descricaoNodulo}.";
            var fraseFigadoVariosNodulos = " Presença de vários nódulos{descricaoNodulo}.";
            #endregion

            #region Frases Calcificação
            var fraseCalcificacaoGrosseira = " Nota-se uma calcificação grosseira de {dimensaoCalcificacao} cm localizada no {segmentoCalcificacao}.";
            #endregion

            #region Frases Veia Porta
            var fraseVeiaPortaSemAlteracoes = " Veia porta e veias hepáticas sem alterações.";
            var fraseVeiaPortaCalibre = " Veia porta com calibre de {calibreVeiaPorta} cm. Veias hepáticas sem alterações.";
            var fraseVeiaEsplenicaCalibre = " Veia esplênica com calibre de {calibreVeiaEsplenica} cm.";

            var fraseVeiaPortaDoppler = " Veia porta pérvia ao Doppler, com calibre de {calibreVeiaPorta} cm. Seu fluxo é {fluxoVeiaPorta}, com velocidade de {velocidadeVeiaPorta} cm/s. Veias hepáticas pérvias.";
            var fraseVeiaEsplenicaVelocidade = " Velocidade de fluxo da veia esplênica: {velocidadeVeiaEsplenica} cm/s.";

            var fraseVeiaColateralPeqCurvHiloEsplenico = " Presença de veias colaterais dilatadas e tortuosas junto à pequena curvatura gástrica e no hilo esplênico.";
            var fraseVeiaColateralPeqCurvGastrica = " Presença de veias colaterais dilatadas e tortuosas junto à pequena curvatura gástrica.";
            var fraseVeiaColateralHiloEsplenico = " Presença de veias colaterais dilatadas e tortuosas no hilo esplênico.";

            var fraseVeiaParaumbilical = " Observa-se recanalização da veia paraumbilical.";
            #endregion

            #region Conclusao
            var fraseConclusaoEsteatose = "Sinais sugestivos de esteatose hepática{grau}.";
            var fraseConclusaoHepatopatiaCronica = "Sinais compatíveis com hepatopatia crônica<incipiente>.";
            var frasesConclusaoCistoHepatico = "Cisto hepático simples.";
            var frasesConclusaoCistosHepatico = "Cistos hepáticos simples.";
            var fraseConclusaoNoduloHepatico = "Nódulo hepático";
            var fraseConclusaoNodulosHepaticos = "Nódulos hepáticos";
            var fraseConclusaoNoduloHemangioma = "Provável hemangioma hepático.";
            var fraseConclusaoNodulosHemangioma = "Nódulos hepáticos (prováveis hemangiomas)";
            var fraseConclusaoCalcificacao = "Calcificação hepática de provável natureza sequelar";

            #endregion


            #region Classificacao Fígado
            switch (Classificacao)
            {
                case FigadoClassificacao.Homogeneo:
                    textoBaseOrigem += fraseFigadoNormal;
                    break;
                case FigadoClassificacao.Esteatose:
                    switch (GrauEsteatose)
                    {
                        case GrauEsteatose.NaoEspecificado:
                            textoBaseOrigem += fraseFigadoEsteatoseGrauNaoEspecificado;
                            textoBaseConclusao += fraseConclusaoEsteatose.Replace("{grau}", "");
                            break;
                        case GrauEsteatose.Discreta:
                            textoBaseOrigem += fraseFigadoEsteatoseDiscreta;
                            textoBaseConclusao += fraseConclusaoEsteatose.Replace("{grau}", GrauEsteatose.GetDescription());
                            break;
                        case GrauEsteatose.Moderada:
                            textoBaseOrigem += fraseFigadoEsteatoseModerada;
                            textoBaseConclusao += fraseConclusaoEsteatose.Replace("{grau}", GrauEsteatose.GetDescription());
                            break;
                        case GrauEsteatose.Acentuada:
                            textoBaseOrigem += fraseFigadoEsteatoseAcentuada;
                            textoBaseConclusao += fraseConclusaoEsteatose.Replace("{grau}", GrauEsteatose.GetDescription());
                            break;
                    }

                    break;
                case FigadoClassificacao.HepatopatiaCronica:
                    switch (TipoHepatopatiaCronica)
                    {
                        case TipoHepatopatiaCronica.Incipiente:
                            textoBaseOrigem += fraseFigadoHepatopatiaIncipiente;
                            textoBaseConclusao += fraseConclusaoHepatopatiaCronica.Replace("<incipiente>", TipoHepatopatiaCronica.GetDescription());
                            break;
                        case TipoHepatopatiaCronica.Avancada:
                            textoBaseOrigem += fraseFigadoHepatopatiaCronica;
                            textoBaseConclusao += fraseConclusaoHepatopatiaCronica.Replace("<incipiente>", "");
                            break;
                    }
                    break;
            }

            textoBaseOrigem = textoBaseOrigem.Replace("{fraseDimensaoFigado}", DimensaoDescritivo.GetDescription());
            #endregion

            #region Dimensões Figado
            bool[] checkMedidas = { LoboDireito, LoboEsquerdo, LoboCaudado };
            int countCheckMedidas = checkMedidas.Count(t => t);

            if (countCheckMedidas > 0)
            {
                var textoMedidaFigado = " O maior eixo longitudinal {fraseMedida}.";

                if (countCheckMedidas == 1)
                {
                    if (LoboDireito)
                        textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo direito mede {medidaLoboDireito} cm");
                    if (LoboEsquerdo)
                        textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo esquerdo mede {medidaLoboEsquerdo} cm");
                    if (LoboCaudado)
                        textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo caudado mede {medidaLoboCaudado} cm");

                }
                else if (countCheckMedidas == 2)
                {
                    if (LoboDireito && LoboEsquerdo)
                        textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo direito mede {medidaLoboDireito} cm e do lobo esquerdo {medidaLoboEsquerdo} cm");
                    if (LoboDireito && LoboCaudado)
                        textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo direito mede {medidaLoboDireito} cm e do lobo caudado {medidaLoboCaudado} cm");
                    if (LoboEsquerdo && LoboCaudado)
                        textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo esquerdo {medidaLoboEsquerdo} cm e do lobo caudado {medidaLoboCaudado} cm");
                }
                else if (countCheckMedidas == 3)
                {
                    textoMedidaFigado = textoMedidaFigado.Replace("{fraseMedida}", " do lobo direito mede {medidaLoboDireito} cm, do lobo esquerdo {medidaLoboEsquerdo} cm e do lobo caudado {medidaLoboCaudado} cm");

                }

                textoMedidaFigado = textoMedidaFigado.Replace("{medidaLoboDireito}", (DimensaoLoboDireito / 10).ToString());
                textoMedidaFigado = textoMedidaFigado.Replace("{medidaLoboEsquerdo}", (DimensaoLoboEsquerdo / 10).ToString());
                textoMedidaFigado = textoMedidaFigado.Replace("{medidaLoboCaudado}", (DimensaoLoboCaudado / 10).ToString());
                textoBaseOrigem += textoMedidaFigado;
            }
            #endregion

            #region Cistos
            if (DimensaoCisto.HasValue && QuantidadeCistos != ClassificadorQuantidade.Nenhum)
            {
                var textoCistos = "";
                switch (QuantidadeCistos)
                {
                    case ClassificadorQuantidade.Unico:
                        textoCistos += fraseFigadoCistoUnico.Replace("{descritivoCisto}", " {dimensaoCisto} cm, localizado no {segmentoCisto}");
                        textoBaseConclusao += frasesConclusaoCistoHepatico;
                        break;
                    case ClassificadorQuantidade.Multiplos:
                        textoCistos += fraseFigadoMultiplosCistos.Replace("{descritivoCisto}", " {dimensaoCisto} cm, o maior localizado no {segmentoCisto}");
                        textoBaseConclusao += frasesConclusaoCistosHepatico;
                        break;
                }

                textoCistos = textoCistos.Replace("{dimensaoCisto}", (DimensaoCisto.Value / 10).ToString());
                textoCistos = textoCistos.Replace("{segmentoCisto}", SegmentoCisto.GetDescription());

                textoBaseOrigem += textoCistos;
            }
            #endregion

            #region Nódulos
            if (QuantidadeNodulos != ClassificadorQuantidade.Nenhum)
            {
                var textoNodulos = "";
                switch (QuantidadeNodulos)
                {

                    case ClassificadorQuantidade.Unico:
                        textoNodulos += fraseFigadoNoduloUnico.Replace("{descricaoNodulo}", " {classificacaoNodulo} de contornos {contornoNodulo}, medindo {medidaANodulo} x {medidaBNodulo} cm, situado no {segmentoANodulo}");
                        if (ClassificacaoNodulo == ClassificacaoNoduloFigado.HiperecogenicoHemangioma)
                            textoBaseConclusao += fraseConclusaoNoduloHemangioma;
                        else
                            textoBaseConclusao += fraseConclusaoNoduloHepatico;
                        break;
                    case ClassificadorQuantidade.Multiplos:
                        switch (EnfaseNodulo)
                        {
                            case EnfaseMultiplosNodulos.DoisTotal:
                                textoNodulos += fraseFigadoDoisNodulos.Replace("{descricaoNodulo}", " {classificacaoNodulo}s de contornos {contornoNodulo}, medindo {medidaANodulo} cm ({segmentoANodulo}) e {medidaBNodulo} cm ({segmentoBNodulo})");
                                break;
                            case EnfaseMultiplosNodulos.DoisMaiores:
                                textoNodulos += fraseFigadoVariosNodulos.Replace("{descricaoNodulo}", " {classificacaoNodulo}s de contornos {contornoNodulo}, os maiores medindo {medidaANodulo} cm ({segmentoANodulo}) e {medidaBNodulo} cm ({segmentoBNodulo})");
                                break;
                        }
                        textoNodulos += fraseConclusaoNoduloHepatico;
                        if (ClassificacaoNodulo == ClassificacaoNoduloFigado.HiperecogenicoHemangioma)
                            textoBaseConclusao += fraseConclusaoNodulosHemangioma;
                        else
                            textoBaseConclusao += fraseConclusaoNodulosHepaticos;
                        break;
                }

                textoNodulos = textoNodulos.Replace("{classificacaoNodulo}", ClassificacaoNodulo.GetDescription());
                textoNodulos = textoNodulos.Replace("{contornoNodulo}", ClassificacaoContornoNodulo.GetDescription());
                textoNodulos = textoNodulos.Replace("{medidaANodulo}", (DimensaoANodulo / 10).ToString());
                textoNodulos = textoNodulos.Replace("{medidaBNodulo}", (DimensaoBNodulo / 10).ToString());
                textoNodulos = textoNodulos.Replace("{segmentoANodulo}", SegmentoANodulo.GetDescription());
                textoNodulos = textoNodulos.Replace("{segmentoBNodulo}", SegmentoBNodulo.GetDescription());

                textoBaseOrigem += textoNodulos;
            }
            #endregion

            #region Calcificação Grosseira
            if (CalcificacaoGrosseira)
            {
                var textoCalcificacao = fraseCalcificacaoGrosseira.Replace("{dimensaoCalcificacao}", (DimensaoCalcificacao / 10).ToString());
                textoCalcificacao = textoCalcificacao.Replace("{segmentoCalcificacao}", SegmentoCalcificacao.GetDescription());

                textoBaseOrigem += textoCalcificacao;
                textoBaseConclusao += fraseConclusaoCalcificacao;
            }
            #endregion

            var textoVeiaPorta = fraseVeiaPortaSemAlteracoes;

            #region Sistema Porta
            if (SistemaPorta)
            {
                if (CalibreVeiaPorta)
                {
                    if (IncluirDoppler)
                    {
                        textoVeiaPorta = fraseVeiaPortaDoppler;
                        textoVeiaPorta = textoVeiaPorta.Replace("{calibreVeiaPorta}", (DimensaoCalibreVeiaPorta / 10).ToString());
                        textoVeiaPorta = textoVeiaPorta.Replace("{fluxoVeiaPorta}", FluxoPortal.GetDescription());
                        textoVeiaPorta = textoVeiaPorta.Replace("{velocidadeVeiaPorta}", VelocidadeVeiaPorta.ToString());
                        if (CheckVelocidadeVeiaEsplenica)
                        {
                            textoVeiaPorta += fraseVeiaEsplenicaVelocidade;
                            textoVeiaPorta = textoVeiaPorta.Replace("{velocidadeVeiaEsplenica}", VelocidadeVeiaEsplenica.ToString());
                        }
                    }
                    else
                    {
                        textoVeiaPorta = fraseVeiaPortaCalibre;
                        textoVeiaPorta = textoVeiaPorta.Replace("{calibreVeiaPorta}", (DimensaoCalibreVeiaPorta / 10).ToString());
                    }
                }
                textoBaseOrigem += textoVeiaPorta;
                if (CalibreVeiaEsplenica)
                {
                    var textoVeiaEsplenica = fraseVeiaEsplenicaCalibre;
                    textoVeiaEsplenica = textoVeiaEsplenica.Replace("{calibreVeiaEsplenica}", (DimensaoCalibreVeiaEsplenica / 10).ToString());
                    textoBaseOrigem += textoVeiaEsplenica;
                }

                bool[] checkVeiaColaterais = { ColateraisPequenaCurvaturaGastrica, ColateraisHiloEsplenico };
                int countCheckVeiaColateral = checkVeiaColaterais.Count(t => t);
                if (countCheckVeiaColateral > 0)
                {
                    var textoColaterais = "";
                    if (countCheckVeiaColateral == 1)
                    {
                        if (ColateraisPequenaCurvaturaGastrica)
                            textoColaterais = fraseVeiaColateralPeqCurvGastrica;
                        if (ColateraisHiloEsplenico)
                            textoColaterais = fraseVeiaColateralHiloEsplenico;
                    }
                    else if (countCheckVeiaColateral == 2)
                    {
                        textoColaterais = fraseVeiaColateralPeqCurvHiloEsplenico;
                    }
                    textoBaseOrigem += textoColaterais;
                }
                if (RecanalizacaoVeiaParaumbilical)
                {
                    textoBaseOrigem += fraseVeiaParaumbilical;
                }

            }
            #endregion  

            TextDescConc.TextFormatBase = textoBaseOrigem;
            TextDescConc.TextFormatConclusao = textoBaseConclusao;

            return TextDescConc;

        }

    }

}
