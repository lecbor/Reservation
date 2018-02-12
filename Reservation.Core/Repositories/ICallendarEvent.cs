using Reservation.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Core.Repositories
{
    public interface ICallendarEvent : IRepository
    {
        Task<CallendarEvent> GetAsync(Guid Id);
        Task<IEnumerable<CallendarEvent>> GetAllAsync();
        Task CreateAsync(CallendarEvent callendarEvent);
        Task UpdateAsync(CallendarEvent callendarEvent);
        Task DeleteAsync(CallendarEvent callendarEvent);
    }
}
