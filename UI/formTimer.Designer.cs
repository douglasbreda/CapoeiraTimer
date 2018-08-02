namespace CapoeiraTimer.UI
{
    partial class formTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNameTwo = new System.Windows.Forms.Label();
            this.pnlNameOne = new System.Windows.Forms.Panel();
            this.lblNameOne = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlDivisor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlNameOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlTimer);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(866, 497);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimer.Location = new System.Drawing.Point(0, 54);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(866, 289);
            this.pnlTimer.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(269, 77);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(339, 128);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnReset);
            this.pnlBottom.Controls.Add(this.btnStop);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 343);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(866, 154);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(447, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 76);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reiniciar (Esc)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(280, 40);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 76);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Iniciar (Enter)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlDivisor);
            this.pnlTop.Controls.Add(this.panel2);
            this.pnlTop.Controls.Add(this.pnlNameOne);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(866, 54);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.Controls.Add(this.lblX);
            this.pnlDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDivisor.Location = new System.Drawing.Point(380, 0);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(106, 54);
            this.pnlDivisor.TabIndex = 3;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(36, 10);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(32, 31);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNameTwo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(486, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 54);
            this.panel2.TabIndex = 2;
            // 
            // lblNameTwo
            // 
            this.lblNameTwo.AutoSize = true;
            this.lblNameTwo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTwo.Location = new System.Drawing.Point(0, 0);
            this.lblNameTwo.Name = "lblNameTwo";
            this.lblNameTwo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNameTwo.Size = new System.Drawing.Size(38, 41);
            this.lblNameTwo.TabIndex = 0;
            this.lblNameTwo.Text = "...";
            // 
            // pnlNameOne
            // 
            this.pnlNameOne.Controls.Add(this.lblNameOne);
            this.pnlNameOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNameOne.Location = new System.Drawing.Point(0, 0);
            this.pnlNameOne.Name = "pnlNameOne";
            this.pnlNameOne.Size = new System.Drawing.Size(380, 54);
            this.pnlNameOne.TabIndex = 0;
            // 
            // lblNameOne
            // 
            this.lblNameOne.AutoSize = true;
            this.lblNameOne.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOne.Location = new System.Drawing.Point(342, 0);
            this.lblNameOne.Name = "lblNameOne";
            this.lblNameOne.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNameOne.Size = new System.Drawing.Size(38, 41);
            this.lblNameOne.TabIndex = 0;
            this.lblNameOne.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 497);
            this.Controls.Add(this.pnlMain);
            this.Name = "formTimer";
            this.Text = "Cronômetro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlDivisor.ResumeLayout(false);
            this.pnlDivisor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlNameOne.ResumeLayout(false);
            this.pnlNameOne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNameTwo;
        private System.Windows.Forms.Panel pnlNameOne;
        private System.Windows.Forms.Label lblNameOne;
    }
}