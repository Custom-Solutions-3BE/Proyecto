
namespace BackOffice
{
    partial class BackOffice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.WelcomUserLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 70);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "User Finder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Report review";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gruoup finder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // WelcomUserLabel
            // 
            this.WelcomUserLabel.AutoSize = true;
            this.WelcomUserLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomUserLabel.Location = new System.Drawing.Point(313, 295);
            this.WelcomUserLabel.Name = "WelcomUserLabel";
            this.WelcomUserLabel.Size = new System.Drawing.Size(333, 55);
            this.WelcomUserLabel.TabIndex = 1;
            this.WelcomUserLabel.Text = "Welcome user";
            this.WelcomUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.WelcomUserLabel);
            this.Controls.Add(this.panel1);
            this.Name = "BackOffice";
            this.ShowInTaskbar = false;
            this.Text = "BackOffice";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WelcomUserLabel;
    }
}

