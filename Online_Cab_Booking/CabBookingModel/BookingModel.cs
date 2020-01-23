using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cab_Booking.CabBookingModel
{
    class BookingModel
    {
        public string RequestId { get; set; }

        public string UserName { get; set; }

        public string CabId { get; set; }

        public string CabName { get; set; }

        public DateTime BookingTime { get; set; }

        public DateTime BookingTimeScheduled { get; set; }
    }
}
