using System.Text;

namespace Day4_Task1
{
    public partial class Form1 : Form
    {
        internal bool ConnectionType { get; set; }
        private List<Employee> _employeesList;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _employeesList = ConnectionType ? ADO.GetEmployees() : new EFOperators().GetEmployees();
            labelNoOfEmps.Text = _employeesList.Count + " /";
            labelNoOfEmps.Refresh();
            labelConnection.Text=ConnectionType?"Connection Type: ADO": "Connection Type: Entity Framework";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TextValidator(combType, txtFirstName, txtLastName, txtPassword, txtJob, combStatus);
                NUDSalaryValidator(nudSalary);
                CheckBoxValidator(grpHabits);
                RadioBtnValidator(grpGender);
                if (combType.Text == MyTypes.Manager.ToString())
                {
                    TextValidator(txtDepartment);
                    Manager manager = new Manager()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Password = txtPassword.Text,
                        Job = txtJob.Text,
                        BirthDay = dtpDOB.Value,
                        Gender = rdBtnFemale.Checked ? Gender.Female.ToString() : Gender.Male.ToString(),
                        Mstatus = combStatus.Text,
                        Habits = Habits(grpHabits),
                        Salary = nudSalary.Value,
                        ArabicLang = (byte)nudAr.Value,
                        EnglishLang = (byte)nudEn.Value,
                        Department = txtDepartment.Text,
                        Type=MyTypes.Manager.ToString(),
                    };
                    if (ConnectionType)
                    {
                        ADO.AddEmployee(manager);
                        _employeesList = ADO.GetEmployees();
                    }
                    else
                    {
                        var efo = new EFOperators();
                        efo.AddEmployee(manager);
                        _employeesList=efo.GetEmployees();
                    }
                }
                else if (combType.Text == MyTypes.Employee.ToString())
                {
                    Employee employee = new Employee()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Password = txtPassword.Text,
                        Job = txtJob.Text,
                        BirthDay = dtpDOB.Value,
                        Gender = rdBtnFemale.Checked ? Gender.Female.ToString() : Gender.Male.ToString(),
                        Mstatus = combStatus.Text,
                        Habits = Habits(grpHabits),
                        Salary = nudSalary.Value,
                        ArabicLang = (byte)nudAr.Value,
                        EnglishLang = (byte)nudEn.Value,
                        Type=MyTypes.Employee.ToString(),
                    };
                    if (ConnectionType)
                    {
                        ADO.AddEmployee(employee);
                        _employeesList = ADO.GetEmployees();
                    }
                    else
                    {
                        var efo = new EFOperators();
                        efo.AddEmployee(employee);
                        _employeesList = efo.GetEmployees();
                    }
                }
                else
                {
                    MessageBox.Show("Unsupported Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Info added successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowInfo(_employeesList[_employeesList.Count - 1]);
                labelNoOfEmps.Text = _employeesList.Count.ToString() + " /";
                txtCurrent.Text = _employeesList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void nudEn_ValueChanged(object sender, EventArgs e)
        {
            ProgressBarValidator(progBarEn, nudEn);
        }

        private void nudAr_ValueChanged(object sender, EventArgs e)
        {
            ProgressBarValidator(progBarAr, nudAr);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm(pnlForm);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int x;
            bool b = int.TryParse(txtCurrent.Text, out x);
            if (b && (x - 1) < _employeesList.Count && x != 0)
                ShowInfo(_employeesList[x - 1]);
            else
                MessageBox.Show("Number is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_employeesList.Count == 0)
            {
                MessageBox.Show("There is no data to show", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowInfo(_employeesList[0]);
            txtCurrent.Text = "1";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_employeesList.Count == 0)
            {
                MessageBox.Show("There is no data to show", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ShowInfo(_employeesList[_employeesList.Count - 1]);
            txtCurrent.Text = _employeesList.Count.ToString();
        }

        private void txtCurrent_TextChanged(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = int.Parse(txtCurrent.Text);
            }
            catch (Exception)
            {
                x = 1;
            }
            if (x > 0 && x <= _employeesList.Count)
            {
                ShowInfo(_employeesList[x - 1]);
            }
            else
            {
                MessageBox.Show("Number is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = int.Parse(txtCurrent.Text);
            }
            catch (Exception)
            {
                x = 1;
            }
            if (x - 1 > 0 && x - 1 <= _employeesList.Count)
            {
                ShowInfo(_employeesList[x - 2]);
                txtCurrent.Text = (x - 1).ToString();
            }
            else
            {
                MessageBox.Show("Number is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = int.Parse(txtCurrent.Text);
            }
            catch (Exception)
            {
                x = 0;
            }
            if (x + 1 > 0 && x + 1 <= _employeesList.Count)
            {
                ShowInfo(_employeesList[x]);
                txtCurrent.Text = (x + 1).ToString();
            }
            else
            {
                MessageBox.Show("Number is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleDepartmentPanal(combType.Text);
        }

        #region My Methodes
        private string Habits(GroupBox gb)
        {
            StringBuilder sb = new StringBuilder();
            foreach (CheckBox item in gb.Controls)
            {
                if (item.Checked)
                    sb.Append(item.Text + ", ");
            }
            return sb.ToString();
        }
        private void ProgressBarValidator(ProgressBar pb, NumericUpDown nud)
        {
            if (nud.Value >= 0 && nud.Value <= 100)
            {
                pb.Value = (int)nud.Value;
            }
        }
        private void NUDSalaryValidator(NumericUpDown nud)
        {
            if (nud.Value <= 0)
            {
                MessageBox.Show("Salary can't be less than or equal zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud.Focus();
                throw new Exception();
            }
        }
        private void TextValidator(params Control[] tbs)
        {
            foreach (Control tb in tbs)
            {
                if (tb.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb.Focus();
                    throw new Exception();
                }
            }
        }
        private void ResetForm(Control frm)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is GroupBox || item is Panel)
                    ResetForm(item);
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                if (item is RadioButton)
                    ((RadioButton)item).Checked = false;
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1;
                if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now;
            }
            rtxtReport.Text = string.Empty;
        }
        private void ShowInfo(Person ps)
        {
            var sb = new StringBuilder();
            sb.AppendLine(" ------------- your Information ------------- ");
            sb.AppendLine(ps.Type==MyTypes.Employee.ToString()? ((Employee)ps).PrintInfo(): (new Manager(ps as Employee)).PrintInfo());
            ToggleDepartmentPanal(ps.Type.ToString());
            ShowInfoOnForm(ps);
            rtxtReport.Text = sb.ToString();
        }
        private void ShowInfoOnForm(Person ps)
        {
            txtFirstName.Text = ps.FirstName;
            txtLastName.Text = ps.LastName;
            txtPassword.Text = "********";
            dtpDOB.Value = ps.BirthDay;
            combStatus.Text = ps.Mstatus;
            combType.Text = ps.Type.ToString();
            if (ps.Gender == Gender.Male.ToString())
            {
                rdBtnMale.Checked = true;
                rdBtnFemale.Checked = false;
            }
            else
            {
                rdBtnFemale.Checked = true;
                rdBtnMale.Checked = false;
            }
            ComboBoxGroupSetter(grpHabits, ps);
            NudSetter(nudEn, ps.EnglishLang);
            NudSetter(nudAr, ps.ArabicLang);
            ProgressBarSetter(progBarAr, ps.ArabicLang);
            ProgressBarSetter(progBarEn, ps.EnglishLang);
            if (ps.Type==MyTypes.Employee.ToString())
            {
                Employee employee = (Employee)ps;
                txtJob.Text = employee.Job;
                NudSetter(nudSalary, employee.Salary);
            }
            if (ps.Type == MyTypes.Manager.ToString())
            {
                Employee employee = (Employee)ps;
                txtDepartment.Text = employee.Department;
            }
        }
        private void CheckBoxValidator(GroupBox gb)
        {
            int x = 0;
            foreach (CheckBox item in gb.Controls)
            {
                if (item.Checked)
                {
                    x++;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Pls check one habbit atleast", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception();
            }

        }
        internal static bool RadioBtnValidator(GroupBox gb)
        {
            int x = 0;
            foreach (RadioButton item in gb.Controls)
            {
                if (item.Checked)
                {
                    x++;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Pls choose your gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception();
            }
            //MessageBox.Show($"{((RadioButton)gb.Controls[0]).Name} is {((RadioButton)gb.Controls[0]).Checked}\n{((RadioButton)gb.Controls[1]).Name} is {((RadioButton)gb.Controls[1]).Checked}");
            return ((RadioButton)gb.Controls[1]).Checked;
        }
        private void ComboBoxGroupSetter(GroupBox gb, Person ps)
        {
            string[] habits = ps.Habits.Split(',');
            foreach (CheckBox item in gb.Controls)
            {
                item.Checked = false;
                for (int i = 0; i < habits.Length; i++)
                {
                    if (habits[i].Trim() == item.Text)
                    {
                        item.Checked = true; break;
                    }
                }
            }

        }
        private void NudSetter(NumericUpDown nud, decimal value) => nud.Value = value;
        private void ProgressBarSetter(ProgressBar pb, uint value) => pb.Value = (int)value;
        private void ToggleDepartmentPanal(string departmrnt)
        {
            if (departmrnt == MyTypes.Manager.ToString())
                pnlDepartment.Visible = true;
            else
                pnlDepartment.Visible = false;
        }
        #endregion
    }
}
