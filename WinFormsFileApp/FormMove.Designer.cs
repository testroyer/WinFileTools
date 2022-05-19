namespace WinFormsFileApp
{
    partial class FormMove
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
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMove
            // 
            this.buttonMove.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMove.Location = new System.Drawing.Point(29, 205);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(418, 64);
            this.buttonMove.TabIndex = 9;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonTarget
            // 
            this.buttonTarget.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTarget.Location = new System.Drawing.Point(261, 126);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(191, 37);
            this.buttonTarget.TabIndex = 8;
            this.buttonTarget.Text = "Select";
            this.buttonTarget.UseVisualStyleBackColor = true;
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRoot.Location = new System.Drawing.Point(261, 64);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(191, 37);
            this.buttonRoot.TabIndex = 7;
            this.buttonRoot.Text = "Select";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.buttonRoot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Target Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Root Path:";
            // 
            // FormMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 317);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonTarget);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMove";
            this.Text = "FormMove";
            this.Load += new System.EventHandler(this.FormMove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonMove;
        private Button buttonTarget;
        private Button buttonRoot;
        private Label label2;
        private Label label1;
    }
}