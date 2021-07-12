using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Abdome.VesiculaBiliar
{

    public enum VesiculaClassificacao
    {
        [Description("normais")]
        Normal = 1,
        [Description("vazia")]
        Vazia = 2,
        [Description("não caracterizada (status pós-cirúrgico)")]
        Ausente = 3,
        
          

    }

    public enum ClassificadorQuantidade
    {
        Nenhum = 0,
        [Description("Único")]
        Unico = 1,
        [Description("Múltiplos")]
        Multiplos = 2,
        Colesterolose = 3

    }

}
