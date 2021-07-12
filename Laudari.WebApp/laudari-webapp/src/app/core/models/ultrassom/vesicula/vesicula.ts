import { VesiculaClassificacao, ClassificadorQuantidade } from "./vesicula.enum";


export interface Vesicula {
    Classificacao: VesiculaClassificacao;

    QuantidadeCalculo: ClassificadorQuantidade;
    DimensaoCalculo: number;
    Colecistite: boolean;
    DimensaoCalculoA: number;
    DimensaoCalculoB: number;

    QuantidadePolipo: ClassificadorQuantidade;
    DimensaoPolipo: number;
    DimensaoPolipoMaior: number;

    Colesterolose: boolean;

}
