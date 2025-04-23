namespace Öğrenci_Bilgileri
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
            lblName = new Label();
            lblSurname = new Label();
            lblDepertman = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtDepertman = new TextBox();
            btnVerifyData = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(254, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(254, 127);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(74, 20);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surname :";
            // 
            // lblDepertman
            // 
            lblDepertman.AutoSize = true;
            lblDepertman.Location = new Point(254, 193);
            lblDepertman.Name = "lblDepertman";
            lblDepertman.Size = new Size(91, 20);
            lblDepertman.TabIndex = 2;
            lblDepertman.Text = "Depertman :";
            // 
            // txtName
            // 
            txtName.Location = new Point(358, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 27);
            txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(358, 120);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(167, 27);
            txtSurname.TabIndex = 4;
            // 
            // txtDepertman
            // 
            txtDepertman.Location = new Point(358, 190);
            txtDepertman.Name = "txtDepertman";
            txtDepertman.Size = new Size(167, 27);
            txtDepertman.TabIndex = 5;
            // 
            // btnVerifyData
            // 
            btnVerifyData.Location = new Point(475, 276);
            btnVerifyData.Name = "btnVerifyData";
            btnVerifyData.Size = new Size(124, 40);
            btnVerifyData.TabIndex = 6;
            btnVerifyData.Text = "Verify Data";
            btnVerifyData.UseVisualStyleBackColor = true;
            btnVerifyData.Click += btnVerifyData_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(243, 358);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnVerifyData);
            Controls.Add(txtDepertman);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblDepertman);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label lblDepertman;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtDepertman;
        private Button btnVerifyData;
        private Label lblResult;
    }
}
