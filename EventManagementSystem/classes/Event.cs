using EventManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementSystem.classes
{
    internal class Event
    {
        private string eventId;
        private string name;
        private string venue;
        private string time;
        private string date;
        private int maxParticipants;
        private int currentParticipants;
        private string organizer;
        private int tPrice;
        public Event(string eventId, string name,string venue, string time, string date, int maxParticipants, int currentParticipants, string organizer,int ticketPrice) 
        {
            this.eventId = eventId;
            this.name = name;
            this.venue = venue;
            this.time = time;
            this.date = date;
            this.maxParticipants = maxParticipants;
            this.currentParticipants = currentParticipants;
            this.organizer = organizer;
            this.tPrice = ticketPrice;
        }

        public string getEventId()
        {
            return eventId;
        }
        public string getName()
        {
            return name;
        }
        public string getVenue()
        {
            return venue;
        }
        public string getTime()
        {
            return time.Substring(0, 5);
        }
        public string getDate()
        {
            string Date = date.Substring(0, 10);
            int indexOfDash = Date.IndexOf("/");
            int lastIndexOfDash = Date.LastIndexOf("/");
            string month = Date.Substring(0, indexOfDash);
            string day = Date.Substring(indexOfDash+1,lastIndexOfDash-2);
            if (day.Contains("/")) 
            {
                day = day.Replace("/","");
                
            }

            int year =Convert.ToInt32(Date.Substring(lastIndexOfDash+1));
            

            string newDate = $"{year}-{month}-{day}";
            
            

            return newDate ;
        }
        public int getMaxParticipants()
        {
            return maxParticipants;
        }
        public int getCurrentParticipants()
        {
            return currentParticipants;
        }
        public string getOrganizer()
        {
            return organizer;
        }

        public int getTicketPrice()
        {
            return tPrice;
        }
    }
}


