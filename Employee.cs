using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task1
{
    enum Gender
    {
        Male,
        Female
    }
    internal class Employee:Person
    {
        #region Fields
        private string _password;
        #endregion

        #region Properties
       
        public string Password { get { return _password; } set { _password = value; } }
        public decimal Salary {  get; set; }
        public string Job {  get; set; }
        public string? Department { get; set; }
        #endregion

        #region Methode(s)
        internal override string PrintInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.PrintInfo());
            sb.AppendLine("Your Password : ********");
            sb.AppendLine("Your Salary : "+Salary);
            sb.AppendLine("Job : "+Job);
            return sb.ToString();
        }
        #endregion

    }
}
