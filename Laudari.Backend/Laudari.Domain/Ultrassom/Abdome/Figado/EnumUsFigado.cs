using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.Figado
{
    public enum FigadoClassificacao
    {
        
        [Description("homogêneo")]
        Homogeneo = 0,
        [Description("esteatose")]
        Esteatose = 1,
        [Description("hepatopatia crônica")]
        HepatopatiaCronica = 2
    }


    public enum DimensoesDescritivo
    {
        [Description("normais")]
        Normais = 0,
        [Description("aumentadas")]
        Aumentadas = 1,
        [Description("aumentadas à custa do Lobo Direito")]
        AumentadasACustaLoboDireito = 2,
        [Description("aumentadas à custa do Lobo Esquerdo")]
        AumentadasACustaLoboEsquerdo = 3,
        [Description("reduzidas")]
        Reduzidas = 4
    }


    public enum GrauEsteatose
    {
        [Description("não especificado")]
        NaoEspecificado = 0,
        [Description(" discreta (grau I)")]
        Discreta = 1,
        [Description(" moderada (grau II)")]
        Moderada = 2,
        [Description(" acentuada (grau III)")]
        Acentuada = 3
    }


    public enum TipoHepatopatiaCronica
    {
        [Description(" incipiente")]
        Incipiente = 0,
        Avancada = 1
    }

    public enum SegmentoFigado
    {
        [Description("segmento I")]
        Segmento1 = 1,
        [Description("segmento II")]
        Segmento2 = 2,
        [Description("segmento III")]
        Segmento3 = 3,
        [Description("segmento IV")]
        Segmento4 = 4,
        [Description("segmento V")]
        Segmento5 = 5,
        [Description("segmento VI")]
        Segmento6 = 6,
        [Description("segmento VII")]
        Segmento7 = 7,
        [Description("segmento VIII")]
        Segmento8 = 8,
    }

    public enum ClassificadorQuantidade
    {
        Nenhum = 0,
        [Description("Único")]
        Unico = 1,
        [Description("Múltiplos")]
        Multiplos = 2
    }



    public enum ClassificacaoNoduloFigado
    {
        [Description("hiperecogênico")]
        Hiperecogenico = 0,
        [Description("hipoecogênico")]
        Hipoecogenico = 1,
        [Description("hiperecogênico")]
        HiperecogenicoHemangioma = 2
    }

    public enum ClassificacaoContorno
    {
        [Description("regulares")]
        Regulares = 0,
        [Description("lobulados")]
        Lobulados = 1,
        [Description("irregulares")]
        Irregulares = 2
    }


    public enum EnfaseMultiplosNodulos
    {
        [Description("dois no total")]
        DoisTotal = 0,
        [Description("os dois maiores")]
        DoisMaiores = 1
    }


    public enum FluxoPortal
    {

        [Description("hepatopetal")]
        Hepatopetal = 0,
        [Description("hepatofugal")]
        Hepatofugal = 1
    }
}
