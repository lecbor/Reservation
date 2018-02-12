using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Core.Domain
{
    public class CallendarEvent
    {
        public Guid Id { get; protected set; }
        public string Status { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public string Summary { get; protected set; }
        public string Descryption { get; protected set; }
        public string Location { get; protected set; }
        public DateTime StartAt { get; protected set; }
        public DateTime EndAt { get; protected set; }
        public bool EndTimeUnspecified { get; protected set; }
        public string AttendeeEmail { get; protected set; }
        public string AttendeeName { get; protected set; }
        public string AttendeePhone { get; protected set; }

        protected CallendarEvent()
        {
        }

        public CallendarEvent(Guid id, string status, DateTime createdAt, DateTime updatedAt,
                    string summary, string descryption, string location,
                    DateTime startat, DateTime endat, bool endtimeunspecified,
                    string attendeeEmail, string attendeeName, string attendeePhone)
        {
            Id = id;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Summary = summary;
            Descryption = descryption;
            Location = location;
            StartAt = startat;
            EndAt = endat;
            EndTimeUnspecified = endtimeunspecified;
            AttendeeEmail = attendeeEmail;
            AttendeeName = attendeeName;
            AttendeePhone = attendeePhone;
        }
    }
}

