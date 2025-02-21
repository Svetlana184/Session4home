namespace Session4.Model
{
    public class Employee
    {
        public int IdEmployee { get; set; }

        public string Surname { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string? SecondName { get; set; }

        public string Position { get; set; } = null!;

        public string PhoneWork { get; set; } = null!;

        public string? Phone { get; set; }

        public string Cabinet { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Department { get; set; } = null!;

        public int? IdHelper { get; set; }

        public string? Other { get; set; }

        public DateOnly? BirthDay { get; set; }

        public int? IdBoss { get; set; }

        public DateTime? IsFired { get; set; }
        public string Company { get; set; } = null!;

        public override string ToString()
        {
            return "BEGIN: VCARD\n" + "N: " + Surname + "\n" + "FN: " + FirstName + "\n" + "ORG:ГК Дороги России" +
            "\n" + "TITLE: " + Position + "\n" + "TEL;WORK;VOICE: " + PhoneWork + "\n" + "TELL;CELL: " + Phone + "\n" +
            "EMAIL;WORK;INTERNET: " + Email + "\n" + "END: VCARD";
        }
    }
}
