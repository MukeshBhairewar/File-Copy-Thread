namespace FileCopy_Thread
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
            this.sourcelabel = new System.Windows.Forms.Label();
            this.destinationlabel = new System.Windows.Forms.Label();
            this.sourcetextbox = new System.Windows.Forms.TextBox();
            this.destinationtextbox = new System.Windows.Forms.TextBox();
            this.sourcebutton = new System.Windows.Forms.Button();
            this.Destinationbutton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bytesshow = new System.Windows.Forms.Label();
            this.timeshow = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourcelabel
            // 
            this.sourcelabel.AutoSize = true;
            this.sourcelabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcelabel.Location = new System.Drawing.Point(34, 48);
            this.sourcelabel.Name = "sourcelabel";
            this.sourcelabel.Size = new System.Drawing.Size(45, 14);
            this.sourcelabel.TabIndex = 0;
            this.sourcelabel.Text = "Source:";
            // 
            // destinationlabel
            // 
            this.destinationlabel.AutoSize = true;
            this.destinationlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationlabel.Location = new System.Drawing.Point(25, 103);
            this.destinationlabel.Name = "destinationlabel";
            this.destinationlabel.Size = new System.Drawing.Size(70, 14);
            this.destinationlabel.TabIndex = 1;
            this.destinationlabel.Text = "Destination:";
            // 
            // sourcetextbox
            // 
            this.sourcetextbox.Location = new System.Drawing.Point(101, 48);
            this.sourcetextbox.Name = "sourcetextbox";
            this.sourcetextbox.Size = new System.Drawing.Size(559, 20);
            this.sourcetextbox.TabIndex = 2;
            // 
            // destinationtextbox
            // 
            this.destinationtextbox.Location = new System.Drawing.Point(101, 103);
            this.destinationtextbox.Name = "destinationtextbox";
            this.destinationtextbox.Size = new System.Drawing.Size(559, 20);
            this.destinationtextbox.TabIndex = 3;
            // 
            // sourcebutton
            // 
            this.sourcebutton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcebutton.Location = new System.Drawing.Point(682, 48);
            this.sourcebutton.Name = "sourcebutton";
            this.sourcebutton.Size = new System.Drawing.Size(61, 20);
            this.sourcebutton.TabIndex = 4;
            this.sourcebutton.Text = "File...";
            this.sourcebutton.UseVisualStyleBackColor = true;
            this.sourcebutton.Click += new System.EventHandler(this.SourceButton);
            // 
            // Destinationbutton
            // 
            this.Destinationbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destinationbutton.Location = new System.Drawing.Point(682, 103);
            this.Destinationbutton.Name = "Destinationbutton";
            this.Destinationbutton.Size = new System.Drawing.Size(61, 20);
            this.Destinationbutton.TabIndex = 5;
            this.Destinationbutton.Text = "Folder...";
            this.Destinationbutton.UseVisualStyleBackColor = true;
            this.Destinationbutton.Click += new System.EventHandler(this.DestinationButton);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(394, 142);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(61, 20);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(238, 142);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(61, 20);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "RemainingTime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "BytesCopied:";
            // 
            // bytesshow
            // 
            this.bytesshow.AutoSize = true;
            this.bytesshow.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bytesshow.Location = new System.Drawing.Point(115, 184);
            this.bytesshow.Name = "bytesshow";
            this.bytesshow.Size = new System.Drawing.Size(19, 14);
            this.bytesshow.TabIndex = 10;
            this.bytesshow.Text = "00";
            // 
            // timeshow
            // 
            this.timeshow.AutoSize = true;
            this.timeshow.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeshow.Location = new System.Drawing.Point(115, 207);
            this.timeshow.Name = "timeshow";
            this.timeshow.Size = new System.Drawing.Size(19, 14);
            this.timeshow.TabIndex = 11;
            this.timeshow.Text = "00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(83, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(607, 24);
            this.progressBar1.TabIndex = 12;
            // 
            // progressStatus
            // 
            this.progressStatus.AutoSize = true;
            this.progressStatus.Location = new System.Drawing.Point(612, 214);
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.Size = new System.Drawing.Size(78, 13);
            this.progressStatus.TabIndex = 13;
            this.progressStatus.Text = "ProgressStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(774, 167);
            this.Controls.Add(this.progressStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.timeshow);
            this.Controls.Add(this.bytesshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Destinationbutton);
            this.Controls.Add(this.sourcebutton);
            this.Controls.Add(this.destinationtextbox);
            this.Controls.Add(this.sourcetextbox);
            this.Controls.Add(this.destinationlabel);
            this.Controls.Add(this.sourcelabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourcelabel;
        private System.Windows.Forms.Label destinationlabel;
        private System.Windows.Forms.TextBox sourcetextbox;
        private System.Windows.Forms.TextBox destinationtextbox;
        private System.Windows.Forms.Button sourcebutton;
        private System.Windows.Forms.Button Destinationbutton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label progressStatus;
        public System.Windows.Forms.Label bytesshow;
        public System.Windows.Forms.Label timeshow;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

