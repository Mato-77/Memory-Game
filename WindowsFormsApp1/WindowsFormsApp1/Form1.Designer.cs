
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tbPoints
            // 
            this.tbPoints.Location = new System.Drawing.Point(528, 59);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(100, 22);
            this.tbPoints.TabIndex = 0;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(528, 130);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 22);
            this.tbTimer.TabIndex = 1;
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(528, 195);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(207, 23);
            this.progressBarTime.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(782, 853);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tbPoints);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPoints;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.ProgressBar progressBarTime;
    }
}

