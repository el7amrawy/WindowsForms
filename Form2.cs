namespace Day4_Task1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            //MessageBox.Show(frm.RadioBtnValidator(grpConnType).ToString());
            var frm=new Form1() { ConnectionType= Form1.RadioBtnValidator(grpConnType) };
            frm.FormClosed += new FormClosedEventHandler((sender, e) => {
                Close();
            });
            frm.Show();
        }
    }
}
