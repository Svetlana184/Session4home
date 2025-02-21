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

        public Employee EventManagers { get; set; } = null!;

        public string TypeOfClass { get; set; } = null!;
    }
}
