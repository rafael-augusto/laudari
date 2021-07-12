import { PancreasClassificacao } from './pancreas-classificacao.enum';

export interface Pancreas {
    Classificacao: PancreasClassificacao;
    CheckCabeca : boolean;
    CheckCorpo : boolean;
    CheckCauda : boolean;
    TamanhoCabeca: number;
    TamanhoCorpo: number;
    TamanhoCauda: number;
}
