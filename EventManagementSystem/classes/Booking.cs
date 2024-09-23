using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.classes
{
    internal class Booking
    {
        private string bookingId;
        private Event bookingEvent;
        private person participant;
        public Booking(string bookingId, Event bookingEvent, person participant)
        {
            this.bookingId = bookingId;
            this.bookingEvent = bookingEvent;
            this.participant = participant;
        }

        public string getBookingId()
        {
            return bookingId;
        }

        public Event getBookingEvent()
        {
            return bookingEvent;
        }
        public person getParticipant() 
        { 
            return participant;
        
        }
    }
}
