namespace Day4_Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            dtpDOB = new DateTimePicker();
            combStatus = new ComboBox();
            grpHabits = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            grpGender = new GroupBox();
            rdBtnFemale = new RadioButton();
            rdBtnMale = new RadioButton();
            nudSalary = new NumericUpDown();
            label7 = new Label();
            nudEn = new NumericUpDown();
            label8 = new Label();
            progBarEn = new ProgressBar();
            btnResult = new Button();
            groupBox3 = new GroupBox();
            labelNoOfEmps = new Label();
            txtCurrent = new TextBox();
            btnNext = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            rtxtReport = new RichTextBox();
            btnPrint = new Button();
            btnPreview = new Button();
            btnPageSetup = new Button();
            label9 = new Label();
            nudAr = new NumericUpDown();
            label10 = new Label();
            progBarAr = new ProgressBar();
            label2 = new Label();
            txtLastName = new TextBox();
            btnAdd = new Button();
            btnReset = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            label11 = new Label();
            txtJob = new TextBox();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            label13 = new Label();
            combType = new ComboBox();
            pnlForm = new Panel();
            pnlDepartment = new Panel();
            txtDepartment = new TextBox();
            label12 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            labelConnection = new Label();
            grpHabits.SuspendLayout();
            grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEn).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAr).BeginInit();
            pnlForm.SuspendLayout();
            pnlDepartment.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 177);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Birth Day :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 207);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "M status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 342);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Salary :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(102, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 27);
            txtFirstName.TabIndex = 5;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(102, 170);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(276, 27);
            dtpDOB.TabIndex = 7;
            // 
            // combStatus
            // 
            combStatus.FormattingEnabled = true;
            combStatus.Items.AddRange(new object[] { "أعزب", "متزوج", "أرمل", "مطلق" });
            combStatus.Location = new Point(102, 201);
            combStatus.Name = "combStatus";
            combStatus.Size = new Size(276, 28);
            combStatus.TabIndex = 8;
            // 
            // grpHabits
            // 
            grpHabits.Controls.Add(checkBox4);
            grpHabits.Controls.Add(checkBox3);
            grpHabits.Controls.Add(checkBox2);
            grpHabits.Controls.Add(checkBox1);
            grpHabits.Location = new Point(12, 243);
            grpHabits.Name = "grpHabits";
            grpHabits.Size = new Size(146, 153);
            grpHabits.TabIndex = 9;
            grpHabits.TabStop = false;
            grpHabits.Text = "Habits";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(15, 116);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(124, 24);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Body Building";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(16, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(114, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "TV Watching";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Swimming";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Football";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdBtnFemale);
            grpGender.Controls.Add(rdBtnMale);
            grpGender.Location = new Point(190, 243);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(188, 80);
            grpGender.TabIndex = 10;
            grpGender.TabStop = false;
            grpGender.Text = "Gender :";
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Location = new Point(92, 38);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(78, 24);
            rdBtnFemale.TabIndex = 1;
            rdBtnFemale.TabStop = true;
            rdBtnFemale.Text = "Female";
            rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Location = new Point(6, 38);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(63, 24);
            rdBtnMale.TabIndex = 0;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Male";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // nudSalary
            // 
            nudSalary.DecimalPlaces = 2;
            nudSalary.Location = new Point(252, 340);
            nudSalary.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudSalary.Name = "nudSalary";
            nudSalary.Size = new Size(126, 27);
            nudSalary.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 407);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 14;
            label7.Text = "English :";
            // 
            // nudEn
            // 
            nudEn.Location = new Point(86, 405);
            nudEn.Name = "nudEn";
            nudEn.Size = new Size(77, 27);
            nudEn.TabIndex = 15;
            nudEn.ValueChanged += nudEn_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 407);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 16;
            label8.Text = "%";
            // 
            // progBarEn
            // 
            progBarEn.Location = new Point(196, 405);
            progBarEn.Name = "progBarEn";
            progBarEn.Size = new Size(181, 29);
            progBarEn.TabIndex = 17;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(17, 474);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(69, 29);
            btnResult.TabIndex = 18;
            btnResult.Text = "Show Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelNoOfEmps);
            groupBox3.Controls.Add(txtCurrent);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnLast);
            groupBox3.Controls.Add(btnPrevious);
            groupBox3.Controls.Add(btnFirst);
            groupBox3.Controls.Add(rtxtReport);
            groupBox3.Controls.Add(btnPrint);
            groupBox3.Controls.Add(btnPreview);
            groupBox3.Controls.Add(btnPageSetup);
            groupBox3.Location = new Point(410, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(367, 483);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Report";
            // 
            // labelNoOfEmps
            // 
            labelNoOfEmps.AutoSize = true;
            labelNoOfEmps.ForeColor = Color.Red;
            labelNoOfEmps.Location = new Point(152, 445);
            labelNoOfEmps.Name = "labelNoOfEmps";
            labelNoOfEmps.Size = new Size(27, 20);
            labelNoOfEmps.TabIndex = 9;
            labelNoOfEmps.Text = "1 /";
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(185, 442);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(38, 27);
            txtCurrent.TabIndex = 8;
            txtCurrent.TextChanged += txtCurrent_TextChanged;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(266, 440);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(35, 29);
            btnNext.TabIndex = 7;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(325, 440);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(35, 29);
            btnLast.TabIndex = 6;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(73, 440);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(35, 29);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(15, 440);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(35, 29);
            btnFirst.TabIndex = 4;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // rtxtReport
            // 
            rtxtReport.Location = new Point(15, 26);
            rtxtReport.Name = "rtxtReport";
            rtxtReport.Size = new Size(346, 359);
            rtxtReport.TabIndex = 3;
            rtxtReport.Text = "";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(266, 396);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(140, 396);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(94, 29);
            btnPreview.TabIndex = 1;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnPageSetup
            // 
            btnPageSetup.Location = new Point(14, 396);
            btnPageSetup.Name = "btnPageSetup";
            btnPageSetup.Size = new Size(94, 29);
            btnPageSetup.TabIndex = 0;
            btnPageSetup.Text = "Page Setup";
            btnPageSetup.UseVisualStyleBackColor = true;
            btnPageSetup.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 443);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 20;
            label9.Text = "Arabic :";
            // 
            // nudAr
            // 
            nudAr.Location = new Point(86, 441);
            nudAr.Name = "nudAr";
            nudAr.Size = new Size(78, 27);
            nudAr.TabIndex = 21;
            nudAr.ValueChanged += nudAr_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 443);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 22;
            label10.Text = "%";
            // 
            // progBarAr
            // 
            progBarAr.Location = new Point(196, 439);
            progBarAr.Name = "progBarAr";
            progBarAr.Size = new Size(182, 29);
            progBarAr.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 24;
            label2.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(102, 77);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 27);
            txtLastName.TabIndex = 25;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(154, 474);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 29);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(291, 474);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(69, 29);
            btnReset.TabIndex = 27;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 112);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 28;
            label6.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 27);
            txtPassword.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 144);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 30;
            label11.Text = "Job :";
            // 
            // txtJob
            // 
            txtJob.Location = new Point(102, 139);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(276, 27);
            txtJob.TabIndex = 31;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(0, 9);
            label13.Name = "label13";
            label13.Size = new Size(47, 20);
            label13.TabIndex = 32;
            label13.Text = "Type :";
            // 
            // combType
            // 
            combType.FormattingEnabled = true;
            combType.Items.AddRange(new object[] { "Manager", "Employee", "Person" });
            combType.Location = new Point(44, 6);
            combType.Name = "combType";
            combType.Size = new Size(122, 28);
            combType.TabIndex = 33;
            combType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(pnlDepartment);
            pnlForm.Controls.Add(txtJob);
            pnlForm.Controls.Add(combType);
            pnlForm.Controls.Add(label1);
            pnlForm.Controls.Add(label13);
            pnlForm.Controls.Add(label3);
            pnlForm.Controls.Add(label4);
            pnlForm.Controls.Add(label11);
            pnlForm.Controls.Add(label5);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(label6);
            pnlForm.Controls.Add(dtpDOB);
            pnlForm.Controls.Add(btnReset);
            pnlForm.Controls.Add(combStatus);
            pnlForm.Controls.Add(btnAdd);
            pnlForm.Controls.Add(grpHabits);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(grpGender);
            pnlForm.Controls.Add(label2);
            pnlForm.Controls.Add(nudSalary);
            pnlForm.Controls.Add(progBarAr);
            pnlForm.Controls.Add(label7);
            pnlForm.Controls.Add(label10);
            pnlForm.Controls.Add(nudEn);
            pnlForm.Controls.Add(nudAr);
            pnlForm.Controls.Add(label8);
            pnlForm.Controls.Add(label9);
            pnlForm.Controls.Add(progBarEn);
            pnlForm.Controls.Add(btnResult);
            pnlForm.Location = new Point(10, 11);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(394, 505);
            pnlForm.TabIndex = 34;
            // 
            // pnlDepartment
            // 
            pnlDepartment.Controls.Add(txtDepartment);
            pnlDepartment.Controls.Add(label12);
            pnlDepartment.Location = new Point(172, 8);
            pnlDepartment.Name = "pnlDepartment";
            pnlDepartment.Size = new Size(220, 27);
            pnlDepartment.TabIndex = 34;
            pnlDepartment.Visible = false;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(98, -2);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(111, 27);
            txtDepartment.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 1);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 0;
            label12.Text = "Department : ";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // labelConnection
            // 
            labelConnection.AutoSize = true;
            labelConnection.BackColor = Color.Yellow;
            labelConnection.ForeColor = Color.DarkRed;
            labelConnection.Location = new Point(410, 497);
            labelConnection.Name = "labelConnection";
            labelConnection.Size = new Size(58, 20);
            labelConnection.TabIndex = 35;
            labelConnection.Text = "label14";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 521);
            Controls.Add(labelConnection);
            Controls.Add(pnlForm);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            grpHabits.ResumeLayout(false);
            grpHabits.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEn).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAr).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlDepartment.ResumeLayout(false);
            pnlDepartment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private DateTimePicker dtpDOB;
        private ComboBox combStatus;
        private GroupBox grpHabits;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox grpGender;
        private RadioButton rdBtnFemale;
        private RadioButton rdBtnMale;
        private NumericUpDown nudSalary;
        private Label label7;
        private NumericUpDown nudEn;
        private Label label8;
        private ProgressBar progBarEn;
        private Button btnResult;
        private GroupBox groupBox3;
        private RichTextBox rtxtReport;
        private Button btnPrint;
        private Button btnPreview;
        private Button btnPageSetup;
        private Label label9;
        private NumericUpDown nudAr;
        private Label label10;
        private ProgressBar progBarAr;
        private Label label2;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnReset;
        private Label label6;
        private TextBox txtPassword;
        private Label label11;
        private TextBox txtJob;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnNext;
        private Label label13;
        private ComboBox combType;
        private Label labelNoOfEmps;
        private TextBox txtCurrent;
        private Panel pnlForm;
        private Panel pnlDepartment;
        private TextBox txtDepartment;
        private Label label12;
        private NotifyIcon notifyIcon1;
        private Label labelConnection;
    }
}
