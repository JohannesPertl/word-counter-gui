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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.btnCount.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (112)))), ((int) (((byte) (112)))), ((int) (((byte) (112)))));
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.FlatAppearance.BorderSize = 0;
            this.btnCount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCount.ForeColor = System.Drawing.Color.White;
            this.btnCount.Location = new System.Drawing.Point(199, 149);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(159, 39);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Wörter zählen";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Visible = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnFileInput
            // 
            this.btnFileInput.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (112)))), ((int) (((byte) (112)))), ((int) (((byte) (112)))));
            this.btnFileInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileInput.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFileInput.FlatAppearance.BorderSize = 0;
            this.btnFileInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btnFileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileInput.Font = new System.Drawing.Font("HelveticaNeueLT Com 55 Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnFileInput.ForeColor = System.Drawing.Color.White;
            this.btnFileInput.Location = new System.Drawing.Point(199, 147);
            this.btnFileInput.Name = "btnFileInput";
            this.btnFileInput.Size = new System.Drawing.Size(160, 41);
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
            this.btnAbort.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (112)))), ((int) (((byte) (112)))), ((int) (((byte) (112)))));
            this.btnAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbort.FlatAppearance.BorderSize = 0;
            this.btnAbort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.Font = new System.Drawing.Font("HelveticaNeueLT Com 55 Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAbort.ForeColor = System.Drawing.Color.White;
            this.btnAbort.Location = new System.Drawing.Point(223, 270);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(116, 29);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "ABBRUCH";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(153, 217);
            this.progressBar1.MarqueeAnimationSpeed = 35;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 25);
            this.progressBar1.Step = 7;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // labelFile
            // 
            this.labelFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFile.Font = new System.Drawing.Font("Helvetica Neue", 9F);
            this.labelFile.ForeColor = System.Drawing.Color.Black;
            this.labelFile.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelFile.Location = new System.Drawing.Point(306, 123);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(184, 16);
            this.labelFile.TabIndex = 12;
            this.labelFile.Text = "txt.txt";
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFile.Visible = false;
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (112)))), ((int) (((byte) (112)))), ((int) (((byte) (112)))));
            this.btnNewFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.Font = new System.Drawing.Font("HelveticaNeueLT Com 55 Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNewFile.ForeColor = System.Drawing.Color.White;
            this.btnNewFile.Location = new System.Drawing.Point(223, 238);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(116, 36);
            this.btnNewFile.TabIndex = 9;
            this.btnNewFile.Text = "Andere Datei";
            this.btnNewFile.UseVisualStyleBackColor = false;
            this.btnNewFile.Visible = false;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // labelInProgress
            // 
            this.labelInProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelInProgress.Font = new System.Drawing.Font("Helvetica Neue", 9.75F);
            this.labelInProgress.Location = new System.Drawing.Point(153, 200);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(248, 21);
            this.labelInProgress.TabIndex = 10;
            this.labelInProgress.Text = "Wörter werden gezählt...";
            this.labelInProgress.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (204)))), ((int) (((byte) (204)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Com 95 Blk", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "WORT ZÄHLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelChoosenFile
            // 
            this.labelChoosenFile.Font = new System.Drawing.Font("Helvetica Neue", 9.75F);
            this.labelChoosenFile.ForeColor = System.Drawing.Color.Black;
            this.labelChoosenFile.Location = new System.Drawing.Point(199, 123);
            this.labelChoosenFile.Name = "labelChoosenFile";
            this.labelChoosenFile.Size = new System.Drawing.Size(101, 23);
            this.labelChoosenFile.TabIndex = 12;
            this.labelChoosenFile.Text = "Gewählte Datei:";
            this.labelChoosenFile.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 357);
            this.Controls.Add(this.labelChoosenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnFileInput);
            this.Controls.Add(this.btnCount);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
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