namespace SoXo
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
            this.components = new System.ComponentModel.Container();
            this.panDoMin = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btStart = new System.Windows.Forms.Button();
            this.rdCap1 = new System.Windows.Forms.RadioButton();
            this.rdCap2 = new System.Windows.Forms.RadioButton();
            this.rdCap3 = new System.Windows.Forms.RadioButton();
            this.rdCap4 = new System.Windows.Forms.RadioButton();
            this.rdCap5 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panDoMin
            // 
            this.panDoMin.Location = new System.Drawing.Point(12, 42);
            this.panDoMin.Name = "panDoMin";
            this.panDoMin.Size = new System.Drawing.Size(545, 514);
            this.panDoMin.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.saveScoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewGame.Size = new System.Drawing.Size(246, 30);
            this.NewGame.Text = "New Game";
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // saveScoreToolStripMenuItem
            // 
            this.saveScoreToolStripMenuItem.Name = "saveScoreToolStripMenuItem";
            this.saveScoreToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.saveScoreToolStripMenuItem.Text = "Save Score";
            this.saveScoreToolStripMenuItem.Click += new System.EventHandler(this.saveScoreToolStripMenuItem_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(611, 329);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(130, 45);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start Game";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // rdCap1
            // 
            this.rdCap1.AutoSize = true;
            this.rdCap1.Location = new System.Drawing.Point(615, 116);
            this.rdCap1.Name = "rdCap1";
            this.rdCap1.Size = new System.Drawing.Size(76, 24);
            this.rdCap1.TabIndex = 4;
            this.rdCap1.TabStop = true;
            this.rdCap1.Text = "Cấp 1";
            this.rdCap1.UseVisualStyleBackColor = true;
            // 
            // rdCap2
            // 
            this.rdCap2.AutoSize = true;
            this.rdCap2.Location = new System.Drawing.Point(615, 157);
            this.rdCap2.Name = "rdCap2";
            this.rdCap2.Size = new System.Drawing.Size(76, 24);
            this.rdCap2.TabIndex = 4;
            this.rdCap2.TabStop = true;
            this.rdCap2.Text = "Cấp 2";
            this.rdCap2.UseVisualStyleBackColor = true;
            // 
            // rdCap3
            // 
            this.rdCap3.AutoSize = true;
            this.rdCap3.Location = new System.Drawing.Point(615, 199);
            this.rdCap3.Name = "rdCap3";
            this.rdCap3.Size = new System.Drawing.Size(76, 24);
            this.rdCap3.TabIndex = 4;
            this.rdCap3.TabStop = true;
            this.rdCap3.Text = "Cấp 3";
            this.rdCap3.UseVisualStyleBackColor = true;
            // 
            // rdCap4
            // 
            this.rdCap4.AutoSize = true;
            this.rdCap4.Location = new System.Drawing.Point(615, 242);
            this.rdCap4.Name = "rdCap4";
            this.rdCap4.Size = new System.Drawing.Size(80, 24);
            this.rdCap4.TabIndex = 4;
            this.rdCap4.TabStop = true;
            this.rdCap4.Text = "Cấp 4 ";
            this.rdCap4.UseVisualStyleBackColor = true;
            // 
            // rdCap5
            // 
            this.rdCap5.AutoSize = true;
            this.rdCap5.Location = new System.Drawing.Point(615, 284);
            this.rdCap5.Name = "rdCap5";
            this.rdCap5.Size = new System.Drawing.Size(76, 24);
            this.rdCap5.TabIndex = 4;
            this.rdCap5.TabStop = true;
            this.rdCap5.Text = "Cấp 5";
            this.rdCap5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(318, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdCap5);
            this.Controls.Add(this.rdCap4);
            this.Controls.Add(this.rdCap3);
            this.Controls.Add(this.rdCap2);
            this.Controls.Add(this.rdCap1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.panDoMin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panDoMin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.RadioButton rdCap1;
        private System.Windows.Forms.RadioButton rdCap2;
        private System.Windows.Forms.RadioButton rdCap3;
        private System.Windows.Forms.RadioButton rdCap4;
        private System.Windows.Forms.RadioButton rdCap5;
        private System.Windows.Forms.ToolStripMenuItem saveScoreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

