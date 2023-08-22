namespace Operation_Storm.FormKD
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerdown = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logupdate = new System.Windows.Forms.TextBox();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(901, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Loading);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 600);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerInterval
            // 
            this.TimerInterval.Location = new System.Drawing.Point(670, 609);
            this.TimerInterval.Name = "TimerInterval";
            this.TimerInterval.Size = new System.Drawing.Size(45, 20);
            this.TimerInterval.TabIndex = 2;
            this.TimerInterval.Text = "60";
            this.TimerInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerInterval_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer Interval (Min)";
            // 
            // timerdown
            // 
            this.timerdown.AutoSize = true;
            this.timerdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerdown.Location = new System.Drawing.Point(591, 605);
            this.timerdown.Name = "timerdown";
            this.timerdown.Size = new System.Drawing.Size(64, 24);
            this.timerdown.TabIndex = 4;
            this.timerdown.Text = "Timer";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(901, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Manual_Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ManualClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(918, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // logupdate
            // 
            this.logupdate.Location = new System.Drawing.Point(21, 78);
            this.logupdate.Multiline = true;
            this.logupdate.Name = "logupdate";
            this.logupdate.Size = new System.Drawing.Size(313, 499);
            this.logupdate.TabIndex = 7;
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonStop.Location = new System.Drawing.Point(901, 564);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(234, 76);
            this.ButtonStop.TabIndex = 8;
            this.ButtonStop.Text = "STOP";
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Visible = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.Location = new System.Drawing.Point(943, 322);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(24, 20);
            this.labelresult.TabIndex = 9;
            this.labelresult.Text = "...";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 652);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.logupdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timerdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerInterval);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1182, 691);
            this.MinimumSize = new System.Drawing.Size(1182, 691);
            this.Name = "BaseForm";
            this.Text = "OP_Data (PO Assy/Inspection Team 1)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TimerInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timerdown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox logupdate;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label labelresult;
    }
}