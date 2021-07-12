using Laudari.Domain.Shared;
using Laudari.Domain.Ultrassom.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laudari.Domain.Helpers;

namespace Laudari.Domain.Ultrassom.Abdome.ViasBiliares
{
    public class UsViasBiliares : IBaseUltrassom
    {

        public DescricaoConclusao TextDescConc { get; set; }
        public List<KeyText> ComposicaoChaveTexto { get; set; }

        public UsViasBiliares()
        {
            TextDescConc = new DescricaoConclusao();
            TextDescConc.TextFormatBase = "";
            TextDescConc.TextFormatConclusao = "";
        }

        public ViasBiliaresColedoco Coledoco { get; set; }
        public bool Dilatacao { get; set; }
        public bool CitarCalibre { get; set; }
        public decimal Calibre { get; set; }
        public bool CitarCalculo { get; set; }
        public decimal DimensaoCalculo { get; set; }



        public DescricaoConclusao MontaDescricao()
        {
            var textoBaseOrigem = TextDescConc.TextFormatBase;
            //var textoBaseConclusao = TextDescConc.TextFormatConclusao;

            #region Frases
            var fraseViasBiliaresNormais = "Não há dilatação das vias biliares intra ou extra-hepáticas.";
            var fraseDilatacaoViasBiliares = "Observa-se dilatação de vias biliares intra-hepáticas.";
            var fraseColedocoNormal = " Colédoco com calibre normal.";
            var fraseColedocoEctasiado = " Colédoco ectasiado, com calibre de {calibreColedoco} cm.";
            var fraseCitarCalibreColedoco = " Colédoco com calibre de {calibreColedoco} cm.";
            var fraseAusenciaCalculo = " Não é possível caracterizar fatores obstrutivos ou conteúdo anômalo em seu lúmen.";
            var fraseCalculo = " Em seu lúmen observa-se imagem calculosa medindo {dimensaoCalculo} cm.";
            #endregion



            if (Dilatacao)
                textoBaseOrigem += fraseDilatacaoViasBiliares;

            switch (Coledoco)
            {
                case ViasBiliaresColedoco.Normal:
                    if (Dilatacao && !CitarCalibre)
                        textoBaseOrigem += fraseColedocoNormal;
                    else if (!Dilatacao)
                        textoBaseOrigem += fraseViasBiliaresNormais;
                    break;
                case ViasBiliaresColedoco.Ectasiado:
                    textoBaseOrigem += fraseColedocoEctasiado;
                    break;
            }

            if (Coledoco == ViasBiliaresColedoco.Normal && CitarCalibre)
                textoBaseOrigem += fraseCitarCalibreColedoco;

            textoBaseOrigem = textoBaseOrigem.Replace("{calibreColedoco}", (Calibre / 10).ToString("F2"));

            if (CitarCalculo)
            {
                if (Coledoco == ViasBiliaresColedoco.Ectasiado)
                {
                    textoBaseOrigem += fraseCalculo;
                    textoBaseOrigem = textoBaseOrigem.Replace("{dimensaoCalculo}", (DimensaoCalculo / 10).ToString("F2"));
                }
            }
            else
            {
                if (Coledoco == ViasBiliaresColedoco.Ectasiado)
                    textoBaseOrigem += fraseAusenciaCalculo;
            }

            TextDescConc.TextFormatBase = textoBaseOrigem;

            return TextDescConc;

        }
    }

}
