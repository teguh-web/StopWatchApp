namespace website_stopwatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            startBTN = new Button();
            stopBTN = new Button();
            resetBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 22);
            label1.Name = "label1";
            label1.Size = new Size(636, 136);
            label1.TabIndex = 0;
            label1.Text = "00:00:00:00";
            label1.Click += label1_Click;
            // 
            // startBTN
            // 
            startBTN.BackColor = Color.FromArgb(0, 205, 151);
            startBTN.FlatStyle = FlatStyle.Popup;
            startBTN.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            startBTN.ForeColor = Color.White;
            startBTN.Location = new Point(70, 201);
            startBTN.Name = "startBTN";
            startBTN.Size = new Size(160, 60);
            startBTN.TabIndex = 1;
            startBTN.Text = "Start";
            startBTN.UseVisualStyleBackColor = false;
            startBTN.Click += startBTN_Click;
            // 
            // stopBTN
            // 
            stopBTN.BackColor = Color.FromArgb(247, 86, 91);
            stopBTN.FlatStyle = FlatStyle.Popup;
            stopBTN.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            stopBTN.ForeColor = Color.White;
            stopBTN.Location = new Point(314, 201);
            stopBTN.Name = "stopBTN";
            stopBTN.Size = new Size(160, 60);
            stopBTN.TabIndex = 2;
            stopBTN.Text = "Stop";
            stopBTN.UseVisualStyleBackColor = false;
            stopBTN.Click += stopBTN_Click;
            // 
            // resetBTN
            // 
            resetBTN.BackColor = Color.FromArgb(25, 130, 196);
            resetBTN.FlatStyle = FlatStyle.Popup;
            resetBTN.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            resetBTN.ForeColor = Color.White;
            resetBTN.Location = new Point(546, 201);
            resetBTN.Name = "resetBTN";
            resetBTN.Size = new Size(160, 60);
            resetBTN.TabIndex = 3;
            resetBTN.Text = "Reset";
            resetBTN.UseVisualStyleBackColor = false;
            resetBTN.Click += resetBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(786, 300);
            Controls.Add(resetBTN);
            Controls.Add(stopBTN);
            Controls.Add(startBTN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startBTN;
        private Button stopBTN;
        private Button resetBTN;
    }
}
