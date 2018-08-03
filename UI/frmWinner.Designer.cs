namespace CapoeiraTimer.UI
{
    partial class frmWinner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWinner));
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.tblTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.tblPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayerTwo = new System.Windows.Forms.Button();
            this.btnPlayerOne = new System.Windows.Forms.Button();
            this.pnlLabel.SuspendLayout();
            this.tblTitle.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            this.tblPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabel
            // 
            this.pnlLabel.Controls.Add(this.tblTitle);
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLabel.Location = new System.Drawing.Point(0, 0);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(800, 65);
            this.pnlLabel.TabIndex = 0;
            // 
            // tblTitle
            // 
            this.tblTitle.ColumnCount = 3;
            this.tblTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tblTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTitle.Controls.Add(this.lblTitle, 1, 0);
            this.tblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTitle.Location = new System.Drawing.Point(0, 0);
            this.tblTitle.Name = "tblTitle";
            this.tblTitle.RowCount = 1;
            this.tblTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTitle.Size = new System.Drawing.Size(800, 65);
            this.tblTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(195, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quem ganhou?";
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.Controls.Add(this.tblPlayers);
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlayers.Location = new System.Drawing.Point(0, 65);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(800, 103);
            this.pnlPlayers.TabIndex = 1;
            // 
            // tblPlayers
            // 
            this.tblPlayers.ColumnCount = 2;
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayers.Controls.Add(this.btnPlayerTwo, 1, 0);
            this.tblPlayers.Controls.Add(this.btnPlayerOne, 0, 0);
            this.tblPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayers.Location = new System.Drawing.Point(0, 0);
            this.tblPlayers.Name = "tblPlayers";
            this.tblPlayers.RowCount = 1;
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayers.Size = new System.Drawing.Size(800, 103);
            this.tblPlayers.TabIndex = 0;
            // 
            // btnPlayerTwo
            // 
            this.btnPlayerTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerTwo.Location = new System.Drawing.Point(403, 3);
            this.btnPlayerTwo.Name = "btnPlayerTwo";
            this.btnPlayerTwo.Size = new System.Drawing.Size(394, 97);
            this.btnPlayerTwo.TabIndex = 1;
            this.btnPlayerTwo.Text = "...";
            this.btnPlayerTwo.UseVisualStyleBackColor = true;
            this.btnPlayerTwo.Click += new System.EventHandler(this.btnPlayerTwo_Click);
            // 
            // btnPlayerOne
            // 
            this.btnPlayerOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerOne.Location = new System.Drawing.Point(3, 3);
            this.btnPlayerOne.Name = "btnPlayerOne";
            this.btnPlayerOne.Size = new System.Drawing.Size(394, 97);
            this.btnPlayerOne.TabIndex = 0;
            this.btnPlayerOne.Text = "...";
            this.btnPlayerOne.UseVisualStyleBackColor = true;
            this.btnPlayerOne.Click += new System.EventHandler(this.btnPlayerOne_Click);
            // 
            // frmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 168);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.pnlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 207);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 207);
            this.Name = "frmWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ganhador";
            this.Load += new System.EventHandler(this.frmWinner_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWinner_KeyPress);
            this.pnlLabel.ResumeLayout(false);
            this.tblTitle.ResumeLayout(false);
            this.tblTitle.PerformLayout();
            this.pnlPlayers.ResumeLayout(false);
            this.tblPlayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.TableLayoutPanel tblTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.TableLayoutPanel tblPlayers;
        private System.Windows.Forms.Button btnPlayerTwo;
        private System.Windows.Forms.Button btnPlayerOne;
    }
}