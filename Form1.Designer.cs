namespace Oscillator
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
            this.StartStop = new System.Windows.Forms.Button();
            this.BackgroundThread = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // StartStop
            // 
            this.StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartStop.Location = new System.Drawing.Point(118, 325);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(88, 31);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Пуск";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // BackgroundThread
            // 
            this.BackgroundThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundThread_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.StartStop);
            this.Name = "Form1";
            this.Text = "Осциллятор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartStop;
        private System.ComponentModel.BackgroundWorker BackgroundThread;

    }
}

