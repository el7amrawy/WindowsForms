namespace Day4_Task1
{
    internal class EFOperators
    {
        private readonly Models.AppContext _context = new Models.AppContext();

        internal List<Employee> GetEmployees() => _context.Employees.ToList();

        internal void AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }
    }
}
