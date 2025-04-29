namespace information_save
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
            lblDepertman = new Label();
            lblSurname = new Label();
            btnVerifyData = new Button();
            lblResult = new Label();
            txtName = new TextBox();
            txtDepertman = new TextBox();
            txtSurname = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(210, 103);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // lblDepertman
            // 
            lblDepertman.AutoSize = true;
            lblDepertman.Location = new Point(210, 208);
            lblDepertman.Name = "lblDepertman";
            lblDepertman.Size = new Size(91, 20);
            lblDepertman.TabIndex = 1;
            lblDepertman.Text = "Depertman :";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(210, 157);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(74, 20);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname :";
            // 
            // btnVerifyData
            // 
            btnVerifyData.Location = new Point(529, 294);
            btnVerifyData.Name = "btnVerifyData";
            btnVerifyData.Size = new Size(144, 66);
            btnVerifyData.TabIndex = 3;
            btnVerifyData.Text = "Verify Data";
            btnVerifyData.UseVisualStyleBackColor = true;
            btnVerifyData.Click += btnVerifyData_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(263, 318);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result :";
            // 
            // txtName
            // 
            txtName.Location = new Point(411, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // txtDepertman
            // 
            txtDepertman.Location = new Point(411, 208);
            txtDepertman.Name = "txtDepertman";
            txtDepertman.Size = new Size(125, 27);
            txtDepertman.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(411, 150);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSurname);
            Controls.Add(txtDepertman);
            Controls.Add(txtName);
            Controls.Add(lblResult);
            Controls.Add(btnVerifyData);
            Controls.Add(lblSurname);
            Controls.Add(lblDepertman);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDepertman;
        private Label lblSurname;
        private Button btnVerifyData;
        private Label lblResult;
        private TextBox txtName;
        private TextBox txtDepertman;
        private TextBox txtSurname;
    }
}
