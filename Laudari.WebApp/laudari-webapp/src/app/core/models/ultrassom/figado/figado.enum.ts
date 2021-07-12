export enum FigadoClassificacao {
    Homogeneo = 0,
    Esteatose = 1,
    HepatopatiaCronica = 2
}


export enum DimensoesDescritivo {
    Normais = 1,
    Aumentadas = 2,
    AumentadasACustaLoboDireito = 3,
    AumentadasACustaLoboEsquerdo = 4,
    Reduzidas = 5
}


export enum GrauEsteatose {
    NaoEspecificado = 0,
    Discreta = 1,
    Moderada = 2,
    Acentuada = 3
}


export enum TipoHepatopatiaCronica {
    Incipiente = 0,
    Avancada = 1
}

export enum SegmentoFigado {
    Segmento1 = 1,
    Segmento2 = 2,
    Segmento3 = 3,
    Segmento4 = 4,
    Segmento5 = 5,
    Segmento6 = 6,
    Segmento7 = 7,
    Segmento8 = 8,
}

export enum ClassificadorQuantidade {
    Unico = 0,
    Multiplos = 1
}



export enum ClassificacaoNoduloFigado {
    Hiperecogenico = 0,
    Hipoecogenico = 1,
    HiperecogenicoHemangioma = 2
}

export enum ClassificacaoContorno {
    Regulares = 0,
    Lobulados = 1,
    Irregulares = 2
}


export enum EnfaseMultiplosNodulos {
    DoisTotal = 0,
    DoisMaiores = 1
}

export enum FluxoPortal {
    Hepatopetal = 0,
    Hepatofugal = 1
}