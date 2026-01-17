namespace WinFormsExample
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnSubmit = new Button();
            btnToRunawayBtn = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 15F);
            lblUserName.Location = new Point(12, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(173, 28);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Введіть ваше ім'я:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 20F);
            txtUserName.Location = new Point(12, 40);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(403, 43);
            txtUserName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 89);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(403, 60);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Підтвердити";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnToRunawayBtn
            // 
            btnToRunawayBtn.Location = new Point(12, 204);
            btnToRunawayBtn.Name = "btnToRunawayBtn";
            btnToRunawayBtn.Size = new Size(403, 53);
            btnToRunawayBtn.TabIndex = 3;
            btnToRunawayBtn.Text = "Кнопка-втікач";
            btnToRunawayBtn.UseVisualStyleBackColor = true;
            btnToRunawayBtn.Click += btnToRunawayBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 297);
            Controls.Add(btnToRunawayBtn);
            Controls.Add(btnSubmit);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Name = "Form1";
            Text = "Вітання";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnSubmit;
        private Button btnToRunawayBtn;
    }
}
