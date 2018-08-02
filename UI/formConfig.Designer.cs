namespace CapoeiraTimer.UI
{
    partial class formConfig
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameTwo = new System.Windows.Forms.TextBox();
            this.txtNameOne = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Controls.Add(this.txtSeconds);
            this.pnlMain.Controls.Add(this.lblSeconds);
            this.pnlMain.Controls.Add(this.lblMinutes);
            this.pnlMain.Controls.Add(this.txtMinutes);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtNameTwo);
            this.pnlMain.Controls.Add(this.txtNameOne);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(381, 196);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pnlConfirm);
            this.pnlButtons.Controls.Add(this.pnlCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 157);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(381, 39);
            this.pnlButtons.TabIndex = 8;
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.Controls.Add(this.btnConfirm);
            this.pnlConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfirm.Location = new System.Drawing.Point(191, 0);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(95, 39);
            this.pnlConfirm.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Location = new System.Drawing.Point(0, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 39);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Iniciar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlCancel
            // 
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCancel.Location = new System.Drawing.Point(286, 0);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pnlCancel.Size = new System.Drawing.Size(95, 39);
            this.pnlCancel.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(2, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 39);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSeconds
            // 
            this.txtSeconds.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSeconds.Location = new System.Drawing.Point(62, 114);
            this.txtSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(53, 20);
            this.txtSeconds.TabIndex = 7;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(59, 98);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(55, 13);
            this.lblSeconds.TabIndex = 6;
            this.lblSeconds.Text = "Segundos";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(3, 98);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutos";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(3, 114);
            this.txtMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(53, 20);
            this.txtMinutes.TabIndex = 4;
            this.txtMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome 1";
            // 
            // txtNameTwo
            // 
            this.txtNameTwo.Location = new System.Drawing.Point(3, 64);
            this.txtNameTwo.Name = "txtNameTwo";
            this.txtNameTwo.Size = new System.Drawing.Size(371, 20);
            this.txtNameTwo.TabIndex = 1;
            // 
            // txtNameOne
            // 
            this.txtNameOne.Location = new System.Drawing.Point(3, 25);
            this.txtNameOne.Name = "txtNameOne";
            this.txtNameOne.Size = new System.Drawing.Size(371, 20);
            this.txtNameOne.TabIndex = 0;
            // 
            // formConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 196);
            this.Controls.Add(this.pnlMain);
            this.Name = "formConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlConfirm.ResumeLayout(false);
            this.pnlCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.NumericUpDown txtSeconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown txtMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameTwo;
        private System.Windows.Forms.TextBox txtNameOne;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Button btnCancel;
    }
}