
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLevel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStylePoints = new System.Windows.Forms.Button();
            this.btnStyleTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(1, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 61);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Maroon;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewGame.Location = new System.Drawing.Point(179, 0);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(163, 61);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.poeni_background;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(543, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "Поени";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.vreme_background2;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(543, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Време";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLevel
            // 
            this.btnLevel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.vreme_background2;
            this.btnLevel.FlatAppearance.BorderSize = 0;
            this.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLevel.Location = new System.Drawing.Point(698, 94);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(163, 61);
            this.btnLevel.TabIndex = 9;
            this.btnLevel.Text = "Помош";
            this.btnLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLevel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.poeni_background;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(543, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ниво";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnStylePoints
            // 
            this.btnStylePoints.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.vreme_background2;
            this.btnStylePoints.FlatAppearance.BorderSize = 0;
            this.btnStylePoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStylePoints.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStylePoints.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStylePoints.Location = new System.Drawing.Point(698, 161);
            this.btnStylePoints.Name = "btnStylePoints";
            this.btnStylePoints.Size = new System.Drawing.Size(163, 61);
            this.btnStylePoints.TabIndex = 11;
            this.btnStylePoints.Text = "0";
            this.btnStylePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStylePoints.UseVisualStyleBackColor = true;
            // 
            // btnStyleTime
            // 
            this.btnStyleTime.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.vreme_background2;
            this.btnStyleTime.FlatAppearance.BorderSize = 0;
            this.btnStyleTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyleTime.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyleTime.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStyleTime.Location = new System.Drawing.Point(698, 228);
            this.btnStyleTime.Name = "btnStyleTime";
            this.btnStyleTime.Size = new System.Drawing.Size(163, 61);
            this.btnStyleTime.TabIndex = 12;
            this.btnStyleTime.Text = "00:00";
            this.btnStyleTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStyleTime.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.solitaire_background;
            this.ClientSize = new System.Drawing.Size(938, 752);
            this.Controls.Add(this.btnStyleTime);
            this.Controls.Add(this.btnStylePoints);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnBack);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStylePoints;
        private System.Windows.Forms.Button btnStyleTime;
    }
}

