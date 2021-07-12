import { TipoDiverticulite } from "./intestino.enum";

export interface Intestino {
    
    Apendicite : Boolean;
    Calibre: number;
    ApendiceColecao: boolean;
    Diverticulite: boolean;
    TipoDiverticulite : TipoDiverticulite;
    ColecaoDiversiculite: boolean;
}