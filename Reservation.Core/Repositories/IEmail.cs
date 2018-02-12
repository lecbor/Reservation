using Reservation.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Core.Repositories
{
    public interface IEmail : IRepository
    {
        Task SendAsync(Email email);
    }
}
