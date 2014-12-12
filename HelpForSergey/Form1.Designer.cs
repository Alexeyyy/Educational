namespace HelpForSergey
{
    partial class Form1
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
            this.btn_LaunchTimer = new System.Windows.Forms.Button();
            this.lbl_LabelTimer = new System.Windows.Forms.Label();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LaunchTimer
            // 
            this.btn_LaunchTimer.Location = new System.Drawing.Point(34, 251);
            this.btn_LaunchTimer.Name = "btn_LaunchTimer";
            this.btn_LaunchTimer.Size = new System.Drawing.Size(212, 134);
            this.btn_LaunchTimer.TabIndex = 0;
            this.btn_LaunchTimer.Text = "Старт";
            this.btn_LaunchTimer.UseVisualStyleBackColor = true;
            this.btn_LaunchTimer.Click += new System.EventHandler(this.btn_LaunchTimer_Click);
            // 
            // lbl_LabelTimer
            // 
            this.lbl_LabelTimer.AutoSize = true;
            this.lbl_LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_LabelTimer.Location = new System.Drawing.Point(28, 196);
            this.lbl_LabelTimer.Name = "lbl_LabelTimer";
            this.lbl_LabelTimer.Size = new System.Drawing.Size(110, 31);
            this.lbl_LabelTimer.TabIndex = 1;
            this.lbl_LabelTimer.Text = "Таймер";
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.Location = new System.Drawing.Point(27, 30);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(301, 39);
            this.lbl_Text.TabIndex = 2;
            this.lbl_Text.Text = "Текст до 5 секунд";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 565);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.lbl_LabelTimer);
            this.Controls.Add(this.btn_LaunchTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LaunchTimer;
        private System.Windows.Forms.Label lbl_LabelTimer;
        private System.Windows.Forms.Label lbl_Text;
    }
}

