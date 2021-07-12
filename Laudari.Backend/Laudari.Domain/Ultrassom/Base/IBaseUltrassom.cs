using Laudari.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laudari.Domain.Ultrassom.Base
{
    public interface IBaseUltrassom
    {

        DescricaoConclusao TextDescConc { get; set; }
        DescricaoConclusao MontaDescricao();
        
    }
}
