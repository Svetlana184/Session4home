namespace Session4.Model
{
    public class WorkingCalendar
    {
        public int Id { get; set; }
        public DateOnly ExceptionDate { get; set; }
        public bool IsWorkingDay { get; set; }
    }
}
