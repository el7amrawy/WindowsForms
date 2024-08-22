using System.Text;

namespace Day4_Task1
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => FirstName + " " + LastName; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Mstatus { get; set; }
        public string Habits { get; set; }
        public byte EnglishLang { get; set; }
        public byte ArabicLang { get; set; }
        public string Type { get; set; }
        #region Methode(s)
        public int Age() => DateTime.Now.Year - BirthDay.Year;
        internal virtual string PrintInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Type : " + Type);
            sb.AppendLine("Your Id : " + Id);
            sb.AppendLine("Your Full Name : " + FullName);
            sb.AppendLine("Your Gender : " + Gender);
            sb.AppendLine("Your Status : " + Mstatus);
            sb.AppendLine("Your Date of Birth : " + BirthDay);
            sb.AppendLine("Your Age : " + Age());
            sb.AppendLine("Your Skills  : " + Habits);
            sb.AppendLine("Your Arabic Skills  : " + ArabicLang);
            sb.AppendLine("Your English Skills  : " + EnglishLang);
            return sb.ToString();
        }
        #endregion
    }
}
