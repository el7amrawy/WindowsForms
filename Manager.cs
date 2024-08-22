using System.Text;

namespace Day4_Task1
{
    enum MyTypes
    {
        Person,
        Employee,
        Manager
    }
    internal class Manager:Employee
    {
        public Manager()
        {
            
        }
        public Manager(Employee emp)
        {
            FirstName = emp.FirstName;
            LastName = emp.LastName;
            Password = emp.Password;
            BirthDay = emp.BirthDay;
            Gender = emp.Gender;
            Mstatus=emp.Mstatus;
            Habits = emp.Habits;
            EnglishLang = emp.EnglishLang;
            ArabicLang = emp.ArabicLang;
            Salary=emp.Salary;
            Job = emp.Job;
            Type=MyTypes.Manager.ToString();
            Department = emp.Department;
        }
        internal override string PrintInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.PrintInfo());
            sb.AppendLine("Department : " + Department);
            return sb.ToString();
        }
    }
}
