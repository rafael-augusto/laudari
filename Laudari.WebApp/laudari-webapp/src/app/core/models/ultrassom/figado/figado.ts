import { FigadoClassificacao, DimensoesDescritivo, GrauEsteatose, SegmentoFigado,
     ClassificacaoNoduloFigado, ClassificacaoContorno, ClassificadorQuantidade,
      EnfaseMultiplosNodulos, TipoHepatopatiaCronica, FluxoPortal } from "./figado.enum";



export interface Figado {
    Classificacao : FigadoClassificacao;
    DimensaoDescritivo : DimensoesDescritivo;
    GrauEsteatose: GrauEsteatose;
    TipoHepatopatiaCronica : TipoHepatopatiaCronica;

    QuantidadeCistos: ClassificadorQuantidade;
    DimensaoCisto : number;
    SegmentoCisto: SegmentoFigado;

    LoboDireito : boolean;
    LoboEsquerdo : boolean;
    LoboCaudado : boolean;
    DimensaoLoboDireito : number;
    DimensaoLoboEsquerdo : number;
    DimensaoLoboCaudado: number;

    QuantidadeNodulos: ClassificadorQuantidade;
    ClassificacaoNodulo: ClassificacaoNoduloFigado;
    DimensaoANodulo: number;
    DimensaoBNodulo: number;
    ClassificacaoContornoNodulo : ClassificacaoContorno;
    SegmentoANodulo : SegmentoFigado;
    SegmentoBNodulo : SegmentoFigado;
    EnfaseNodulo : EnfaseMultiplosNodulos;


    CalcificacaoGrosseira: boolean;
    DimensaoCalcificacao : number;
    SegmentoCalcificacao : SegmentoFigado;

    SistemaPorta: boolean;
    CalibreVeiaPorta: boolean;
    DimensaoCalibreVeiaPorta: number;
    CalibreVeiaEsplenica: boolean;
    DimensaoCalibreVeiaEsplenica: number;

    IncluirDoppler: boolean;
    FluxoPortal: FluxoPortal;
    VelocidadeVeiaPorta: number;

    CheckVelocidadeVeiaEsplenica: boolean;
    VelocidadeVeiaEsplenica: number;

    ColateraisPequenaCurvaturaGastrica: boolean;
    ColateraisHiloEsplenico: boolean;

    RecanalizacaoVeiaParaumbilical: boolean;
}
