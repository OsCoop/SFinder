using SFinder.Domain.Core.Shared;
using System;
using System.Collections.Generic;

namespace SFinder.Domain.Core.Entities
{
    public class PerfilAtendimento : Entity
    {
        public int RaioAtendimento { get; set; }
        public List<DayOfWeek> DiasAtendimento { get; set; }
        public List<eFormaPagamento> FormasPagto { get; set; }
        public eFormaCobranca FormaCobranca { get; set; }

        public PerfilAtendimento(int RaioAtendimento, List<DayOfWeek> DiasAtendimento, List<eFormaPagamento> FormasPagto, eFormaCobranca FormaCobranca)
        {
            // TODO: PerfilAtendimento(RaioAtendimento, DiasAtendimento, FormasPagto, FormaCobranca)
        }
    }
}
