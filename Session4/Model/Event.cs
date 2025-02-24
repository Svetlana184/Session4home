using static QRCoder.PayloadGenerator;


namespace Session4.Model
{
    public class Event
    {
        public int IdEvent { get; set; }

        public string EventName { get; set; } = null!;

        public string TypeOfEvent { get; set; } = null!;

        public string EventStatus { get; set; } = null!;

        public string EventDescription { get; set; } = null!;

        public DateTime DateOfEvent { get; set; }

        public int EventManagers { get; set; }

        public string TypeOfClass { get; set; } = null!;


        public override string ToString()
        {
            return "BEGIN:VCALENDAR\n" + "VERSION:2.0\n" + "BEGIN:VEVENT\n" + "SUMMARY: " + EventName + 
            "\n" + "DTSTART: " + DateOfEvent + "\n" + "DTEND:" + "" + "DTSTAMP:" + "" +
            "\n" + "UID: " + IdEvent + "\n" + "DESCRIPTION: " + EventDescription + 
            "\n" + "LOCATION: " + "" + "\n" + "ORGANIZER: " + "" + "\n" +
            "STATUS: " + "CONFIRMED" + "\n" + "PRIORITY: " + "0" + "\n" + 
            "END: " + "VEVENT" + "\n" + "END: VCALENDAR";
        }
    }
}
