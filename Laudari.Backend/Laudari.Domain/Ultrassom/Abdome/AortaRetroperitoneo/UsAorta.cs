using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using Laudari.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.AortaRetroperitoneo
{
    public class UsAorta : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }

        public AortaClassificacao Classificacao { get; set; }
        public bool CitarCalibre { get; set; }
        public decimal? Calibre { get; set; }
        public bool CitarFluxoNormalDoppler { get; set; }
        public bool CitarVPS { get; set; }
        public decimal VPS { get; set; }

        public AortaAneurisma TipoAneurisma { get; set; }
        public AortaLocalAneurisma LocalAneurisma { get; set; }
        public decimal? CalibreAneurisma { get; set; }
        public decimal? ExtensaoAneurisma { get; set; }
        public bool TromboPariental { get; set; }


        public UsAorta()
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
            var fraseAortaAneurisma = " Aorta com paredes irregulares, apresentando dilatação aneurismática {tipoAneurisma} {localAneurisma} com calibre máximo de {calibreAneurisma} cm e extensão de {extensaoAneurisma} cm{tromboAneurisma}";
            var fraseAortaAteromatosa = " Aorta com paredes hiperecogênicas e discretamente irregulares, conservando calibre normal.";
            var fraseAortaAteromatosaEctasiada = " Aorta com paredes hiperecogênicas e irregulares, com calibre transverso máximo de {calibre} cm nos segmentos acessíveis.";
            var fraseAortaCalibreMaximo = " O diâmetro máximo da aorta é de {calibre} cm.";
            var fraseAortaDopplerNormal = " A avaliação da aorta com Doppler demonstra fluxo de padrão trifásico normal e velocidades preservadas.";
            var fraseAortaDopplerNormalVelocidadeSistolica = " A avaliação da aorta com Doppler demonstra fluxo de padrão trifásico normal e velocidade preservada(VPS = {VPS} cm / s).";
            var fraseAortaVCINormais = " Aorta e veia cava inferior com calibre e trajeto preservados.";
            var fraseAortaInacessivel = " Aorta inacessível por interposição gasosa de alças intestinais.";

            #endregion

            #region
            var fraseConclusaoAteromatosa = "Ateromatose aórtica.";
            var fraseConclusaoAteromatosaEctasiada = "Aorta ateromatosa, com calibre aumentado.";
            var fraseConclusaoAneurisma = "Aneurisma aórtico.";

            #endregion

            #region classificacao

            switch (Classificacao)
            {
                case AortaClassificacao.Normal:
                    if (CitarCalibre)
                        fraseAortaVCINormais = fraseAortaVCINormais + fraseAortaCalibreMaximo;
                    textoBaseOrigem += fraseAortaVCINormais;
                    break;
                case AortaClassificacao.Ateromatosa:
                    if (CitarCalibre)
                        fraseAortaAteromatosa = fraseAortaAteromatosa + fraseAortaCalibreMaximo;
                    textoBaseOrigem += fraseAortaAteromatosa;
                    textoBaseConclusao += fraseConclusaoAteromatosa;
                    break;
                case AortaClassificacao.AteromatorsaEctasiada:
                    textoBaseOrigem += fraseAortaAteromatosaEctasiada;
                    textoBaseConclusao += fraseConclusaoAteromatosaEctasiada;
                    break;
                case AortaClassificacao.Aneurisma:
                    var textoAneurisma = fraseAortaAneurisma.Replace("{tipoAneurisma}", TipoAneurisma.GetDescription()).Replace("{localAneurisma}", LocalAneurisma.GetDescription());
                    textoAneurisma = textoAneurisma.Replace("{calibreAneurisma}", (CalibreAneurisma.GetValueOrDefault(0) / 10).ToString("F2")).Replace("{extensaoAneurisma}", (ExtensaoAneurisma.GetValueOrDefault(0) / 10).ToString("F2"));
                    if (TromboPariental)
                        textoAneurisma += textoAneurisma.Replace("{tromboAneurisma}", ", com trombo parietal.");
                    else
                        textoAneurisma += textoAneurisma.Replace("{tromboAneurisma}", ".");
                    textoBaseConclusao += fraseConclusaoAneurisma;
                    break;
                case AortaClassificacao.Inacessivel:
                    textoBaseOrigem += fraseAortaInacessivel;
                    break;


            }
            textoBaseOrigem = textoBaseOrigem.Replace("{calibre}", (Calibre.GetValueOrDefault(0) / 10).ToString("F2"));
            #endregion

            #region Doppler
            if (CitarFluxoNormalDoppler && Classificacao != AortaClassificacao.Inacessivel)
            {
                textoBaseOrigem += fraseAortaDopplerNormal;
                if (CitarVPS)
                    textoBaseOrigem += fraseAortaDopplerNormalVelocidadeSistolica.Replace("{VPS}", VPS.ToString("F2"));
            }
            #endregion

            TextDescConc.TextFormatBase = textoBaseOrigem;
            TextDescConc.TextFormatConclusao = textoBaseConclusao;
            return TextDescConc;

        }
    }
}
