import { TipoDiverticulite } from "./alcas-intestinais.enum";

export interface AlcasIntestinais {
    
    Apendicite : Boolean;
    Calibre: number;
    ApendiceColecao: boolean;
    Diverticulite: boolean;
    TipoDiverticulite : TipoDiverticulite;
    ColecaoDiversiculite: boolean;
}