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
            this.shopkeeper = new System.Windows.Forms.PictureBox();
            this.shopkeepersound = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shopkeeper)).BeginInit();
            this.SuspendLayout();
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
            // shopkeepersound
            // 
            this.shopkeepersound.Enabled = true;
            this.shopkeepersound.Interval = 500;
            this.shopkeepersound.Tick += new System.EventHandler(this.shopkeepersound_Tick);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 797);
            this.Controls.Add(this.shopkeeper);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.shopkeeper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox shopkeeper;
        private System.Windows.Forms.Timer shopkeepersound;
    }
}