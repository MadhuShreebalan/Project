using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
namespace Online_Cab_Booking.CabBookingModel
{
    class TrackingTime
    {
        public BookingModel BookingModel { get; set; }

        public Timer ScheduledTimer { get; set; }
    }
}
