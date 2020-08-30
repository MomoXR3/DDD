namespace DDD
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.specialE = new System.Windows.Forms.ProgressBar();
            this.special = new System.Windows.Forms.ProgressBar();
            this.dungeonprogress = new System.Windows.Forms.ProgressBar();
            this.attack = new System.Windows.Forms.Button();
            this.magic = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.healthE = new System.Windows.Forms.ProgressBar();
            this.health = new System.Windows.Forms.ProgressBar();
            this.spells = new System.Windows.Forms.GroupBox();
            this.tier3 = new System.Windows.Forms.Label();
            this.tier2 = new System.Windows.Forms.Label();
            this.tier1 = new System.Windows.Forms.Label();
            this.imprison = new System.Windows.Forms.Button();
            this.shield = new System.Windows.Forms.Button();
            this.apotheosis = new System.Windows.Forms.Button();
            this.sanctuary = new System.Windows.Forms.Button();
            this.devastation = new System.Windows.Forms.Button();
            this.cure = new System.Windows.Forms.Button();
            this.heal = new System.Windows.Forms.Button();
            this.poison = new System.Windows.Forms.Button();
            this.vengeance = new System.Windows.Forms.Button();
            this.freeze = new System.Windows.Forms.Button();
            this.lightning = new System.Windows.Forms.Button();
            this.fireball = new System.Windows.Forms.Button();
            this.character = new System.Windows.Forms.Button();
            this.characterbox = new System.Windows.Forms.GroupBox();
            this.defencebox = new System.Windows.Forms.TextBox();
            this.magicbox = new System.Windows.Forms.TextBox();
            this.attackbox = new System.Windows.Forms.TextBox();
            this.skills = new System.Windows.Forms.Label();
            this.defenseskill = new System.Windows.Forms.Label();
            this.magicskill = new System.Windows.Forms.Label();
            this.attackskill = new System.Windows.Forms.Label();
            this.xpbox = new System.Windows.Forms.TextBox();
            this.xp = new System.Windows.Forms.Label();
            this.levelbox = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.Label();
            this.hpe = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.neu = new System.Windows.Forms.Button();
            this.shop = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventarbox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dinge = new System.Windows.Forms.Button();
            this.rüstung = new System.Windows.Forms.Button();
            this.waffen = new System.Windows.Forms.Button();
            this.Attacktimer = new System.Windows.Forms.Timer(this.components);
            this.inventorytimer = new System.Windows.Forms.Timer(this.components);
            this.spells.SuspendLayout();
            this.characterbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inventarbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(-977, 17);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(296, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // specialE
            // 
            this.specialE.Location = new System.Drawing.Point(1093, 108);
            this.specialE.Name = "specialE";
            this.specialE.Size = new System.Drawing.Size(296, 23);
            this.specialE.TabIndex = 2;
            this.specialE.Value = 100;
            // 
            // special
            // 
            this.special.Location = new System.Drawing.Point(58, 108);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(296, 23);
            this.special.TabIndex = 2;
            this.special.Value = 100;
            // 
            // dungeonprogress
            // 
            this.dungeonprogress.Location = new System.Drawing.Point(376, 162);
            this.dungeonprogress.Name = "dungeonprogress";
            this.dungeonprogress.Size = new System.Drawing.Size(698, 50);
            this.dungeonprogress.TabIndex = 4;
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(58, 609);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(296, 41);
            this.attack.TabIndex = 5;
            this.attack.Text = "Attack";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // magic
            // 
            this.magic.Location = new System.Drawing.Point(58, 656);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(296, 41);
            this.magic.TabIndex = 5;
            this.magic.Text = "Magic";
            this.magic.UseVisualStyleBackColor = true;
            this.magic.Click += new System.EventHandler(this.magic_Click);
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(58, 703);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(296, 41);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // healthE
            // 
            this.healthE.BackColor = System.Drawing.SystemColors.ControlText;
            this.healthE.Cursor = System.Windows.Forms.Cursors.No;
            this.healthE.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DDD.Properties.Settings.Default, "HPE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.healthE.Location = new System.Drawing.Point(1093, 63);
            this.healthE.Name = "healthE";
            this.healthE.Size = new System.Drawing.Size(296, 23);
            this.healthE.TabIndex = 2;
            this.healthE.Value = global::DDD.Properties.Settings.Default.HPE;
            // 
            // health
            // 
            this.health.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DDD.Properties.Settings.Default, "HP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.health.Location = new System.Drawing.Point(58, 63);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(296, 23);
            this.health.TabIndex = 1;
            this.health.Value = global::DDD.Properties.Settings.Default.HP;
            // 
            // spells
            // 
            this.spells.Controls.Add(this.tier3);
            this.spells.Controls.Add(this.tier2);
            this.spells.Controls.Add(this.tier1);
            this.spells.Controls.Add(this.imprison);
            this.spells.Controls.Add(this.shield);
            this.spells.Controls.Add(this.apotheosis);
            this.spells.Controls.Add(this.sanctuary);
            this.spells.Controls.Add(this.devastation);
            this.spells.Controls.Add(this.cure);
            this.spells.Controls.Add(this.heal);
            this.spells.Controls.Add(this.poison);
            this.spells.Controls.Add(this.vengeance);
            this.spells.Controls.Add(this.freeze);
            this.spells.Controls.Add(this.lightning);
            this.spells.Controls.Add(this.fireball);
            this.spells.Location = new System.Drawing.Point(376, 606);
            this.spells.Name = "spells";
            this.spells.Size = new System.Drawing.Size(426, 201);
            this.spells.TabIndex = 6;
            this.spells.TabStop = false;
            this.spells.Text = "Spells";
            this.spells.Visible = false;
            // 
            // tier3
            // 
            this.tier3.AutoSize = true;
            this.tier3.Location = new System.Drawing.Point(320, 16);
            this.tier3.Name = "tier3";
            this.tier3.Size = new System.Drawing.Size(34, 13);
            this.tier3.TabIndex = 1;
            this.tier3.Text = "Tier 3";
            // 
            // tier2
            // 
            this.tier2.AutoSize = true;
            this.tier2.Location = new System.Drawing.Point(186, 16);
            this.tier2.Name = "tier2";
            this.tier2.Size = new System.Drawing.Size(34, 13);
            this.tier2.TabIndex = 1;
            this.tier2.Text = "Tier 2";
            // 
            // tier1
            // 
            this.tier1.AutoSize = true;
            this.tier1.Location = new System.Drawing.Point(50, 16);
            this.tier1.Name = "tier1";
            this.tier1.Size = new System.Drawing.Size(34, 13);
            this.tier1.TabIndex = 1;
            this.tier1.Text = "Tier 1";
            // 
            // imprison
            // 
            this.imprison.Location = new System.Drawing.Point(148, 154);
            this.imprison.Name = "imprison";
            this.imprison.Size = new System.Drawing.Size(127, 34);
            this.imprison.TabIndex = 0;
            this.imprison.Text = "Imprison";
            this.imprison.UseVisualStyleBackColor = true;
            // 
            // shield
            // 
            this.shield.Location = new System.Drawing.Point(15, 154);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(127, 34);
            this.shield.TabIndex = 0;
            this.shield.Text = "Shield";
            this.shield.UseVisualStyleBackColor = true;
            // 
            // apotheosis
            // 
            this.apotheosis.Location = new System.Drawing.Point(281, 154);
            this.apotheosis.Name = "apotheosis";
            this.apotheosis.Size = new System.Drawing.Size(127, 34);
            this.apotheosis.TabIndex = 0;
            this.apotheosis.Text = "Apotheosis";
            this.apotheosis.UseVisualStyleBackColor = true;
            // 
            // sanctuary
            // 
            this.sanctuary.Location = new System.Drawing.Point(281, 114);
            this.sanctuary.Name = "sanctuary";
            this.sanctuary.Size = new System.Drawing.Size(127, 34);
            this.sanctuary.TabIndex = 0;
            this.sanctuary.Text = "Sanctuary";
            this.sanctuary.UseVisualStyleBackColor = true;
            // 
            // devastation
            // 
            this.devastation.Location = new System.Drawing.Point(281, 74);
            this.devastation.Name = "devastation";
            this.devastation.Size = new System.Drawing.Size(127, 34);
            this.devastation.TabIndex = 0;
            this.devastation.Text = "Devastation";
            this.devastation.UseVisualStyleBackColor = true;
            // 
            // cure
            // 
            this.cure.Location = new System.Drawing.Point(148, 114);
            this.cure.Name = "cure";
            this.cure.Size = new System.Drawing.Size(127, 34);
            this.cure.TabIndex = 0;
            this.cure.Text = "Cure Poison";
            this.cure.UseVisualStyleBackColor = true;
            // 
            // heal
            // 
            this.heal.Location = new System.Drawing.Point(15, 114);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(127, 34);
            this.heal.TabIndex = 0;
            this.heal.Text = "Heal";
            this.heal.UseVisualStyleBackColor = true;
            // 
            // poison
            // 
            this.poison.Location = new System.Drawing.Point(148, 33);
            this.poison.Name = "poison";
            this.poison.Size = new System.Drawing.Size(127, 34);
            this.poison.TabIndex = 0;
            this.poison.Text = "Poison";
            this.poison.UseVisualStyleBackColor = true;
            // 
            // vengeance
            // 
            this.vengeance.Location = new System.Drawing.Point(281, 33);
            this.vengeance.Name = "vengeance";
            this.vengeance.Size = new System.Drawing.Size(127, 34);
            this.vengeance.TabIndex = 0;
            this.vengeance.Text = "Vengeance";
            this.vengeance.UseVisualStyleBackColor = true;
            // 
            // freeze
            // 
            this.freeze.Location = new System.Drawing.Point(148, 74);
            this.freeze.Name = "freeze";
            this.freeze.Size = new System.Drawing.Size(127, 34);
            this.freeze.TabIndex = 0;
            this.freeze.Text = "Freeze";
            this.freeze.UseVisualStyleBackColor = true;
            // 
            // lightning
            // 
            this.lightning.Location = new System.Drawing.Point(15, 74);
            this.lightning.Name = "lightning";
            this.lightning.Size = new System.Drawing.Size(127, 34);
            this.lightning.TabIndex = 0;
            this.lightning.Text = "Lightningstrike";
            this.lightning.UseVisualStyleBackColor = true;
            // 
            // fireball
            // 
            this.fireball.Location = new System.Drawing.Point(15, 33);
            this.fireball.Name = "fireball";
            this.fireball.Size = new System.Drawing.Size(127, 34);
            this.fireball.TabIndex = 0;
            this.fireball.Text = "Fireball";
            this.fireball.UseVisualStyleBackColor = true;
            // 
            // character
            // 
            this.character.Location = new System.Drawing.Point(58, 750);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(296, 41);
            this.character.TabIndex = 5;
            this.character.Text = "Character";
            this.character.UseVisualStyleBackColor = true;
            this.character.Click += new System.EventHandler(this.character_Click);
            // 
            // characterbox
            // 
            this.characterbox.Controls.Add(this.defencebox);
            this.characterbox.Controls.Add(this.magicbox);
            this.characterbox.Controls.Add(this.attackbox);
            this.characterbox.Controls.Add(this.skills);
            this.characterbox.Controls.Add(this.defenseskill);
            this.characterbox.Controls.Add(this.magicskill);
            this.characterbox.Controls.Add(this.attackskill);
            this.characterbox.Controls.Add(this.xpbox);
            this.characterbox.Controls.Add(this.xp);
            this.characterbox.Controls.Add(this.levelbox);
            this.characterbox.Controls.Add(this.level);
            this.characterbox.Location = new System.Drawing.Point(849, 609);
            this.characterbox.Name = "characterbox";
            this.characterbox.Size = new System.Drawing.Size(414, 198);
            this.characterbox.TabIndex = 7;
            this.characterbox.TabStop = false;
            this.characterbox.Text = "Character";
            this.characterbox.Visible = false;
            // 
            // defencebox
            // 
            this.defencebox.Cursor = System.Windows.Forms.Cursors.Default;
            this.defencebox.Location = new System.Drawing.Point(68, 159);
            this.defencebox.Name = "defencebox";
            this.defencebox.ReadOnly = true;
            this.defencebox.Size = new System.Drawing.Size(19, 20);
            this.defencebox.TabIndex = 8;
            this.defencebox.Text = "1";
            // 
            // magicbox
            // 
            this.magicbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.magicbox.Location = new System.Drawing.Point(68, 133);
            this.magicbox.Name = "magicbox";
            this.magicbox.ReadOnly = true;
            this.magicbox.Size = new System.Drawing.Size(19, 20);
            this.magicbox.TabIndex = 8;
            this.magicbox.Text = "1";
            this.magicbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // attackbox
            // 
            this.attackbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.attackbox.Location = new System.Drawing.Point(68, 108);
            this.attackbox.Name = "attackbox";
            this.attackbox.ReadOnly = true;
            this.attackbox.Size = new System.Drawing.Size(19, 20);
            this.attackbox.TabIndex = 8;
            this.attackbox.Text = "1";
            this.attackbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // skills
            // 
            this.skills.AutoSize = true;
            this.skills.Location = new System.Drawing.Point(14, 82);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(31, 13);
            this.skills.TabIndex = 7;
            this.skills.Text = "Skills";
            // 
            // defenseskill
            // 
            this.defenseskill.AutoSize = true;
            this.defenseskill.Location = new System.Drawing.Point(14, 162);
            this.defenseskill.Name = "defenseskill";
            this.defenseskill.Size = new System.Drawing.Size(48, 13);
            this.defenseskill.TabIndex = 6;
            this.defenseskill.Text = "Defence";
            // 
            // magicskill
            // 
            this.magicskill.AutoSize = true;
            this.magicskill.Location = new System.Drawing.Point(14, 136);
            this.magicskill.Name = "magicskill";
            this.magicskill.Size = new System.Drawing.Size(36, 13);
            this.magicskill.TabIndex = 5;
            this.magicskill.Text = "Magic";
            // 
            // attackskill
            // 
            this.attackskill.AutoSize = true;
            this.attackskill.Location = new System.Drawing.Point(14, 111);
            this.attackskill.Name = "attackskill";
            this.attackskill.Size = new System.Drawing.Size(38, 13);
            this.attackskill.TabIndex = 4;
            this.attackskill.Text = "Attack";
            // 
            // xpbox
            // 
            this.xpbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.xpbox.Location = new System.Drawing.Point(53, 48);
            this.xpbox.Name = "xpbox";
            this.xpbox.ReadOnly = true;
            this.xpbox.Size = new System.Drawing.Size(34, 20);
            this.xpbox.TabIndex = 3;
            this.xpbox.Text = "0";
            // 
            // xp
            // 
            this.xp.AutoSize = true;
            this.xp.Location = new System.Drawing.Point(14, 51);
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(21, 13);
            this.xp.TabIndex = 2;
            this.xp.Text = "XP";
            // 
            // levelbox
            // 
            this.levelbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.levelbox.Location = new System.Drawing.Point(53, 26);
            this.levelbox.Name = "levelbox";
            this.levelbox.ReadOnly = true;
            this.levelbox.Size = new System.Drawing.Size(19, 20);
            this.levelbox.TabIndex = 1;
            this.levelbox.Text = "1";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(14, 29);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(33, 13);
            this.level.TabIndex = 0;
            this.level.Text = "Level";
            // 
            // hpe
            // 
            this.hpe.AutoSize = true;
            this.hpe.BackColor = System.Drawing.Color.Red;
            this.hpe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hpe.Location = new System.Drawing.Point(1228, 63);
            this.hpe.Name = "hpe";
            this.hpe.Size = new System.Drawing.Size(22, 13);
            this.hpe.TabIndex = 8;
            this.hpe.Text = "HP";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.BackColor = System.Drawing.Color.Red;
            this.hp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hp.Location = new System.Drawing.Point(182, 63);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(22, 13);
            this.hp.TabIndex = 8;
            this.hp.Text = "HP";
            // 
            // neu
            // 
            this.neu.Location = new System.Drawing.Point(565, 218);
            this.neu.Name = "neu";
            this.neu.Size = new System.Drawing.Size(312, 45);
            this.neu.TabIndex = 9;
            this.neu.Text = "New Dungeon";
            this.neu.UseVisualStyleBackColor = true;
            this.neu.Visible = false;
            // 
            // shop
            // 
            this.shop.Location = new System.Drawing.Point(565, 269);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(312, 48);
            this.shop.TabIndex = 10;
            this.shop.Text = "Shop";
            this.shop.UseVisualStyleBackColor = true;
            this.shop.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DDD.Properties.Resources.Fallout_4_Vault_Boy_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(1093, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 249);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DDD.Properties.Resources.Fallout_4_Vault_Boy_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(58, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 249);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // inventarbox
            // 
            this.inventarbox.Controls.Add(this.listView1);
            this.inventarbox.Controls.Add(this.dinge);
            this.inventarbox.Controls.Add(this.rüstung);
            this.inventarbox.Controls.Add(this.waffen);
            this.inventarbox.Location = new System.Drawing.Point(376, 390);
            this.inventarbox.Name = "inventarbox";
            this.inventarbox.Size = new System.Drawing.Size(425, 188);
            this.inventarbox.TabIndex = 14;
            this.inventarbox.TabStop = false;
            this.inventarbox.Text = "Inventory";
            this.inventarbox.Visible = false;
            this.inventarbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(87, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 155);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dinge
            // 
            this.dinge.Location = new System.Drawing.Point(6, 111);
            this.dinge.Name = "dinge";
            this.dinge.Size = new System.Drawing.Size(61, 27);
            this.dinge.TabIndex = 0;
            this.dinge.Text = "Things";
            this.dinge.UseVisualStyleBackColor = true;
            this.dinge.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // rüstung
            // 
            this.rüstung.Location = new System.Drawing.Point(6, 78);
            this.rüstung.Name = "rüstung";
            this.rüstung.Size = new System.Drawing.Size(61, 27);
            this.rüstung.TabIndex = 0;
            this.rüstung.Text = "Armor";
            this.rüstung.UseVisualStyleBackColor = true;
            this.rüstung.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // waffen
            // 
            this.waffen.Location = new System.Drawing.Point(6, 45);
            this.waffen.Name = "waffen";
            this.waffen.Size = new System.Drawing.Size(61, 27);
            this.waffen.TabIndex = 0;
            this.waffen.Text = "Weapons";
            this.waffen.UseVisualStyleBackColor = true;
            // 
            // Attacktimer
            // 
            this.Attacktimer.Interval = 5000;
            this.Attacktimer.Tick += new System.EventHandler(this.Attacktimer_Tick);
            // 
            // inventorytimer
            // 
            this.inventorytimer.Interval = 1000;
            this.inventorytimer.Tick += new System.EventHandler(this.inventorytimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 819);
            this.Controls.Add(this.inventarbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.neu);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.hpe);
            this.Controls.Add(this.characterbox);
            this.Controls.Add(this.spells);
            this.Controls.Add(this.character);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.magic);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.dungeonprogress);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.special);
            this.Controls.Add(this.specialE);
            this.Controls.Add(this.healthE);
            this.Controls.Add(this.health);
            this.Name = "Form1";
            this.Text = "Form1";
            this.spells.ResumeLayout(false);
            this.spells.PerformLayout();
            this.characterbox.ResumeLayout(false);
            this.characterbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inventarbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar specialE;
        private System.Windows.Forms.ProgressBar special;
        private System.Windows.Forms.ProgressBar dungeonprogress;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button magic;
        private System.Windows.Forms.Button inventory;
        public System.Windows.Forms.ProgressBar health;
        public System.Windows.Forms.ProgressBar healthE;
        private System.Windows.Forms.GroupBox spells;
        private System.Windows.Forms.Button fireball;
        private System.Windows.Forms.Button imprison;
        private System.Windows.Forms.Button shield;
        private System.Windows.Forms.Button apotheosis;
        private System.Windows.Forms.Button sanctuary;
        private System.Windows.Forms.Button devastation;
        private System.Windows.Forms.Button cure;
        private System.Windows.Forms.Button heal;
        private System.Windows.Forms.Button poison;
        private System.Windows.Forms.Button vengeance;
        private System.Windows.Forms.Button freeze;
        private System.Windows.Forms.Button lightning;
        private System.Windows.Forms.Label tier2;
        private System.Windows.Forms.Label tier1;
        private System.Windows.Forms.Label tier3;
        private System.Windows.Forms.Button character;
        private System.Windows.Forms.GroupBox characterbox;
        private System.Windows.Forms.TextBox levelbox;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label xp;
        private System.Windows.Forms.TextBox xpbox;
        private System.Windows.Forms.Label defenseskill;
        private System.Windows.Forms.Label magicskill;
        private System.Windows.Forms.Label attackskill;
        private System.Windows.Forms.TextBox defencebox;
        private System.Windows.Forms.TextBox magicbox;
        private System.Windows.Forms.TextBox attackbox;
        private System.Windows.Forms.Label skills;
        private System.Windows.Forms.Label hpe;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Button neu;
        private System.Windows.Forms.Button shop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox inventarbox;
        private System.Windows.Forms.Button rüstung;
        private System.Windows.Forms.Button waffen;
        private System.Windows.Forms.Button dinge;
        private System.Windows.Forms.Timer Attacktimer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer inventorytimer;
    }
}

