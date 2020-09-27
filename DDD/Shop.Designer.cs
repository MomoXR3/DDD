namespace DDD
{
    partial class Shop
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
            this.shopkeepersound = new System.Windows.Forms.Timer(this.components);
            this.HPS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HPM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HPB = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gold = new System.Windows.Forms.Label();
            this.goldbox = new System.Windows.Forms.Label();
            this.hpscounter = new System.Windows.Forms.Label();
            this.hpmcounter = new System.Windows.Forms.Label();
            this.hpbcounter = new System.Windows.Forms.Label();
            this.shopkeeper = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.synctimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shopkeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // shopkeepersound
            // 
            this.shopkeepersound.Interval = 500;
            this.shopkeepersound.Tick += new System.EventHandler(this.shopkeepersound_Tick);
            // 
            // HPS
            // 
            this.HPS.Location = new System.Drawing.Point(426, 101);
            this.HPS.Name = "HPS";
            this.HPS.Size = new System.Drawing.Size(112, 61);
            this.HPS.TabIndex = 1;
            this.HPS.Text = "HealthPotionSmall";
            this.HPS.UseVisualStyleBackColor = true;
            this.HPS.Click += new System.EventHandler(this.HPS_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // HPM
            // 
            this.HPM.Location = new System.Drawing.Point(426, 168);
            this.HPM.Name = "HPM";
            this.HPM.Size = new System.Drawing.Size(112, 61);
            this.HPM.TabIndex = 1;
            this.HPM.Text = "HealthPotionMiddle";
            this.HPM.UseVisualStyleBackColor = true;
            this.HPM.Click += new System.EventHandler(this.HPM_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 61);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // HPB
            // 
            this.HPB.Location = new System.Drawing.Point(426, 235);
            this.HPB.Name = "HPB";
            this.HPB.Size = new System.Drawing.Size(112, 61);
            this.HPB.TabIndex = 1;
            this.HPB.Text = "HealthPotionBig";
            this.HPB.UseVisualStyleBackColor = true;
            this.HPB.Click += new System.EventHandler(this.HPB_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(572, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 61);
            this.button6.TabIndex = 1;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // gold
            // 
            this.gold.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold.Location = new System.Drawing.Point(6, 363);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(72, 34);
            this.gold.TabIndex = 2;
            this.gold.Text = "Gold";
            this.gold.Click += new System.EventHandler(this.gold_Click);
            // 
            // goldbox
            // 
            this.goldbox.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldbox.Location = new System.Drawing.Point(84, 363);
            this.goldbox.Name = "goldbox";
            this.goldbox.Size = new System.Drawing.Size(276, 34);
            this.goldbox.TabIndex = 2;
            this.goldbox.Text = "0";
            // 
            // hpscounter
            // 
            this.hpscounter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hpscounter.Location = new System.Drawing.Point(486, 141);
            this.hpscounter.Name = "hpscounter";
            this.hpscounter.Size = new System.Drawing.Size(52, 21);
            this.hpscounter.TabIndex = 3;
            this.hpscounter.Text = "5";
            // 
            // hpmcounter
            // 
            this.hpmcounter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hpmcounter.Location = new System.Drawing.Point(486, 208);
            this.hpmcounter.Name = "hpmcounter";
            this.hpmcounter.Size = new System.Drawing.Size(52, 21);
            this.hpmcounter.TabIndex = 3;
            this.hpmcounter.Text = "2";
            // 
            // hpbcounter
            // 
            this.hpbcounter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hpbcounter.Location = new System.Drawing.Point(486, 275);
            this.hpbcounter.Name = "hpbcounter";
            this.hpbcounter.Size = new System.Drawing.Size(52, 21);
            this.hpbcounter.TabIndex = 3;
            this.hpbcounter.Text = "1";
            // 
            // shopkeeper
            // 
            this.shopkeeper.Image = global::DDD.Properties.Resources.CnQUhPw;
            this.shopkeeper.Location = new System.Drawing.Point(12, 12);
            this.shopkeeper.Name = "shopkeeper";
            this.shopkeeper.Size = new System.Drawing.Size(332, 332);
            this.shopkeeper.TabIndex = 0;
            this.shopkeeper.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shop";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(684, 746);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 39);
            this.close.TabIndex = 5;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // synctimer
            // 
            this.synctimer.Enabled = true;
            this.synctimer.Tick += new System.EventHandler(this.synctimer_Tick);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 797);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hpbcounter);
            this.Controls.Add(this.hpmcounter);
            this.Controls.Add(this.hpscounter);
            this.Controls.Add(this.goldbox);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.HPB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.HPM);
            this.Controls.Add(this.HPS);
            this.Controls.Add(this.shopkeeper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Shop_Load);
            this.Shown += new System.EventHandler(this.Shop_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.shopkeeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shopkeeper;
        private System.Windows.Forms.Timer shopkeepersound;
        private System.Windows.Forms.Button HPS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button HPM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button HPB;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label goldbox;
        private System.Windows.Forms.Label gold;
        private System.Windows.Forms.Label hpscounter;
        private System.Windows.Forms.Label hpmcounter;
        private System.Windows.Forms.Label hpbcounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Timer synctimer;
    }
}