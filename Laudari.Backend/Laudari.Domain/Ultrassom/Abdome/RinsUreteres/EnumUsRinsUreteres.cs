using System.ComponentModel;

namespace Laudari.Domain.Ultrassom.Abdome.RinsUreteres
{
    public enum EnumRinsClassificacaoNefropatia
    {
        Bilateral = 1,
        [Description("direito")]
        RimDireito = 2,
        [Description("esquerdo")]
        RimEsquerdo = 3
    }


    public enum EnumRinsClassificacaoNoduloSolido
    {
        [Description("hipoecogênico")]
        Hipoecogenico = 1,
        [Description("hiperecogênico")]
        Hiperecogenico = 2,
        [Description("isoecogênico")]
        Isoecogenico = 3
    }

    public enum EnumRinsContornoNoduloSolido
    {
        [Description("contornos regulares")]
        Regulares = 1,
        [Description("contornos irregulares")]
        Irregulares = 2
    }

    public enum EnumRinsPosicao
    {
        [Description("terço superior")]
        TercoSuperior = 1,
        [Description("terço medio")]
        TercoMedio = 2,
        [Description("terço inferior")]
        TercoInferior = 3,
        [Description("polo superior")]
        PoloSuperior = 4,
        [Description("polo inferior")]
        PoloInferior = 5
    }


    public enum EnumRinsEsquerdoDireito
    {
        [Description("direito")]
        RimDireito = 1,
        [Description("esquerdo")]
        RimEsquerdo = 2
    }

    public enum EnumRinsAlturaPosicao
    {
        Superior = 1,
        Medio = 2,
        Inferior = 3
    }

    public enum EnumRinsDilatacaoPielocalcinal
    {

        Ausente = 1,
        [Description("discreta")]
        Discreta = 2,
        [Description("discreta/moderada")]
        DiscretaModerada = 3,
        [Description("moderada")]
        Moderada = 4,
        [Description("acentuada")]
        Acentuada = 5
    }

    public enum EnumRinsPosicaoCalculoUretral
    {
        [Description("na junção pieloureteral")]
        JuncaoPieloureteral = 1,
        [Description("no terço proximal do ureter")]
        TercoProximalUreter = 2,
        [Description("no terço médio do ureter")]
        TercoMedioUreter = 3,
        [Description("no terço distal do ureter")]
        TercoDistalUreter = 4,
        [Description("no meato ureteral")]
        MeatoUreteral = 5
    }

    public enum EnumRinsEsquerdoDireitoFem
    {
        [Description("direita")]
        Direita = 1,
        [Description("esquerda")]
        Esquerda = 2
    }
}