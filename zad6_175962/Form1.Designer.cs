namespace zad6_175962
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.awaria_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.predkosc_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fan1_button = new System.Windows.Forms.Button();
            this.fan2_button = new System.Windows.Forms.Button();
            this.fan3_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.fan1_pictureBox = new System.Windows.Forms.PictureBox();
            this.fan2_pictureBox = new System.Windows.Forms.PictureBox();
            this.fan3_pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fan1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fan2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fan3_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // awaria_label
            // 
            this.awaria_label.BackColor = System.Drawing.Color.Yellow;
            this.awaria_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.awaria_label.ForeColor = System.Drawing.Color.Red;
            this.awaria_label.Location = new System.Drawing.Point(692, 79);
            this.awaria_label.Name = "awaria_label";
            this.awaria_label.Size = new System.Drawing.Size(462, 110);
            this.awaria_label.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(689, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Predkosc lini produkcyjnej";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hScrollBar1.Location = new System.Drawing.Point(696, 250);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(312, 36);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // predkosc_label
            // 
            this.predkosc_label.AutoSize = true;
            this.predkosc_label.Location = new System.Drawing.Point(960, 215);
            this.predkosc_label.Name = "predkosc_label";
            this.predkosc_label.Size = new System.Drawing.Size(74, 20);
            this.predkosc_label.TabIndex = 7;
            this.predkosc_label.Text = "predkosc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(699, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wentylatory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(759, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wentylator 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(759, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wentylator 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(759, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wentylator 3";
            // 
            // fan1_button
            // 
            this.fan1_button.Location = new System.Drawing.Point(899, 367);
            this.fan1_button.Name = "fan1_button";
            this.fan1_button.Size = new System.Drawing.Size(100, 41);
            this.fan1_button.TabIndex = 12;
            this.fan1_button.Text = "ON/OFF";
            this.fan1_button.UseVisualStyleBackColor = true;
            this.fan1_button.Click += new System.EventHandler(this.fan1_button_Click);
            // 
            // fan2_button
            // 
            this.fan2_button.Location = new System.Drawing.Point(899, 422);
            this.fan2_button.Name = "fan2_button";
            this.fan2_button.Size = new System.Drawing.Size(100, 41);
            this.fan2_button.TabIndex = 13;
            this.fan2_button.Text = "ON/OFF";
            this.fan2_button.UseVisualStyleBackColor = true;
            this.fan2_button.Click += new System.EventHandler(this.fan2_button_Click);
            // 
            // fan3_button
            // 
            this.fan3_button.Location = new System.Drawing.Point(899, 478);
            this.fan3_button.Name = "fan3_button";
            this.fan3_button.Size = new System.Drawing.Size(100, 41);
            this.fan3_button.TabIndex = 14;
            this.fan3_button.Text = "ON/OFF";
            this.fan3_button.UseVisualStyleBackColor = true;
            this.fan3_button.Click += new System.EventHandler(this.fan3_button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(1074, 283);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ReadOnly = true;
            this.info_textBox.Size = new System.Drawing.Size(392, 226);
            this.info_textBox.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 45000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fan1_pictureBox
            // 
            this.fan1_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fan1_pictureBox.Image")));
            this.fan1_pictureBox.Location = new System.Drawing.Point(696, 358);
            this.fan1_pictureBox.Name = "fan1_pictureBox";
            this.fan1_pictureBox.Size = new System.Drawing.Size(57, 50);
            this.fan1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fan1_pictureBox.TabIndex = 18;
            this.fan1_pictureBox.TabStop = false;
            this.fan1_pictureBox.Visible = false;
            // 
            // fan2_pictureBox
            // 
            this.fan2_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fan2_pictureBox.Image")));
            this.fan2_pictureBox.Location = new System.Drawing.Point(696, 414);
            this.fan2_pictureBox.Name = "fan2_pictureBox";
            this.fan2_pictureBox.Size = new System.Drawing.Size(57, 50);
            this.fan2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fan2_pictureBox.TabIndex = 19;
            this.fan2_pictureBox.TabStop = false;
            this.fan2_pictureBox.Visible = false;
            // 
            // fan3_pictureBox
            // 
            this.fan3_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fan3_pictureBox.Image")));
            this.fan3_pictureBox.Location = new System.Drawing.Point(696, 471);
            this.fan3_pictureBox.Name = "fan3_pictureBox";
            this.fan3_pictureBox.Size = new System.Drawing.Size(57, 50);
            this.fan3_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fan3_pictureBox.TabIndex = 20;
            this.fan3_pictureBox.TabStop = false;
            this.fan3_pictureBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(693, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Obsluga pojawiających się awarii";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1504, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fan3_pictureBox);
            this.Controls.Add(this.fan2_pictureBox);
            this.Controls.Add(this.fan1_pictureBox);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.fan3_button);
            this.Controls.Add(this.fan2_button);
            this.Controls.Add(this.fan1_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.predkosc_label);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.awaria_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Linia produkcyjna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fan1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fan2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fan3_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label awaria_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label predkosc_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button fan1_button;
        private System.Windows.Forms.Button fan2_button;
        private System.Windows.Forms.Button fan3_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox info_textBox;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox fan1_pictureBox;
        private System.Windows.Forms.PictureBox fan2_pictureBox;
        private System.Windows.Forms.PictureBox fan3_pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer4;
    }
}