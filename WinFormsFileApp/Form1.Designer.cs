namespace WinFormsFileApp
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
            this.buttonRapidCopy = new System.Windows.Forms.Button();
            this.buttonRapidMove = new System.Windows.Forms.Button();
            this.buttonRapidDelete = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRapidCopy
            // 
            this.buttonRapidCopy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRapidCopy.Location = new System.Drawing.Point(12, 125);
            this.buttonRapidCopy.Name = "buttonRapidCopy";
            this.buttonRapidCopy.Size = new System.Drawing.Size(470, 95);
            this.buttonRapidCopy.TabIndex = 0;
            this.buttonRapidCopy.Text = "Rapid Copy";
            this.buttonRapidCopy.UseVisualStyleBackColor = true;
            this.buttonRapidCopy.Click += new System.EventHandler(this.buttonRapidCopy_Click);
            // 
            // buttonRapidMove
            // 
            this.buttonRapidMove.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRapidMove.Location = new System.Drawing.Point(12, 226);
            this.buttonRapidMove.Name = "buttonRapidMove";
            this.buttonRapidMove.Size = new System.Drawing.Size(470, 95);
            this.buttonRapidMove.TabIndex = 1;
            this.buttonRapidMove.Text = "Rapid Move";
            this.buttonRapidMove.UseVisualStyleBackColor = true;
            this.buttonRapidMove.Click += new System.EventHandler(this.buttonRapidMove_Click);
            // 
            // buttonRapidDelete
            // 
            this.buttonRapidDelete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRapidDelete.Location = new System.Drawing.Point(12, 327);
            this.buttonRapidDelete.Name = "buttonRapidDelete";
            this.buttonRapidDelete.Size = new System.Drawing.Size(470, 95);
            this.buttonRapidDelete.TabIndex = 2;
            this.buttonRapidDelete.Text = "Rapid Delete";
            this.buttonRapidDelete.UseVisualStyleBackColor = true;
            this.buttonRapidDelete.Click += new System.EventHandler(this.buttonRapidDelete_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(110, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(275, 37);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome to File Tools";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonRapidDelete);
            this.Controls.Add(this.buttonRapidMove);
            this.Controls.Add(this.buttonRapidCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "File Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRapidCopy;
        private Button buttonRapidMove;
        private Button buttonRapidDelete;
        private Label labelWelcome;
    }
}