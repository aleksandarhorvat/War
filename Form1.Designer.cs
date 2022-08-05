namespace War
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMyCard = new System.Windows.Forms.PictureBox();
            this.btDraw = new System.Windows.Forms.Button();
            this.pbHisCard = new System.Windows.Forms.PictureBox();
            this.btAgain = new System.Windows.Forms.Button();
            this.pbDeck1 = new System.Windows.Forms.PictureBox();
            this.pbDeck2 = new System.Windows.Forms.PictureBox();
            this.lbPoints2 = new System.Windows.Forms.Label();
            this.lbPoints1 = new System.Windows.Forms.Label();
            this.btShuffle = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHisCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMyCard
            // 
            this.pbMyCard.Location = new System.Drawing.Point(216, 337);
            this.pbMyCard.Margin = new System.Windows.Forms.Padding(4);
            this.pbMyCard.Name = "pbMyCard";
            this.pbMyCard.Size = new System.Drawing.Size(177, 250);
            this.pbMyCard.TabIndex = 0;
            this.pbMyCard.TabStop = false;
            // 
            // btDraw
            // 
            this.btDraw.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDraw.Location = new System.Drawing.Point(239, 301);
            this.btDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(129, 28);
            this.btDraw.TabIndex = 1;
            this.btDraw.Text = "Draw the Card";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // pbHisCard
            // 
            this.pbHisCard.Location = new System.Drawing.Point(216, 44);
            this.pbHisCard.Margin = new System.Windows.Forms.Padding(4);
            this.pbHisCard.Name = "pbHisCard";
            this.pbHisCard.Size = new System.Drawing.Size(177, 250);
            this.pbHisCard.TabIndex = 2;
            this.pbHisCard.TabStop = false;
            // 
            // btAgain
            // 
            this.btAgain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAgain.Location = new System.Drawing.Point(239, 301);
            this.btAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(129, 28);
            this.btAgain.TabIndex = 3;
            this.btAgain.Text = "Play Again";
            this.btAgain.UseVisualStyleBackColor = true;
            this.btAgain.Click += new System.EventHandler(this.btAgain_Click);
            // 
            // pbDeck1
            // 
            this.pbDeck1.Image = global::War.Properties.Resources.yellow_back;
            this.pbDeck1.Location = new System.Drawing.Point(16, 337);
            this.pbDeck1.Margin = new System.Windows.Forms.Padding(4);
            this.pbDeck1.Name = "pbDeck1";
            this.pbDeck1.Size = new System.Drawing.Size(177, 250);
            this.pbDeck1.TabIndex = 5;
            this.pbDeck1.TabStop = false;
            // 
            // pbDeck2
            // 
            this.pbDeck2.Image = global::War.Properties.Resources.red_back;
            this.pbDeck2.Location = new System.Drawing.Point(16, 44);
            this.pbDeck2.Margin = new System.Windows.Forms.Padding(4);
            this.pbDeck2.Name = "pbDeck2";
            this.pbDeck2.Size = new System.Drawing.Size(177, 250);
            this.pbDeck2.TabIndex = 6;
            this.pbDeck2.TabStop = false;
            // 
            // lbPoints2
            // 
            this.lbPoints2.AutoSize = true;
            this.lbPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoints2.Location = new System.Drawing.Point(412, 101);
            this.lbPoints2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPoints2.Name = "lbPoints2";
            this.lbPoints2.Size = new System.Drawing.Size(0, 135);
            this.lbPoints2.TabIndex = 7;
            // 
            // lbPoints1
            // 
            this.lbPoints1.AutoSize = true;
            this.lbPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoints1.Location = new System.Drawing.Point(412, 414);
            this.lbPoints1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPoints1.Name = "lbPoints1";
            this.lbPoints1.Size = new System.Drawing.Size(0, 135);
            this.lbPoints1.TabIndex = 8;
            // 
            // btShuffle
            // 
            this.btShuffle.AutoSize = true;
            this.btShuffle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btShuffle.Location = new System.Drawing.Point(38, 301);
            this.btShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btShuffle.Name = "btShuffle";
            this.btShuffle.Size = new System.Drawing.Size(132, 28);
            this.btShuffle.TabIndex = 9;
            this.btShuffle.Text = "Shuffle the cards";
            this.btShuffle.UseVisualStyleBackColor = true;
            this.btShuffle.Click += new System.EventHandler(this.btShuffle_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(401, 302);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 25);
            this.lbResult.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 26);
            this.toolStripMenuItem2.Text = "v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(627, 594);
            this.Controls.Add(this.btAgain);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btShuffle);
            this.Controls.Add(this.lbPoints1);
            this.Controls.Add(this.lbPoints2);
            this.Controls.Add(this.pbDeck2);
            this.Controls.Add(this.pbDeck1);
            this.Controls.Add(this.pbHisCard);
            this.Controls.Add(this.pbMyCard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(645, 641);
            this.MinimumSize = new System.Drawing.Size(645, 641);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbMyCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHisCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMyCard;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.PictureBox pbHisCard;
        private System.Windows.Forms.Button btAgain;
        private System.Windows.Forms.PictureBox pbDeck1;
        private System.Windows.Forms.PictureBox pbDeck2;
        private System.Windows.Forms.Label lbPoints2;
        private System.Windows.Forms.Label lbPoints1;
        private System.Windows.Forms.Button btShuffle;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

