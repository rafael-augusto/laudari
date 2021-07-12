using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Abdome.AortaRetroperitoneo;
using Laudari.Domain.Ultrassom.Abdome.RinsUreteres;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.RinsUreteres
{
    public class UsRinsUreteres : IBaseUltrassom

    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }

        public UsAorta UsAorta { get; set; }

        public bool AspectoNormal { get; set; }
        public bool AusenciaRimDireito { get; set; }
        public bool AusenciaRimEsquerdo { get; set; }
        public bool IncluirMedidaRins { get; set; }
        public decimal? RimDireitoL { get; set; }
        public bool IncluirRimDireitoT { get; set; }
        public decimal? RimDireitoT { get; set; }
        public bool IncluirRimDireitoAP { get; set; }
        public decimal? RimDireitoAP { get; set; }
        public bool IncluirRimDireitoParenquima { get; set; }
        public decimal? RimDireitoParenquima { get; set; }
        public decimal? RimEsquerdoL { get; set; }
        public bool IncluirRimEsquerdoT { get; set; }
        public decimal? RimEsquerdoT { get; set; }
        public bool IncluirRimEsquerdoAP { get; set; }
        public decimal? RimEsquerdoAP { get; set; }
        public bool IncluirRimEsquerdoParenquima { get; set; }
        public decimal? RimEsquerdoParenquima { get; set; }
        public bool IncluirDopplerArteriasRenais { get; set; }
        public decimal? VPSDireita { get; set; }
        public decimal? VPSEsquerda { get; set; }
        public bool CitarRelacaoVPSArteriasRenais { get; set; }
        public bool ArteriaRenalDireitaInacessivel { get; set; }
        public bool ArteriaRenalEsquerdaInacessivel { get; set; }

        public bool CitarAASegmentaresDireita { get; set; }
        public bool IncluirSuperiorDireita { get; set; }
        public decimal? SuperiorDireita { get; set; }
        public bool IncluirMediaDireita { get; set; }
        public decimal? MediaDireita { get; set; }
        public bool IncluirInferiorDireita { get; set; }
        public decimal? InferiorDireita { get; set; }

        public bool CitarAASegmentaresEsquerda { get; set; }
        public bool IncluirSuperiorEsquerda { get; set; }
        public decimal? SuperiorEsquerda { get; set; }
        public bool IncluirMediaEsquerda { get; set; }
        public decimal? MediaEsquerda { get; set; }
        public bool IncluirInferiorEsquerda { get; set; }
        public decimal? InferiorEsquerda { get; set; }

        public bool PossuiNefropatiaParenquimatosaCronica { get; set; }
        public EnumRinsClassificacaoNefropatia PosicaoNefropatiaParenquimatosaCronica { get; set; }

        public bool PossuiNoduloSolido { get; set; }
        public EnumRinsClassificacaoNoduloSolido ClassificacaoNoduloSolido { get; set; }
        public EnumRinsContornoNoduloSolido ContornoNoduloSolido { get; set; }
        public decimal? DimensaoANoduloSolido { get; set; }
        public decimal? DimensaoBNoduloSolido { get; set; }
        public EnumRinsPosicao PosicaoNoduloSolido { get; set; }
        public EnumRinsEsquerdoDireito RimNoduloSolido { get; set; }

        public bool PossuiCisto1 { get; set; }
        public decimal? DimensaoCisto1 { get; set; }
        public EnumRinsPosicao PosicaoCisto1 { get; set; }
        public EnumRinsEsquerdoDireito RimCisto1 { get; set; }

        public bool PossuiCisto2 { get; set; }
        public decimal? DimensaoCisto2 { get; set; }
        public EnumRinsPosicao PosicaoCisto2 { get; set; }
        public EnumRinsEsquerdoDireito RimCisto2 { get; set; }

        public bool PossuiCisto3 { get; set; }
        public decimal? DimensaoCisto3 { get; set; }
        public EnumRinsPosicao PosicaoCisto3 { get; set; }
        public EnumRinsEsquerdoDireito RimCisto3 { get; set; }

        public bool PossuiCisto4 { get; set; }
        public decimal? DimensaoCisto4 { get; set; }
        public EnumRinsPosicao PosicaoCisto4 { get; set; }
        public EnumRinsEsquerdoDireito RimCisto4 { get; set; }

        public bool PossuiVariosCistosBilaterais { get; set; }
        public decimal? DimensaoCistosBilaterais { get; set; }
        public EnumRinsPosicao PosicaoCistosBilaterais { get; set; }
        public EnumRinsEsquerdoDireito RimCistosBilaterais { get; set; }

        public bool PossuiCalculo1 { get; set; }
        public decimal? DimensaoCalculo1 { get; set; }
        public EnumRinsPosicao PosicaoCalculo1 { get; set; }
        public EnumRinsEsquerdoDireito RimCalculo1 { get; set; }

        public bool PossuiCalculo2 { get; set; }
        public decimal? DimensaoCalculo2 { get; set; }
        public EnumRinsPosicao PosicaoCalculo2 { get; set; }
        public EnumRinsEsquerdoDireito RimCalculo2 { get; set; }

        public bool PossuiCalculo3 { get; set; }
        public decimal? DimensaoCalculo3 { get; set; }
        public EnumRinsPosicao PosicaoCalculo3 { get; set; }
        public EnumRinsEsquerdoDireito RimCalculo3 { get; set; }

        public bool PossuiCalculo4 { get; set; }
        public decimal? DimensaoCalculo4 { get; set; }
        public EnumRinsPosicao PosicaoCalculo4 { get; set; }
        public EnumRinsEsquerdoDireito RimCalculo4 { get; set; }

        public bool PossuiVariosCalculosBilaterais { get; set; }
        public decimal? DimensaoCalculosBilaterais { get; set; }
        public EnumRinsPosicao PosicaoCalculosBilaterais { get; set; }
        public EnumRinsEsquerdoDireito RimCalculosBilaterais { get; set; }

        public bool PossuiMicroCalculosBilaterais { get; set; }

        public EnumRinsDilatacaoPielocalcinal DilatacaoPielocalcinalDireita { get; set; }
        public EnumRinsDilatacaoPielocalcinal DilatacaoPielocalcinalEsquerda { get; set; }

        public bool AdicionarUretralDilatacaoDireita { get; set; }
        public bool AdicionarUretralDilatacaoEsquerda { get; set; }

        public bool PossuiCalculoUretral { get; set; }
        public decimal? DimensaoCalculoUretral { get; set; }

        public EnumRinsPosicaoCalculoUretral PosicaoCalculoUretral { get; set; }
        public EnumRinsEsquerdoDireito CalculoUretralDireitoEsquerdo { get; set; }








        public UsRinsUreteres()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }


        #region Frases

        string fraseRinsNormal = "Rins tópicos com dimensões normais, contornos regulares e ecotextura habitual.";
        string fraseRinsNefropatiaLado = "Rins tópicos, notando-se redução da espessura e aumento da ecogenicidade do parênquima do rim {rim}. O rim {rimOposto} conserva dimensões, espessura e ecogenicidade parenquimatosa normais.";
        string fraseRinsNefropatiaBilateral = "Rins tópicos, com dimensões normais e contornos regulares, notando-se redução da espessura e aumento da ecogenicidade do parênquima bilateralmente.";

        string fraseAusenciaRimDireito = "Rim direito não caracterizado.";
        string fraseAusenciaRimEsquerdo = "Rim esquerdo não caracterizado.";
        string fraseRimDireitoNormal = " Rim direito tópico, com dimensões normais, contornos regulares e ecotextura habitual.";
        string fraseRimEsquerdoNormal = " Rim esquerdo tópico, com dimensões normais, contornos regulares e ecotextura habitual.";

        string fraseRinsNefropatiaAusenciaRim = " Rim {rim} tópico, com dimensões normais e contornos regulares, notando-se redução da espessura e aumento da ecogenicidade do parênquima.";

        string fraseMedidaRim = "</br>Dimensões renais:";
        string fraseMedidaRimLado = "</br>- rim {rim}: {L} {T} {AP} cm.";
        string fraseMedidaRimVolume = " Volume: {Vol} cm³.";
        string fraseEspecuraParenquima = "</br>- espessura do parênquima à {rim}: {esp} cm.";




        string fraseIncluirDopplerVPS = "A avaliação das artérias renais com Doppler demonstra curvas espectrais preservadas, com velocidades sistólicas de {VPSDireita} cm/s à direita e {VPSEsquerda} cm/s à esquerda.";
        string fraseIncluirDopplerVPSAusenciaRim = "A avaliação da artéria renal com Doppler demonstra curvas espectrais preservadas, com velocidade sistólica de {VPSDoppler} cm/s.";

        string fraseRelacaoVPSAorta = " Relação de VPS da a. renal / VPS da aorta mensurada em {velocidadeRelacaoVPSAortaDireita} à direita e {velocidadeRelacaoVPSAortaEsquerda} à esquerda (normal até 3,5).";
        string fraseRelacaoVPSAortaAusenciaRim = " Relação de VPS da a. renal / VPS da aorta mensurada em {velocidadeRelacaoVPSAorta} (normal até 3,5).";


        string fraseDopplerVPSArteriaRenalInacessivel = " Não foi possível efetuar a avaliação com Doppler da artéria renal {rimFem} em razão de interposição gasosa.";
        string fraseDopplerVPSOutraArteria = " A avaliação da artéria renal {rimFem} com Doppler demonstra curvas espectrais preservadas, com velocidade sistólica de {VPSDoppler} cm/s.";

        string fraseDopplerVPSArteriasInacessiveis = " Não foi possível efetuar a avaliação com Doppler das artérias renais em razão de interposição gasosa.";

        string fraseDopplerFluxoArterias = " Foi efetuada análise do fluxo das artérias segmentares nos seios renais, demonstrando valores de aceleração normais bilateralmente.";

        string fraseDopplerFluxoArteriaUmLado = " Foi efetuada análise do fluxo das artérias segmentares no seio renal {rim}, demonstrando valores de aceleração normais.";

        string fraseDopplerAceleracaoArterial = " <b>A. Segmentar {arteriaLadoAceleracao}: Aceleração = {valorAceleracao} m/s²</b>";



        string fraseNefropatiaCronica = "Sinais compatíveis com nefropatia parenquimatosa crônica.";
        string fraseNefropatiaCronicaLado = "Sinais compatíveis com nefropatia parenquimatosa crônica à {rimFem}.";

        string fraseNodulo = " Presença de um nódulo {classificacaoNodulo} de {contornoNodulo}, medindo {dimensaoANodulo} x {dimensaoBNodulo} cm localizado no {localNodulo} do rim {rim}.";



        string fraseCistoUnico = " Cisto de conteúdo anecogênico, com paredes finas e contornos regulares, medindo {dimensaoCisto} cm, visível no {localCisto} do rim {rim}.";
        string fraseCistosIndividuais = " Presença de {quantidadeCistos} cistos de conteúdo anecogênico, com paredes finas e contornos regulares, assim caracterizados:";
        string fraseCistoEspecificacao = "- {dimensaoCisto} cm, no {localCisto} do rim {rim}.";
        string fraseMultiplosCistos = " Cistos de conteúdo anecogênico, com paredes finas e contornos regulares, bilaterais, medindo até {dimensaoCisto} cm, o maior localizado no {localCisto} do rim {rim}.";

        string fraseCalculoUnico = " Cálculo de {dimensaoCalculo} cm no grupamento calicinal {localCalculo} do rim {rim}.";
        string fraseCalculosIndividuais = " Presença de {quantidadeCalculos} cálculos calicinais bilaterais, nas seguintes topografias:";
        string fraseCalculoEspecificacao = "- {dimensaoCalculo} cm, no grupamento {localCalculo} do rim {rim}.";
        string fraseMultiplosCalculos = " Imagens calculosas bilaterais, medindo até {dimensaoCalculo} cm, a maior localizada no grupamento calicinal {localCalculo} do rim {rim}.";
        string fraseMicrocalculosBilaterais = " Nos seios renais são observados focos hiperecogênicos puntiformes sem sombra acústica definida, podendo corresponder a microcálculos calicinais ou calcificações vasculares.";

        string fraseDilatacaoLado = "Presença de {classificacaoDilatacao} dilatação pielocalicinal à {rimFem}.";
        string fraseDilatacaoBilateral = "Presença de {classificacaoDilatacao} dilatação pielocalicinal bilateral.";

        string fraseDilatacaoUreteralLado = "Presença de {classificacaoDilatacao} dilatação pielocalicinal e ureteral à {rimFem}.";
        string fraseDilatacaoUreteralBilateral = "Presença de {classificacaoDilatacao} dilatação pielocalicinal e ureteral bilateral.";

        string fraseDilatacaoDiferencaUreteralBilateral = "Presença de dilatação pielocalicinal e ureteral bilateral, sendo {classificacaoDilatacaoDireita} à direita e {classificacaoDilatacaoEsquerda} à esquerda.";

        string fraseDilatacaoDiferencaBilateral = "Presença de dilatação pielocalicinal bilateral, sendo {classificacaoDilatacaoDireita} à direita e {classificacaoDilatacaoEsquerda} à esquerda.";

        string fraseAdicionarUreteralLado = " Nota-se também dilatação ureteral à {rimFem}.";
        string fraseCalculoUreteral = "Cálculo de {dimensaoCalculoUreteral} cm no {localCalculoUreteral} à {rimFem}.";

        string fraseAusenciaCalculos = " Não há evidências de imagens calculosas calicinais.";
        string fraseAusenciaDilatacaoSistemaColetor = " Não há dilatação do sistema coletor.";



        #endregion




        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            //var textoBaseConclusao = TextDescConc.TextFormatConclusao;


            textoBaseOrigem += MontaAspectoInicialRim();

            textoBaseOrigem += MontaNodulos();
            textoBaseOrigem += MontaCistos();
            textoBaseOrigem += MontaCalculos();
            textoBaseOrigem += MontaDilatacao();
            textoBaseOrigem += MontaDoppler();
            textoBaseOrigem += MontaCalculoUreteral();
            textoBaseOrigem += MontaDimensoesRenais();



            TextDescConc.TextFormatBase = textoBaseOrigem;


            return TextDescConc;
        }

        private string MontaCalculoUreteral()
        {
            var textoCalculoUretal = "";
            if (PossuiCalculoUretral)
            {
                textoCalculoUretal = fraseCalculoUreteral.Replace("{dimensaoCalculoUreteral}", (DimensaoCalculoUretral.GetValueOrDefault(0) / 10).ToString("F2")).
                    Replace("{localCalculoUreteral}", PosicaoCalculoUretral.GetDescription()).
                    Replace("{rimFem}", CalculoUretralDireitoEsquerdo.GetDescription());
            }

            return textoCalculoUretal;
        }

        private string MontaDimensoesRenais()
        {
            var textoDimensoesRenais = "";
            if (IncluirMedidaRins)
            {
                textoDimensoesRenais += fraseMedidaRim;
                if (!AusenciaRimDireito)
                {
                    textoDimensoesRenais += fraseMedidaRimLado.Replace("{rim}", EnumRinsEsquerdoDireito.RimDireito.GetDescription());
                    textoDimensoesRenais = textoDimensoesRenais.Replace("{L}", (RimDireitoL.GetValueOrDefault(0) / 10).ToString("F2"));
                    if (IncluirRimDireitoT)
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{T}", " x " + (RimDireitoT.GetValueOrDefault(0) / 10).ToString("F2"));
                    else
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{T}", "");
                    if (IncluirRimDireitoAP)
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{AP}", " x" + (RimDireitoAP.GetValueOrDefault(0) / 10).ToString("F2"));
                    else
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{AP}", "");
                    if (IncluirRimDireitoT && IncluirRimDireitoAP)
                    {
                        decimal vol = (RimDireitoL.GetValueOrDefault(0) / 10 * RimDireitoT.GetValueOrDefault(0) / 10 * RimDireitoAP.GetValueOrDefault(0) / 10) * 5236 / 10000;
                        textoDimensoesRenais += fraseMedidaRimVolume.Replace("{Vol}", vol.ToString("0.0"));
                    }
                    if (IncluirRimDireitoParenquima)
                        textoDimensoesRenais += fraseEspecuraParenquima.Replace("{rim}", EnumRinsEsquerdoDireito.RimDireito.GetDescription()).
                            Replace("{esp}", (RimDireitoParenquima.GetValueOrDefault(0) / 10).ToString("F2"));

                }
                if (!AusenciaRimEsquerdo)
                {
                    textoDimensoesRenais += fraseMedidaRimLado.Replace("{rim}", EnumRinsEsquerdoDireito.RimEsquerdo.GetDescription());
                    textoDimensoesRenais = textoDimensoesRenais.Replace("{L}", (RimEsquerdoL.GetValueOrDefault(0) / 10).ToString("F2"));
                    if (IncluirRimEsquerdoT)
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{T}", " x " + (RimEsquerdoT.GetValueOrDefault(0) / 10).ToString("F2"));
                    else
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{T}", "");
                    if (IncluirRimEsquerdoAP)
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{AP}", " x" + (RimEsquerdoAP.GetValueOrDefault(0) / 10).ToString("F2"));
                    else
                        textoDimensoesRenais = textoDimensoesRenais.Replace("{AP}", "");
                    if (IncluirRimEsquerdoT && IncluirRimEsquerdoAP)
                    {
                        decimal vol = (RimEsquerdoL.GetValueOrDefault(0) / 10 * RimEsquerdoT.GetValueOrDefault(0) / 10 * RimEsquerdoAP.GetValueOrDefault(0) / 10) * 5236 / 10000;
                        textoDimensoesRenais += fraseMedidaRimVolume.Replace("{Vol}", vol.ToString("0.0"));
                    }
                    if (IncluirRimEsquerdoParenquima)
                        textoDimensoesRenais += fraseEspecuraParenquima.Replace("{rim}", EnumRinsEsquerdoDireito.RimEsquerdo.GetDescription()).
                            Replace("{esp}", (RimEsquerdoParenquima.GetValueOrDefault(0) / 10).ToString("F2"));
                }
            }
            return textoDimensoesRenais;
        }

        private string MontaDoppler()
        {
            var textoDoppler = "";
            if (IncluirDopplerArteriasRenais)
            {
                if (!AusenciaRimDireito && !AusenciaRimEsquerdo)
                {
                    textoDoppler += fraseIncluirDopplerVPS;
                    textoDoppler = textoDoppler.Replace("{VPSDireita}", (VPSDireita.GetValueOrDefault(0) / 10).ToString("F2"));
                    textoDoppler = textoDoppler.Replace("{VPSEsquerda}", (VPSEsquerda.GetValueOrDefault(0) / 10).ToString("F2"));
                }
                else
                {

                    textoDoppler = fraseIncluirDopplerVPSAusenciaRim;

                    var vpsRim = AusenciaRimDireito ? VPSEsquerda : VPSDireita;
                    textoDoppler = textoDoppler.Replace("{VPSDoppler}", (vpsRim.GetValueOrDefault(0) / 10).ToString("F2"));


                }

      

                if (ArteriaRenalDireitaInacessivel || ArteriaRenalEsquerdaInacessivel)
                {
                    if (ArteriaRenalDireitaInacessivel && ArteriaRenalEsquerdaInacessivel)
                    {
                        textoDoppler = fraseDopplerVPSArteriasInacessiveis;
                        return textoDoppler;
                    }
                    else
                    {
                        textoDoppler = fraseDopplerVPSArteriaRenalInacessivel;
                        decimal? vpsRim = 0.0M;
                        var rimFem = "";
                        if (ArteriaRenalDireitaInacessivel)
                        {
                            textoDoppler = textoDoppler.Replace("{rimFem}", "direita");
                            rimFem = "esquerda";
                            vpsRim = VPSEsquerda;
                        }
                        if (ArteriaRenalEsquerdaInacessivel)
                        {
                            textoDoppler = textoDoppler.Replace("{rimFem}", "esquerda");
                            rimFem = "direita";
                            vpsRim = VPSDireita;
                        }

                        textoDoppler += fraseDopplerVPSOutraArteria;

                        textoDoppler = textoDoppler.Replace("{rimFem}", rimFem);
                        textoDoppler = textoDoppler.Replace("{VPSDoppler}", (vpsRim.GetValueOrDefault(0) / 10).ToString("F2"));


                    }
                }

                if (CitarRelacaoVPSArteriasRenais)
                {
                    var textoRelacaoVPSAorta = "";
                    if (!UsAorta.CitarFluxoNormalDoppler || !UsAorta.CitarVPS)
                        throw new Exception("Para citar a relação VPS artérias renais / aorta é necessário informar a velocidade sistólica da aorta");
                    if (!AusenciaRimDireito && !AusenciaRimEsquerdo)
                    {
                        textoRelacaoVPSAorta = fraseRelacaoVPSAorta;
                        var relacaoVpsEsq = VPSEsquerda.GetValueOrDefault(0) / UsAorta.VPS;
                        var relacaoVpsDir = VPSDireita.GetValueOrDefault(0) / UsAorta.VPS;
                        var relacaoVpsAortaEsquerda = relacaoVpsEsq < 2 ? Math.Ceiling(relacaoVpsEsq) : Math.Floor(relacaoVpsEsq);
                        var relacaoVpsAortaDireita = relacaoVpsDir < 2 ? Math.Ceiling(relacaoVpsDir) : Math.Floor(relacaoVpsDir);
                        textoRelacaoVPSAorta = textoRelacaoVPSAorta.Replace("{velocidadeRelacaoVPSAortaDireita}", relacaoVpsAortaDireita.ToString("F2"));
                        textoRelacaoVPSAorta = textoRelacaoVPSAorta.Replace("{velocidadeRelacaoVPSAortaEsquerda}", relacaoVpsAortaEsquerda.ToString("F2"));
                    }
                    else
                    {
                        textoRelacaoVPSAorta = fraseRelacaoVPSAortaAusenciaRim;
                        var vpsRim = AusenciaRimDireito ? VPSEsquerda : VPSDireita;
                        var vpsRimAorta = vpsRim.GetValueOrDefault(0) / UsAorta.VPS;
                        var vpsRimAortaFinal  = vpsRimAorta < 2 ? Math.Ceiling(vpsRimAorta) : Math.Floor(vpsRimAorta);
                        textoRelacaoVPSAorta = textoRelacaoVPSAorta.Replace("{velocidadeRelacaoVPSAorta}", vpsRimAortaFinal.ToString("F2"));
                    }
                    textoDoppler += "<p>" + textoRelacaoVPSAorta +"</p>";


                }


                if (CitarAASegmentaresDireita || CitarAASegmentaresEsquerda)
                {

                    if (!AusenciaRimDireito && !AusenciaRimEsquerdo)
                    {
                        textoDoppler += fraseDopplerFluxoArterias;
                    }
                    else
                    {
                        if (AusenciaRimEsquerdo)
                        {
                            textoDoppler += fraseDopplerFluxoArteriaUmLado;
                            textoDoppler = textoDoppler.Replace("{rim}", "direito");

                        }
                        else if (AusenciaRimDireito)
                        {
                            textoDoppler += fraseDopplerFluxoArteriaUmLado;
                            textoDoppler = textoDoppler.Replace("{rim}", "esquerdo");


                        }


                    }

                    if (CitarAASegmentaresDireita && !AusenciaRimDireito)
                    {
                        if (IncluirSuperiorDireita)
                        {
                            textoDoppler += "<br/>&nbsp;&nbsp;&nbsp;&nbsp";
                            textoDoppler += fraseDopplerAceleracaoArterial.Replace("{arteriaLadoAceleracao}", "Superior Direita").Replace("{valorAceleracao}", (SuperiorDireita.GetValueOrDefault(0) / 10).ToString("F2"));
                        }
                        if (IncluirMediaDireita)
                        {
                            textoDoppler += "<br/>&nbsp;&nbsp;&nbsp;&nbsp";
                            textoDoppler += fraseDopplerAceleracaoArterial.Replace("{arteriaLadoAceleracao}", "Média Direita").Replace("{valorAceleracao}", (MediaDireita.GetValueOrDefault(0) / 10).ToString("F2"));
                        }
                        if (IncluirInferiorDireita)
                        {
                            textoDoppler += "<br/>&nbsp;&nbsp;&nbsp;&nbsp";
                            textoDoppler += fraseDopplerAceleracaoArterial.Replace("{arteriaLadoAceleracao}", "Inferior Direita").Replace("{valorAceleracao}", (InferiorDireita.GetValueOrDefault(0) / 10).ToString("F2"));
                        }
     
                    }
                    if (CitarAASegmentaresEsquerda && !AusenciaRimEsquerdo)
                    {
                        if (IncluirSuperiorEsquerda)
                        {
                            textoDoppler += "<br/>&nbsp;&nbsp;&nbsp;&nbsp";
                            textoDoppler += fraseDopplerAceleracaoArterial.Replace("{arteriaLadoAceleracao}", "Superior Esquerda").Replace("{valorAceleracao}", (SuperiorEsquerda.GetValueOrDefault(0) / 10).ToString("F2"));
                        }
                        if (IncluirMediaEsquerda)
                        {
                            textoDoppler += "<br/>&nbsp;&nbsp;&nbsp;&nbsp";
                            textoDoppler += fraseDopplerAceleracaoArterial.Replace("{arteriaLadoAceleracao}", "Média Esquerda").Replace("{valorAceleracao}", (MediaEsquerda.GetValueOrDefault(0) / 10).ToString("F2"));
                        }
                        if (IncluirInferiorEsquerda)
                        {
                            textoDoppler += "<br/>&nbsp;&nbsp;&nbsp;&nbsp";
                            textoDoppler += fraseDopplerAceleracaoArterial.Replace("{arteriaLadoAceleracao}", "Inferior Esquerda").Replace("{valorAceleracao}", (InferiorEsquerda.GetValueOrDefault(0) / 10).ToString("F2"));
                        }
                 

                    }



                }


            }
            if (textoDoppler != "")
            {
                textoDoppler = "<p>" + textoDoppler + "</p>";
            }
            return textoDoppler;
        }

        private string MontaDilatacao()
        {
            var textoDilatacao = "";
            if (NaoPossuiDilatacao())
            {
                textoDilatacao += fraseAusenciaDilatacaoSistemaColetor;
            }
            else
            {

                if (DilatacaoPielocalcinalDireita == DilatacaoPielocalcinalEsquerda)
                {
                    if (AdicionarUretralDilatacaoDireita && AdicionarUretralDilatacaoEsquerda)
                    {
                        textoDilatacao += fraseDilatacaoUreteralBilateral.Replace("{classificacaoDilatacao}", DilatacaoPielocalcinalDireita.GetDescription());
                    }
                    else
                    {
                        textoDilatacao += fraseDilatacaoBilateral.Replace("{classificacaoDilatacao}", DilatacaoPielocalcinalDireita.GetDescription());
                        if (AdicionarUretralDilatacaoDireita)
                        {
                            textoDilatacao += fraseAdicionarUreteralLado.Replace("{rimFem}", "direita");
                        }
                        if (AdicionarUretralDilatacaoEsquerda)
                        {
                            textoDilatacao += fraseAdicionarUreteralLado.Replace("{rimFem}", "esquerda");
                        }
                    }
                }
                else if (DilatacaoPielocalcinalDireita != EnumRinsDilatacaoPielocalcinal.Ausente && DilatacaoPielocalcinalEsquerda != EnumRinsDilatacaoPielocalcinal.Ausente)
                {
                    if (AdicionarUretralDilatacaoDireita && AdicionarUretralDilatacaoEsquerda)
                    {
                        textoDilatacao += fraseDilatacaoDiferencaUreteralBilateral;
                    }
                    else
                    {
                        textoDilatacao += fraseDilatacaoDiferencaBilateral;
                    }
                    textoDilatacao = textoDilatacao.Replace("{classificacaoDilatacaoDireita}", DilatacaoPielocalcinalDireita.GetDescription())
                                                   .Replace("{classificacaoDilatacaoEsquerda}", DilatacaoPielocalcinalEsquerda.GetDescription());
                }
                else
                {
                    if (AdicionarUretralDilatacaoDireita || AdicionarUretralDilatacaoEsquerda)
                    {
                        textoDilatacao += fraseDilatacaoUreteralLado;
                    }
                    else
                    {
                        textoDilatacao += fraseDilatacaoLado;
                    }
                }



                switch (DilatacaoPielocalcinalDireita)
                {
                    case EnumRinsDilatacaoPielocalcinal.Ausente:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.Discreta:

                        break;
                    case EnumRinsDilatacaoPielocalcinal.DiscretaModerada:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.Moderada:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.Acentuada:
                        break;
                }
                switch (DilatacaoPielocalcinalEsquerda)
                {
                    case EnumRinsDilatacaoPielocalcinal.Ausente:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.Discreta:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.DiscretaModerada:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.Moderada:
                        break;
                    case EnumRinsDilatacaoPielocalcinal.Acentuada:
                        break;
                }

            }
            return textoDilatacao;
        }

        private class CistoClassificacao
        {
            public decimal? DimensaoCistoUnico { get; set; }
            public string RimCisto { get; set; }
            public string LocalCisto { get; set; }
        }

        private string MontaCistos()
        {
            var textoCistos = "";

            var quantidadeCistos = QuantidadeCistos();

            if (quantidadeCistos == 1 && !PossuiVariosCistosBilaterais)
            {
                CistoClassificacao cistoClassificacao = MontaClassificacaoCisto();

                textoCistos = fraseCistoUnico.Replace("{dimensaoCisto}", (cistoClassificacao.DimensaoCistoUnico.GetValueOrDefault(0) / 10).ToString("F2"))
                                             .Replace("{localCisto}", cistoClassificacao.LocalCisto)
                                             .Replace("{rim}", cistoClassificacao.RimCisto);

            }
            else if (quantidadeCistos > 1 && !PossuiVariosCistosBilaterais)
            {

                string quantidadeString = quantidadeCistos == 2 ? "dois" :
                                          quantidadeCistos == 3 ? "três" :
                                          quantidadeCistos == 4 ? "quatro" : "vários";

                textoCistos = fraseCistosIndividuais.Replace("{quantidadeCistos}", quantidadeString);
                string textoCaraterizacao = MontaCaracterizacaoCisto();

                textoCistos += textoCaraterizacao;
            }

            else if (PossuiVariosCistosBilaterais)
            {

                textoCistos = fraseMultiplosCistos.Replace("{dimensaoCisto}", (DimensaoCistosBilaterais.GetValueOrDefault(0) / 10).ToString("F2"))
                                                  .Replace("{localCisto}", PosicaoCistosBilaterais.GetDescription())
                                                   .Replace("{rim}", RimCistosBilaterais.GetDescription());

            }


            return textoCistos;
        }

        private string MontaCaracterizacaoCisto()
        {
            var textoCaraterizacao = "<br/>";


            var cistoClassificacaoArray = new[]
            {
                    new {
                      PossuiCisto = PossuiCisto1,
                      DimensaoCisto = DimensaoCisto1,
                      LocalCisto = PosicaoCisto1,
                      RimCisto = RimCisto1
                    },
                   new  {
                      PossuiCisto = PossuiCisto2,
                      DimensaoCisto = DimensaoCisto2,
                      LocalCisto = PosicaoCisto2,
                      RimCisto = RimCisto2
                    },
                  new   {
                      PossuiCisto = PossuiCisto3,
                      DimensaoCisto = DimensaoCisto3,
                      LocalCisto = PosicaoCisto3,
                      RimCisto = RimCisto3
                    },
                  new   {
                      PossuiCisto = PossuiCisto4,
                      DimensaoCisto = DimensaoCisto4,
                      LocalCisto = PosicaoCisto4,
                      RimCisto = RimCisto4
                    }
                };

            foreach (var cisto in cistoClassificacaoArray)
            {
                if (cisto.PossuiCisto)
                {
                    textoCaraterizacao += fraseCistoEspecificacao.Replace("{dimensaoCisto}", (cisto.DimensaoCisto.GetValueOrDefault(0) / 10).ToString("F2"))
                                                                 .Replace("{localCisto}", cisto.LocalCisto.GetDescription())
                                                                 .Replace("{rim}", cisto.RimCisto.GetDescription());
                    textoCaraterizacao += "<br/>";
                }
            }

            return textoCaraterizacao;
        }

        private CistoClassificacao MontaClassificacaoCisto()
        {
            CistoClassificacao cistoClassificacao = new CistoClassificacao();

            if (PossuiCisto1)
            {
                cistoClassificacao.DimensaoCistoUnico = DimensaoCisto1;
                cistoClassificacao.RimCisto = RimCisto1.GetDescription();
                cistoClassificacao.LocalCisto = PosicaoCisto1.GetDescription();
            }
            else if (PossuiCisto2)
            {
                cistoClassificacao.DimensaoCistoUnico = DimensaoCisto2;
                cistoClassificacao.RimCisto = RimCisto2.GetDescription();
                cistoClassificacao.LocalCisto = PosicaoCisto2.GetDescription();
            }
            else if (PossuiCisto3)
            {
                cistoClassificacao.DimensaoCistoUnico = DimensaoCisto3;
                cistoClassificacao.RimCisto = RimCisto3.GetDescription();
                cistoClassificacao.LocalCisto = PosicaoCisto3.GetDescription();
            }
            else if (PossuiCisto4)
            {
                cistoClassificacao.DimensaoCistoUnico = DimensaoCisto4;
                cistoClassificacao.RimCisto = RimCisto4.GetDescription();
                cistoClassificacao.LocalCisto = PosicaoCisto4.GetDescription();
            }

            return cistoClassificacao;
        }

        private int QuantidadeCistos()
        {
            bool[] arrCistoChecked = { PossuiCisto1, PossuiCisto2, PossuiCisto3, PossuiCisto4, PossuiVariosCistosBilaterais };
            int countCistoChecked = arrCistoChecked.Count(t => t);
            return countCistoChecked;
        }



        private class CalculoClassificacao
        {
            public decimal? DimensaoCalculoUnico { get; set; }
            public string RimCalculo { get; set; }
            public string LocalCalculo { get; set; }
        }

        private string MontaCalculos()
        {
            var textoCalculos = fraseAusenciaCalculos;

            var quantidadeCalculos = QuantidadeCalculos();

            if (quantidadeCalculos == 1 && !PossuiVariosCalculosBilaterais)
            {
                CalculoClassificacao calculoClassificacao = MontaClassificacaoCalculo();

                textoCalculos = fraseCalculoUnico.Replace("{dimensaoCalculo}", (calculoClassificacao.DimensaoCalculoUnico.GetValueOrDefault(0) / 10).ToString("F2"))
                                             .Replace("{localCalculo}", calculoClassificacao.LocalCalculo)
                                             .Replace("{rim}", calculoClassificacao.RimCalculo);

            }
            else if (quantidadeCalculos > 1 && !PossuiVariosCalculosBilaterais)
            {

                string quantidadeString = quantidadeCalculos == 2 ? "dois" :
                                          quantidadeCalculos == 3 ? "três" :
                                          quantidadeCalculos == 4 ? "quatro" : "vários";

                textoCalculos = fraseCalculosIndividuais.Replace("{quantidadeCalculos}", quantidadeString);
                string textoCaraterizacao = MontaCaracterizacaoCalculo();

                textoCalculos += textoCaraterizacao;
            }

            else if (PossuiVariosCalculosBilaterais)
            {

                textoCalculos = fraseMultiplosCalculos.Replace("{dimensaoCalculo}", (DimensaoCalculosBilaterais.GetValueOrDefault(0) / 10).ToString("F2"))
                                                  .Replace("{localCalculo}", PosicaoCalculosBilaterais.GetDescription())
                                                   .Replace("{rim}", RimCalculosBilaterais.GetDescription());

            }

            if (PossuiMicroCalculosBilaterais)
            {
                textoCalculos += fraseMicrocalculosBilaterais;
            }


            return textoCalculos;
        }

        private string MontaCaracterizacaoCalculo()
        {
            var textoCaraterizacao = "<br/>";


            var calculoClassificacaoArray = new[]
            {
                    new {
                      PossuiCalculo = PossuiCalculo1,
                      DimensaoCalculo = DimensaoCalculo1,
                      LocalCalculo = PosicaoCalculo1,
                      RimCalculo = RimCalculo1
                    },
                   new  {
                      PossuiCalculo = PossuiCalculo2,
                      DimensaoCalculo = DimensaoCalculo2,
                      LocalCalculo = PosicaoCalculo2,
                      RimCalculo = RimCalculo2
                    },
                  new   {
                      PossuiCalculo = PossuiCalculo3,
                      DimensaoCalculo = DimensaoCalculo3,
                      LocalCalculo = PosicaoCalculo3,
                      RimCalculo = RimCalculo3
                    },
                  new   {
                      PossuiCalculo = PossuiCalculo4,
                      DimensaoCalculo = DimensaoCalculo4,
                      LocalCalculo = PosicaoCalculo4,
                      RimCalculo = RimCalculo4
                    }
                };

            foreach (var calculo in calculoClassificacaoArray)
            {
                if (calculo.PossuiCalculo)
                {
                    textoCaraterizacao += fraseCalculoEspecificacao.Replace("{dimensaoCalculo}", (calculo.DimensaoCalculo.GetValueOrDefault(0) / 10).ToString("F2"))
                                                                 .Replace("{localCalculo}", calculo.LocalCalculo.GetDescription())
                                                                 .Replace("{rim}", calculo.RimCalculo.GetDescription());
                    textoCaraterizacao += "<br/>";
                }
            }

            return textoCaraterizacao;
        }

        private CalculoClassificacao MontaClassificacaoCalculo()
        {
            CalculoClassificacao calculoClassificacao = new CalculoClassificacao();

            if (PossuiCalculo1)
            {
                calculoClassificacao.DimensaoCalculoUnico = DimensaoCalculo1;
                calculoClassificacao.RimCalculo = RimCalculo1.GetDescription();
                calculoClassificacao.LocalCalculo = PosicaoCalculo1.GetDescription();
            }
            else if (PossuiCalculo2)
            {
                calculoClassificacao.DimensaoCalculoUnico = DimensaoCalculo2;
                calculoClassificacao.RimCalculo = RimCalculo2.GetDescription();
                calculoClassificacao.LocalCalculo = PosicaoCalculo2.GetDescription();
            }
            else if (PossuiCalculo3)
            {
                calculoClassificacao.DimensaoCalculoUnico = DimensaoCalculo3;
                calculoClassificacao.RimCalculo = RimCalculo3.GetDescription();
                calculoClassificacao.LocalCalculo = PosicaoCalculo3.GetDescription();
            }
            else if (PossuiCalculo4)
            {
                calculoClassificacao.DimensaoCalculoUnico = DimensaoCalculo4;
                calculoClassificacao.RimCalculo = RimCalculo4.GetDescription();
                calculoClassificacao.LocalCalculo = PosicaoCalculo4.GetDescription();
            }

            return calculoClassificacao;
        }

        private int QuantidadeCalculos()
        {
            bool[] arrCalculoChecked = { PossuiCalculo1, PossuiCalculo2, PossuiCalculo3, PossuiCalculo4, PossuiVariosCalculosBilaterais };
            int countCalculoChecked = arrCalculoChecked.Count(t => t);
            return countCalculoChecked;
        }






        private string MontaNodulos()
        {
            var textoNodulo = "";
            if (PossuiNoduloSolido)
            {


                textoNodulo = fraseNodulo.Replace("{classificacaoNodulo}", ClassificacaoNoduloSolido.GetDescription())
                                         .Replace("{contornoNodulo}", ContornoNoduloSolido.GetDescription())
                                         .Replace("{dimensaoANodulo}", (DimensaoANoduloSolido.GetValueOrDefault(0) / 10).ToString("F2"))
                                         .Replace("{dimensaoBNodulo}", (DimensaoBNoduloSolido.GetValueOrDefault(0) / 10).ToString("F2"))
                                         .Replace("{localNodulo}", PosicaoNoduloSolido.GetDescription())
                                         .Replace("{rim}", RimNoduloSolido.GetDescription());


            }
            return textoNodulo;
        }

        private string MontaAspectoInicialRim()
        {
            var fraseAspectoInicial = "";
            fraseAspectoInicial = fraseRinsNormal;

            if (AusenciaRimDireito)
            {
                fraseAspectoInicial = fraseAusenciaRimDireito;
                if (PossuiNefropatiaParenquimatosaCronica)
                {
                    fraseAspectoInicial += MontaNefropatiaCronica();
                }
                else
                {
                    fraseAspectoInicial += fraseRimEsquerdoNormal;
                }
            }

            if (AusenciaRimEsquerdo)
            {
                fraseAspectoInicial = fraseAusenciaRimEsquerdo;
                if (PossuiNefropatiaParenquimatosaCronica)
                {
                    fraseAspectoInicial += MontaNefropatiaCronica();
                }
                else
                {
                    fraseAspectoInicial += fraseRimDireitoNormal;
                }
            }

            return fraseAspectoInicial;
        }

        private string MontaNefropatiaCronica()
        {
            var textNefropatia = "";

            switch (PosicaoNefropatiaParenquimatosaCronica)
            {
                case EnumRinsClassificacaoNefropatia.Bilateral:
                    textNefropatia = fraseRinsNefropatiaBilateral;
                    break;
                case EnumRinsClassificacaoNefropatia.RimDireito:
                    if (AusenciaRimEsquerdo)
                    {
                        textNefropatia += fraseRinsNefropatiaAusenciaRim;
                    }
                    else
                    {
                        textNefropatia = fraseRinsNefropatiaLado;
                        textNefropatia = textNefropatia.Replace("{rimOposto}", EnumRinsEsquerdoDireito.RimEsquerdo.GetDescription());
                    }
                    break;
                case EnumRinsClassificacaoNefropatia.RimEsquerdo:
                    if (AusenciaRimDireito)
                    {
                        textNefropatia += fraseRinsNefropatiaAusenciaRim;
                    }
                    else
                    {
                        textNefropatia = fraseRinsNefropatiaLado;
                        textNefropatia = textNefropatia.Replace("{rimOposto}", EnumRinsEsquerdoDireito.RimDireito.GetDescription());
                    }
                    break;
            }

            textNefropatia = textNefropatia.Replace("{rim}", PosicaoNefropatiaParenquimatosaCronica.GetDescription());

            return textNefropatia;
        }

        private bool NaoPossuiDilatacao()
        {
            return DilatacaoPielocalcinalDireita == EnumRinsDilatacaoPielocalcinal.Ausente && DilatacaoPielocalcinalEsquerda == EnumRinsDilatacaoPielocalcinal.Ausente;
        }



        public string MontaConclusao()
        {
            var fraseConclusao = "";

            if (PossuiNefropatiaParenquimatosaCronica)
            {
                if (PosicaoNefropatiaParenquimatosaCronica == EnumRinsClassificacaoNefropatia.Bilateral)
                    fraseConclusao = fraseNefropatiaCronica;
                else
                {
                    var direitaEsquerda = PosicaoNefropatiaParenquimatosaCronica == EnumRinsClassificacaoNefropatia.RimDireito ? "direita" : "esquerda";
                    fraseConclusao = fraseNefropatiaCronicaLado.Replace("{fraseNefropatiaCronicaLado}", direitaEsquerda);

                }
            }

            return "";
        }
    }


}