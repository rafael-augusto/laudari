import { AortaClassificacao, AortaAneurisma, AortaLocalAneurisma } from "./aorta.enum";


export interface Aorta {
    
    Classificacao: AortaClassificacao;
    CitarCalibre: boolean;
    Calibre: number;
    CitarFluxoNormalDoppler: boolean;
    CitarVPS: boolean;
    VPS: number;

    TipoAneurisma : AortaAneurisma;
    LocalAneurisma : AortaLocalAneurisma;
    CalibreAneurisma : number;
    ExtensaoAneurisma : number;
    TromboPariental: boolean;

    
}