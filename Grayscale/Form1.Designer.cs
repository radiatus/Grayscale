namespace Grayscale
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BrightL = new System.Windows.Forms.Label();
            this.trackBright = new System.Windows.Forms.TrackBar();
            this.Grayscale = new System.Windows.Forms.Label();
            this.checkGrayscale = new System.Windows.Forms.CheckBox();
            this.Render = new System.Windows.Forms.Button();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.ContrastL = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.Gl = new System.Windows.Forms.Label();
            this.trackR = new System.Windows.Forms.TrackBar();
            this.Rl = new System.Windows.Forms.Label();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.Bl = new System.Windows.Forms.Label();
            this.checkBenchmark = new System.Windows.Forms.CheckBox();
            this.BenchmarkL = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(253, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(253, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(103, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrightL
            // 
            this.BrightL.AutoSize = true;
            this.BrightL.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightL.Location = new System.Drawing.Point(11, 68);
            this.BrightL.Name = "BrightL";
            this.BrightL.Size = new System.Drawing.Size(68, 25);
            this.BrightL.TabIndex = 3;
            this.BrightL.Text = "Bright";
            // 
            // trackBright
            // 
            this.trackBright.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackBright.Location = new System.Drawing.Point(0, 97);
            this.trackBright.Maximum = 99;
            this.trackBright.Minimum = -99;
            this.trackBright.Name = "trackBright";
            this.trackBright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBright.Size = new System.Drawing.Size(251, 45);
            this.trackBright.TabIndex = 4;
            this.trackBright.TickFrequency = 5;
            this.trackBright.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Grayscale
            // 
            this.Grayscale.AutoSize = true;
            this.Grayscale.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grayscale.Location = new System.Drawing.Point(12, 445);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(96, 25);
            this.Grayscale.TabIndex = 11;
            this.Grayscale.Text = "Grayscale";
            // 
            // checkGrayscale
            // 
            this.checkGrayscale.AutoSize = true;
            this.checkGrayscale.Location = new System.Drawing.Point(17, 473);
            this.checkGrayscale.Name = "checkGrayscale";
            this.checkGrayscale.Size = new System.Drawing.Size(44, 17);
            this.checkGrayscale.TabIndex = 12;
            this.checkGrayscale.Text = "Yes";
            this.checkGrayscale.UseVisualStyleBackColor = true;
            // 
            // Render
            // 
            this.Render.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Render.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Render.Location = new System.Drawing.Point(16, 28);
            this.Render.Name = "Render";
            this.Render.Size = new System.Drawing.Size(228, 37);
            this.Render.TabIndex = 13;
            this.Render.Text = "Render";
            this.Render.UseVisualStyleBackColor = false;
            this.Render.Click += new System.EventHandler(this.Render_Click);
            // 
            // trackContrast
            // 
            this.trackContrast.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackContrast.Location = new System.Drawing.Point(0, 173);
            this.trackContrast.Maximum = 99;
            this.trackContrast.Minimum = -99;
            this.trackContrast.Name = "trackContrast";
            this.trackContrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackContrast.Size = new System.Drawing.Size(251, 45);
            this.trackContrast.TabIndex = 15;
            this.trackContrast.TickFrequency = 5;
            this.trackContrast.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // ContrastL
            // 
            this.ContrastL.AutoSize = true;
            this.ContrastL.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastL.Location = new System.Drawing.Point(11, 145);
            this.ContrastL.Name = "ContrastL";
            this.ContrastL.Size = new System.Drawing.Size(89, 25);
            this.ContrastL.TabIndex = 14;
            this.ContrastL.Text = "Contrast";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(12, 664);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(228, 37);
            this.Reset.TabIndex = 16;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // trackG
            // 
            this.trackG.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackG.Location = new System.Drawing.Point(1, 326);
            this.trackG.Maximum = 99;
            this.trackG.Minimum = -99;
            this.trackG.Name = "trackG";
            this.trackG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackG.Size = new System.Drawing.Size(251, 45);
            this.trackG.TabIndex = 20;
            this.trackG.TickFrequency = 5;
            this.trackG.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Gl
            // 
            this.Gl.AutoSize = true;
            this.Gl.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gl.Location = new System.Drawing.Point(12, 298);
            this.Gl.Name = "Gl";
            this.Gl.Size = new System.Drawing.Size(27, 25);
            this.Gl.TabIndex = 19;
            this.Gl.Text = "G";
            // 
            // trackR
            // 
            this.trackR.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackR.Location = new System.Drawing.Point(1, 250);
            this.trackR.Maximum = 99;
            this.trackR.Minimum = -99;
            this.trackR.Name = "trackR";
            this.trackR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackR.Size = new System.Drawing.Size(251, 45);
            this.trackR.TabIndex = 18;
            this.trackR.TickFrequency = 5;
            this.trackR.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Rl
            // 
            this.Rl.AutoSize = true;
            this.Rl.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rl.Location = new System.Drawing.Point(12, 221);
            this.Rl.Name = "Rl";
            this.Rl.Size = new System.Drawing.Size(25, 25);
            this.Rl.TabIndex = 17;
            this.Rl.Text = "R";
            // 
            // trackB
            // 
            this.trackB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackB.Location = new System.Drawing.Point(1, 397);
            this.trackB.Maximum = 99;
            this.trackB.Minimum = -99;
            this.trackB.Name = "trackB";
            this.trackB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackB.Size = new System.Drawing.Size(251, 45);
            this.trackB.TabIndex = 22;
            this.trackB.TickFrequency = 5;
            this.trackB.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Bl
            // 
            this.Bl.AutoSize = true;
            this.Bl.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bl.Location = new System.Drawing.Point(12, 369);
            this.Bl.Name = "Bl";
            this.Bl.Size = new System.Drawing.Size(25, 25);
            this.Bl.TabIndex = 21;
            this.Bl.Text = "B";
            // 
            // checkBenchmark
            // 
            this.checkBenchmark.AutoSize = true;
            this.checkBenchmark.Checked = true;
            this.checkBenchmark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBenchmark.Location = new System.Drawing.Point(16, 521);
            this.checkBenchmark.Name = "checkBenchmark";
            this.checkBenchmark.Size = new System.Drawing.Size(44, 17);
            this.checkBenchmark.TabIndex = 24;
            this.checkBenchmark.Text = "Yes";
            this.checkBenchmark.UseVisualStyleBackColor = true;
            // 
            // BenchmarkL
            // 
            this.BenchmarkL.AutoSize = true;
            this.BenchmarkL.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenchmarkL.Location = new System.Drawing.Point(11, 493);
            this.BenchmarkL.Name = "BenchmarkL";
            this.BenchmarkL.Size = new System.Drawing.Size(113, 25);
            this.BenchmarkL.TabIndex = 23;
            this.BenchmarkL.Text = "Benchmark";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 628);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(228, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(851, 713);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBenchmark);
            this.Controls.Add(this.BenchmarkL);
            this.Controls.Add(this.trackB);
            this.Controls.Add(this.Bl);
            this.Controls.Add(this.trackG);
            this.Controls.Add(this.Gl);
            this.Controls.Add(this.trackR);
            this.Controls.Add(this.Rl);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.trackContrast);
            this.Controls.Add(this.ContrastL);
            this.Controls.Add(this.Render);
            this.Controls.Add(this.checkGrayscale);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.trackBright);
            this.Controls.Add(this.BrightL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(867, 752);
            this.MinimumSize = new System.Drawing.Size(867, 752);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grayscale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label BrightL;
        private System.Windows.Forms.TrackBar trackBright;
        private System.Windows.Forms.Label Grayscale;
        private System.Windows.Forms.CheckBox checkGrayscale;
        private System.Windows.Forms.Button Render;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.Label ContrastL;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TrackBar trackG;
        private System.Windows.Forms.Label Gl;
        private System.Windows.Forms.TrackBar trackR;
        private System.Windows.Forms.Label Rl;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.Label Bl;
        private System.Windows.Forms.CheckBox checkBenchmark;
        private System.Windows.Forms.Label BenchmarkL;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

