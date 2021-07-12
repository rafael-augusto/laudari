import { RinsClassificacaoNefropatia, RinsClassificacaoNoduloSolido, 
    RinsContornoNoduloSolido, RinsPosicao, RinsEsquerdoDireito, 
    RinsAlturaPosicao, RinsDilatacaoPielocalcinal, RinsPosicaoCalculoUretral } from "./rins-ureteres.enum";
import { Aorta } from "../aorta/aorta";

export interface RinsUreteres {

    UsAorta: Aorta,
    AspectoNormal : boolean,
    AusenciaRimDireito: boolean,
    AusenciaRimEsquerdo: boolean,
    IncluirMedidaRins:boolean,
    RimDireitoL: number,
    IncluirRimDireitoT: boolean,
    RimDireitoT: number,
    IncluirRimDireitoAP: boolean,
    RimDireitoAP: number, 
    IncluirRimDireitoParenquima: boolean,
    RimDireitoParenquima: number,
    RimEsquerdoL: number,
    IncluirRimEsquerdoT: boolean,
    RimEsquerdoT: number,
    IncluirRimEsquerdoAP: boolean,
    RimEsquerdoAP: number, 
    IncluirRimEsquerdoParenquima: boolean,
    RimEsquerdoParenquima: number,
    IncluirDopplerArteriasRenais: boolean,
    VPSDireita: number,
    VPSEsquerda: number,
    CitarRelacaoVPSArteriasRenais: boolean,
    ArteriaRenalDireitaInacessivel: boolean,
    ArteriaRenalEsquerdaInacessivel: boolean,

    CitarAASegmentaresDireita: boolean,
    IncluirSuperiorDireita: boolean,
    SuperiorDireita: number,
    IncluirMediaDireita: boolean,
    MediaDireita: number,
    IncluirInferiorDireita: boolean,
    InferiorDireita: number,

    CitarAASegmentaresEsquerda: boolean,
    IncluirSuperiorEsquerda: boolean,
    SuperiorEsquerda: number,
    IncluirMediaEsquerda: boolean,
    MediaEsquerda: number,
    IncluirInferiorEsquerda: boolean,
    InferiorEsquerda: number,

    PossuiNefropatiaParenquimatosaCronica: boolean,
    PosicaoNefropatiaParenquimatosaCronica: RinsClassificacaoNefropatia,
    
     PossuiNoduloSolido: boolean,
     ClassificacaoNoduloSolido: RinsClassificacaoNoduloSolido,
     ContornoNoduloSolido: RinsContornoNoduloSolido,
     DimensaoANoduloSolido: number,
     DimensaoBNoduloSolido: number,
     PosicaoNoduloSolido: RinsPosicao,
     RimNoduloSolido: RinsEsquerdoDireito,
     
     PossuiCisto1: boolean,
     DimensaoCisto1: number,
     PosicaoCisto1: RinsPosicao,
     RimCisto1: RinsEsquerdoDireito,

     PossuiCisto2: boolean,
     DimensaoCisto2: number,
     PosicaoCisto2: RinsPosicao,
     RimCisto2: RinsEsquerdoDireito,

     PossuiCisto3: boolean,
     DimensaoCisto3: number,
     PosicaoCisto3: RinsPosicao,
     RimCisto3: RinsEsquerdoDireito,

     PossuiCisto4: boolean,
     DimensaoCisto4: number,
     PosicaoCisto4: RinsPosicao,
     RimCisto4: RinsEsquerdoDireito,

     PossuiVariosCistosBilaterais: boolean,
     DimensaoCistosBilaterais: number,
     PosicaoCistosBilaterais: RinsPosicao,
     RimCistosBilaterais: RinsEsquerdoDireito,


     PossuiCalculo1: boolean,
     DimensaoCalculo1: number,
     PosicaoCalculo1: RinsAlturaPosicao,
     RimCalculo1: RinsEsquerdoDireito,

     PossuiCalculo2: boolean,
     DimensaoCalculo2: number,
     PosicaoCalculo2: RinsAlturaPosicao,
     RimCalculo2: RinsEsquerdoDireito,

     PossuiCalculo3: boolean,
     DimensaoCalculo3: number,
     PosicaoCalculo3: RinsAlturaPosicao,
     RimCalculo3: RinsEsquerdoDireito,

     PossuiCalculo4: boolean,
     DimensaoCalculo4: number,
     PosicaoCalculo4: RinsAlturaPosicao,
     RimCalculo4: RinsEsquerdoDireito,

     PossuiVariosCalculosBilaterais: boolean,
     DimensaoCalculosBilaterais: number,
     PosicaoCalculosBilaterais: RinsAlturaPosicao,
     RimCalculosBilaterais: RinsEsquerdoDireito,

     PossuiMicroCalculosBilaterais: boolean,

     DilatacaoPielocalcinalDireita: RinsDilatacaoPielocalcinal,
     DilatacaoPielocalcinalEsquerda: RinsDilatacaoPielocalcinal,
     
     AdicionarUretralDilatacaoDireita: boolean,
     AdicionarUretralDilatacaoEsquerda: boolean,

     PossuiCalculoUretral: boolean,
     DimensaoCalculoUretral: number,

     PosicaoCalculoUretral: RinsPosicaoCalculoUretral,
     CalculoUretralDireitoEsquerdo: RinsEsquerdoDireito
}
