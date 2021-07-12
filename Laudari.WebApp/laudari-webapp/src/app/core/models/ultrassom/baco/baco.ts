import { BacoClassificacao, BacoEcoTextura} from "./baco.enum";


export interface Baco {
    Classificacao : BacoClassificacao;
    Ecotextura: BacoEcoTextura;
    Dimensao: boolean;
    DimensaoA: number;
    DimensaoB: number;
    CitarIndice: boolean;
    BacoAcessorio: boolean;
    DimensaoAcessorioA: number;
    DimensaoAcessorioB: number;
    Calcificacao: boolean;
    DimensaoCalcificacao: number;
}