namespace WinFormsExample
{
    partial class RunawayButtonForm
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
            btnRunaway = new Button();
            SuspendLayout();
            // 
            // btnRunaway
            // 
            btnRunaway.Location = new Point(314, 195);
            btnRunaway.Name = "btnRunaway";
            btnRunaway.Size = new Size(144, 41);
            btnRunaway.TabIndex = 0;
            btnRunaway.Text = "НАТИСНИ!";
            btnRunaway.UseVisualStyleBackColor = true;
            btnRunaway.MouseEnter += btnRunaway_MouseEnter;
            // 
            // RunawayButtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRunaway);
            Name = "RunawayButtonForm";
            Text = "RunawayButtonForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRunaway;
    }
}