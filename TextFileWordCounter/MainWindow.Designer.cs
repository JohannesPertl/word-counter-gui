namespace TextFileWordCounter
{
    partial class MainWindow
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
            this.btnCount = new System.Windows.Forms.Button();
            this.btnFileInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbort = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelFile = new System.Windows.Forms.Label();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChoosenFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.LightGray;
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCount.ForeColor = System.Drawing.Color.Black;
            this.btnCount.Location = new System.Drawing.Point(232, 172);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(185, 45);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Wörter zählen";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Visible = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnFileInput
            // 
            this.btnFileInput.BackColor = System.Drawing.Color.LightGray;
            this.btnFileInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFileInput.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFileInput.FlatAppearance.BorderSize = 3;
            this.btnFileInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnFileInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnFileInput.ForeColor = System.Drawing.Color.Black;
            this.btnFileInput.Location = new System.Drawing.Point(232, 172);
            this.btnFileInput.Name = "btnFileInput";
            this.btnFileInput.Size = new System.Drawing.Size(187, 47);
            this.btnFileInput.TabIndex = 2;
            this.btnFileInput.Text = "Datei auswählen";
            this.btnFileInput.UseVisualStyleBackColor = false;
            this.btnFileInput.Visible = false;
            this.btnFileInput.Click += new System.EventHandler(this.btnFileInput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAbort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbort.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAbort.ForeColor = System.Drawing.Color.White;
            this.btnAbort.Location = new System.Drawing.Point(260, 312);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(135, 33);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "ABBRUCH";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(178, 250);
            this.progressBar1.MarqueeAnimationSpeed = 35;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(289, 29);
            this.progressBar1.Step = 7;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // labelFile
            // 
            this.labelFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelFile.ForeColor = System.Drawing.Color.Black;
            this.labelFile.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelFile.Location = new System.Drawing.Point(350, 142);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(215, 18);
            this.labelFile.TabIndex = 12;
            this.labelFile.Text = "txt.tx";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFile.Visible = false;
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnNewFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNewFile.ForeColor = System.Drawing.Color.White;
            this.btnNewFile.Location = new System.Drawing.Point(230, 285);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(187, 43);
            this.btnNewFile.TabIndex = 9;
            this.btnNewFile.Text = "neue Datei";
            this.btnNewFile.UseVisualStyleBackColor = false;
            this.btnNewFile.Visible = false;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // labelInProgress
            // 
            this.labelInProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelInProgress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelInProgress.Location = new System.Drawing.Point(178, 231);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(289, 24);
            this.labelInProgress.TabIndex = 10;
            this.labelInProgress.Text = "Wörter werden gezählt...";
            this.labelInProgress.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 65);
            this.label1.TabIndex = 11;
            this.label1.Text = "WORT ZÄHLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChoosenFile
            // 
            this.labelChoosenFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelChoosenFile.ForeColor = System.Drawing.Color.LightGray;
            this.labelChoosenFile.Location = new System.Drawing.Point(232, 142);
            this.labelChoosenFile.Name = "labelChoosenFile";
            this.labelChoosenFile.Size = new System.Drawing.Size(112, 27);
            this.labelChoosenFile.TabIndex = 12;
            this.labelChoosenFile.Text = "Gewählte Datei:";
            this.labelChoosenFile.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(658, 412);
            this.Controls.Add(this.labelChoosenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnFileInput);
            this.Controls.Add(this.btnCount);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindow";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnFileInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelInProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChoosenFile;
    }
}