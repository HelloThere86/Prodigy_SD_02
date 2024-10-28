namespace Prodigy_infotech_task_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Guessbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Luckbtn = new System.Windows.Forms.Button();
            this.NumAtt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Guess (1-5):";
            // 
            // Guessbox
            // 
            this.Guessbox.Location = new System.Drawing.Point(347, 178);
            this.Guessbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Guessbox.Name = "Guessbox";
            this.Guessbox.Size = new System.Drawing.Size(160, 24);
            this.Guessbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of attampts";
            // 
            // Luckbtn
            // 
            this.Luckbtn.Location = new System.Drawing.Point(260, 258);
            this.Luckbtn.Name = "Luckbtn";
            this.Luckbtn.Size = new System.Drawing.Size(160, 38);
            this.Luckbtn.TabIndex = 6;
            this.Luckbtn.Text = "TEST MY LUCK";
            this.Luckbtn.UseVisualStyleBackColor = true;
            this.Luckbtn.Click += new System.EventHandler(this.Luckbtn_Click);
            // 
            // NumAtt
            // 
            this.NumAtt.AutoSize = true;
            this.NumAtt.Location = new System.Drawing.Point(343, 340);
            this.NumAtt.Name = "NumAtt";
            this.NumAtt.Size = new System.Drawing.Size(50, 19);
            this.NumAtt.TabIndex = 7;
            this.NumAtt.Text = "label3";
            this.NumAtt.Click += new System.EventHandler(this.NumAtt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter number from 1 to 5";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumAtt);
            this.Controls.Add(this.Luckbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Guessbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Guessbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Luckbtn;
        private System.Windows.Forms.Label NumAtt;
        private System.Windows.Forms.Label label3;
    }
}

