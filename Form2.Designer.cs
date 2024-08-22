namespace Day4_Task1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpConnType = new GroupBox();
            rdBtnEF = new RadioButton();
            rdBtnADO = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            grpConnType.SuspendLayout();
            SuspendLayout();
            // 
            // grpConnType
            // 
            grpConnType.Controls.Add(rdBtnEF);
            grpConnType.Controls.Add(rdBtnADO);
            grpConnType.Location = new Point(150, 129);
            grpConnType.Name = "grpConnType";
            grpConnType.Size = new Size(259, 44);
            grpConnType.TabIndex = 36;
            grpConnType.TabStop = false;
            grpConnType.Text = "Connection Type";
            // 
            // rdBtnEF
            // 
            rdBtnEF.AutoSize = true;
            rdBtnEF.Location = new Point(109, 17);
            rdBtnEF.Name = "rdBtnEF";
            rdBtnEF.Size = new Size(144, 24);
            rdBtnEF.TabIndex = 1;
            rdBtnEF.Text = "Entity Framework";
            rdBtnEF.UseVisualStyleBackColor = true;
            // 
            // rdBtnADO
            // 
            rdBtnADO.AutoSize = true;
            rdBtnADO.Checked = true;
            rdBtnADO.Location = new Point(12, 17);
            rdBtnADO.Name = "rdBtnADO";
            rdBtnADO.Size = new Size(62, 24);
            rdBtnADO.TabIndex = 0;
            rdBtnADO.TabStop = true;
            rdBtnADO.Text = "ADO";
            rdBtnADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DecoType Naskh", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(491, 63);
            label1.TabIndex = 2;
            label1.Text = "Choose Connection type";
            // 
            // button1
            // 
            button1.Location = new Point(232, 216);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 37;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(558, 284);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(grpConnType);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection Type";
            grpConnType.ResumeLayout(false);
            grpConnType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpConnType;
        private RadioButton rdBtnEF;
        private RadioButton rdBtnADO;
        private Label label1;
        private Button button1;
    }
}