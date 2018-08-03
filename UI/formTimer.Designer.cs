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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTimer));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.tblPanelTimer = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tblPnlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtonsFooter = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tblpnlTopo = new System.Windows.Forms.TableLayoutPanel();
            this.lblX = new System.Windows.Forms.Label();
            this.lblNameOne = new System.Windows.Forms.Label();
            this.lblNameTwo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.tblPanelTimer.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tblPnlFooter.SuspendLayout();
            this.pnlButtonsFooter.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tblpnlTopo.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1008, 729);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.tblPanelTimer);
            this.pnlTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimer.Location = new System.Drawing.Point(0, 109);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(1008, 449);
            this.pnlTimer.TabIndex = 2;
            // 
            // tblPanelTimer
            // 
            this.tblPanelTimer.ColumnCount = 3;
            this.tblPanelTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tblPanelTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelTimer.Controls.Add(this.lblTimer, 1, 0);
            this.tblPanelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelTimer.Location = new System.Drawing.Point(0, 0);
            this.tblPanelTimer.Name = "tblPanelTimer";
            this.tblPanelTimer.RowCount = 1;
            this.tblPanelTimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelTimer.Size = new System.Drawing.Size(1008, 449);
            this.tblPanelTimer.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(207, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Padding = new System.Windows.Forms.Padding(50, 150, 0, 0);
            this.lblTimer.Size = new System.Drawing.Size(594, 449);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.tblPnlFooter);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 558);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1008, 171);
            this.pnlBottom.TabIndex = 1;
            // 
            // tblPnlFooter
            // 
            this.tblPnlFooter.ColumnCount = 3;
            this.tblPnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tblPnlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlFooter.Controls.Add(this.pnlButtonsFooter, 1, 0);
            this.tblPnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlFooter.Location = new System.Drawing.Point(0, 0);
            this.tblPnlFooter.Name = "tblPnlFooter";
            this.tblPnlFooter.RowCount = 1;
            this.tblPnlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlFooter.Size = new System.Drawing.Size(1008, 171);
            this.tblPnlFooter.TabIndex = 2;
            // 
            // pnlButtonsFooter
            // 
            this.pnlButtonsFooter.Controls.Add(this.btnReset);
            this.pnlButtonsFooter.Controls.Add(this.btnStop);
            this.pnlButtonsFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonsFooter.Location = new System.Drawing.Point(207, 3);
            this.pnlButtonsFooter.Name = "pnlButtonsFooter";
            this.pnlButtonsFooter.Size = new System.Drawing.Size(594, 165);
            this.pnlButtonsFooter.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageKey = "ico_reset.png";
            this.btnReset.ImageList = this.imageList1;
            this.btnReset.Location = new System.Drawing.Point(361, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 107);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reiniciar (Esc)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ico_play.png");
            this.imageList1.Images.SetKeyName(1, "ico_stop.png");
            this.imageList1.Images.SetKeyName(2, "ico_reset.png");
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ImageKey = "ico_play.png";
            this.btnStop.ImageList = this.imageList1;
            this.btnStop.Location = new System.Drawing.Point(38, 36);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(195, 107);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Iniciar (Espaço)";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tblpnlTopo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1008, 109);
            this.pnlTop.TabIndex = 0;
            // 
            // tblpnlTopo
            // 
            this.tblpnlTopo.ColumnCount = 3;
            this.tblpnlTopo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlTopo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblpnlTopo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlTopo.Controls.Add(this.lblX, 1, 0);
            this.tblpnlTopo.Controls.Add(this.lblNameOne, 0, 0);
            this.tblpnlTopo.Controls.Add(this.lblNameTwo, 2, 0);
            this.tblpnlTopo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlTopo.Location = new System.Drawing.Point(0, 0);
            this.tblpnlTopo.Name = "tblpnlTopo";
            this.tblpnlTopo.RowCount = 1;
            this.tblpnlTopo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlTopo.Size = new System.Drawing.Size(1008, 109);
            this.tblpnlTopo.TabIndex = 0;
            // 
            // lblX
            // 
            this.lblX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(457, 0);
            this.lblX.Name = "lblX";
            this.lblX.Padding = new System.Windows.Forms.Padding(20, 25, 0, 0);
            this.lblX.Size = new System.Drawing.Size(94, 109);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblNameOne
            // 
            this.lblNameOne.AutoSize = true;
            this.lblNameOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOne.Location = new System.Drawing.Point(3, 0);
            this.lblNameOne.Name = "lblNameOne";
            this.lblNameOne.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblNameOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameOne.Size = new System.Drawing.Size(448, 109);
            this.lblNameOne.TabIndex = 0;
            this.lblNameOne.Text = "...";
            // 
            // lblNameTwo
            // 
            this.lblNameTwo.AutoSize = true;
            this.lblNameTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTwo.Location = new System.Drawing.Point(557, 0);
            this.lblNameTwo.Name = "lblNameTwo";
            this.lblNameTwo.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblNameTwo.Size = new System.Drawing.Size(448, 109);
            this.lblNameTwo.TabIndex = 0;
            this.lblNameTwo.Text = "...";
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
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formTimer";
            this.Text = "Cronômetro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formTimer_KeyPress);
            this.pnlMain.ResumeLayout(false);
            this.pnlTimer.ResumeLayout(false);
            this.tblPanelTimer.ResumeLayout(false);
            this.tblPanelTimer.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.tblPnlFooter.ResumeLayout(false);
            this.pnlButtonsFooter.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tblpnlTopo.ResumeLayout(false);
            this.tblpnlTopo.PerformLayout();
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
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblNameOne;
        private System.Windows.Forms.Label lblNameTwo;
        private System.Windows.Forms.TableLayoutPanel tblpnlTopo;
        private System.Windows.Forms.TableLayoutPanel tblPanelTimer;
        private System.Windows.Forms.TableLayoutPanel tblPnlFooter;
        private System.Windows.Forms.Panel pnlButtonsFooter;
        private System.Windows.Forms.ImageList imageList1;
    }
}