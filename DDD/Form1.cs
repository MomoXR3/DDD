using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Drawing.Text;
using System.Media;
using System.Runtime.Remoting.Messaging;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using RandomNumber;


namespace DDD
{
    

    public partial class Form1 : Form
    {
        public sbyte runde = 0;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;


        public Form1()
        {
            InitializeComponent();

        }


        private int LPF = 0;

        private void attack_Click(object sender, EventArgs e)
        {

            string runde2;

            LPF = healthE.Value;
            LPF = LPF - Randomness.getNextInt(1, 30);
            if (LPF < 0)
            {
                LPF = 0;
            }

            healthE.Value = LPF;
            Schlagsound1();

            runde = (sbyte)(runde + 1);
            DDD.Properties.Settings.Default.runde = runde.ToString();
        }






        private void magic_Click(object sender, EventArgs e)
        {
            if (spells.Visible == true)
            {
                Closesound();
                spells.Visible = false;
            }
            else
            {
                Opensound();
                spells.Visible = true;

            }

        }

        private void character_Click(object sender, EventArgs e)
        {
            if (characterbox.Visible == true)
            {
                Closesound();
                characterbox.Visible = false;
            }
            else
            {
                Opensound();
                characterbox.Visible = true;

            }
        }




        private void inventory_Click(object sender, EventArgs e)
        {

            if (inventarbox.Visible == true)
            {
                Closesound();
                inventarbox.Visible = false;
                inventorytimer.Stop();
            }
            else
            {
                Opensound();
                inventarbox.Visible = true;
                inventorytimer.Start();
            }
        }


        private void Attacktimer_Tick(object sender, EventArgs e)
        {
            if (runde < 1)
            {
                attack.Enabled = true;
                yourturn.Visible = true;
                enemyturn.Visible = false;
            }
            else
            {
                attack.Enabled = false;
                enemytimer1.Start();
                yourturn.Visible = false;
                enemyturn.Visible = true;



            }
        }

        private void inventorytimer_Tick(object sender, EventArgs e)
        {
            string ausrüstung;
            ausrüstung = Inventar.Resource1.Schwert;
            ListViewItem ausr = new ListViewItem(ausrüstung);
            bool sword = listView1.Items.Contains(ausr);

            if (sword == false)
            {
                listView1.Items.Add(ausr);
                inventorytimer.Stop();

            }



        }

        private void music_Tick(object sender, EventArgs e)
        {
            if (musicbox.Checked == true)
            {
                test();

            }
            else
            {
                outputDevice?.Stop();

            }
        }

        private void musicbox_CheckedChanged(object sender, EventArgs e)
        {
            music.Start();
        }

        private void hp_Click(object sender, EventArgs e)
        {

        }

        public void methoderunde()
        {
            deathtimer.Start();
            int hp = health.Value;
        LOOP:
            if (runde > 0)
            {
                hp = hp - Randomness.getNextInt(1, 30);
                if (hp < 0)
                {
                    hp = 0;
                }
                Schlagsound2();
                health.Value = hp;
                runde = (sbyte)(runde - 1);
                attack.Enabled = true;
                goto LOOP;
            }
            else
            {
                runde.ToString(DDD.Properties.Settings.Default.runde);
                health.Value = hp;
            }


        }

        private void deathtimer_Tick(object sender, EventArgs e)
        {
            if (health.Value < 1)
            { Deadsound();
                attacktimer.Stop();
                die.Visible = true;
                restart.Visible = true;
                foreach (Control c in Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = false;
                    }
                    restart.Enabled = true;
                    deathtimer.Stop();

                }

            }
        }

        private void restart_Click(object sender, EventArgs e)
        { Respawnsound();
            health.Value = 100;
            healthE.Value = 100;
            levelxp = 20000;
            levelbox.Text = 1.ToString();
            xpbox.Text = 0.ToString();
            nextlevelxp.Text = levelxp.ToString();
            dungeonprogress.Value = 0;
            attacktimer.Start();
            die.Visible = false;
            restart.Visible = false;
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                }
                restart.Enabled = false;
                deathtimer.Start();

            }
        }

        private void Schlagsound1()
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Schlag 1.wav";
            player.Load();
            player.Play();

        }

        private void Schlagsound2()
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Schlag 2.wav";
            player.Load();
            player.Play();

        }

        private void Opensound()
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Open.wav";
            player.Play();

        }


        private void Closesound()
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Close.wav";
            player.Load();
            player.Play();

        }






        private void Respawnsound()
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Respawn.wav";
            player.Load();
            player.Play();

        }


        private void Deadsound()
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Dead.wav";
            player.Load();
            player.Play();

        }




        private void Music()
        {

            System.Media.SoundPlayer musicplayer =
            new System.Media.SoundPlayer();

            if (musicbox.Checked == true)
            {
                musicplayer.SoundLocation = @"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Walking in the Air.wav";
                musicplayer.Play();
                music.Stop();
            }
            else
            {
                music.Start();
                musicplayer.Stop();

            }
        }




        private void enemytimer1_Tick(object sender, EventArgs e)
        {
            methoderunde();
            enemytimer1.Stop();
        }



        private void test()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                //outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"D:\Programmieren\Microsoft Visual Studio\DDD\DDD\Sound\Walking in the Air.wav");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deathtimerE_Tick(object sender, EventArgs e)
        {
            if (healthE.Value < 1)
            {
                enemytimer1.Stop();
                runde = 0;
                int ep = Convert.ToInt32(xpbox.Text) + Randomness.getNextInt(1000, 10000);
                xpbox.Text = ep.ToString();
                leveltimer.Start();
                int random;
                random = Randomness.getNextInt(1, 50);
                int dp = dungeonprogress.Value;
                dp = dungeonprogress.Value + random;
                if(dp > 100)
                {
                    dp = 100;
                }
                dungeonprogress.Value = dp;
                healthE.Value = 100;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int levelxp = 20000;
        
        private void leveltimer_Tick(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(xpbox.Text) >= levelxp)
            {
                nextlevel();
                leveltimer.Stop();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            healthE.Value = 0;
        }


        private void nextlevel()
        {
            int skillvariable = Convert.ToInt32(skillpointsbox.Text);
           
            int lb = Convert.ToInt32(levelbox.Text);
            lb = lb + 1;
            levelbox.Text = lb.ToString();
            levelxp = levelxp + levelxp;
            levelxp = levelxp + Randomness.getNextInt(2000, 6000);
            nextlevelxp.Text = levelxp.ToString();
            skillvariable = skillvariable + 1;
            skillpointsbox.Text = skillvariable.ToString();
            leveltimer.Start();
        }

        private void skillpointstimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(skillpointsbox.Text) > 0)
            {
                skillpointstimer.Stop();
                defenseplus.Enabled = true;
                attackplus.Enabled = true;
                magicplus.Enabled = true;
                skillpointstimer.Start();
            }


            else
            {
                skillpointstimer.Stop();
                defenseplus.Enabled = false;
                attackplus.Enabled = false;
                magicplus.Enabled = false;
                skillpointstimer.Start();
            }
        }


        private void attackplus_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(attackbox.Text);
            int spb = Convert.ToInt32(skillpointsbox.Text);
            ab = ab + 1;
            spb = spb - 1;
            attackbox.Text = ab.ToString();
            skillpointsbox.Text = spb.ToString();
        }

        private void magicplus_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(magicbox.Text);
            int spb = Convert.ToInt32(skillpointsbox.Text);
            ab = ab + 1;
            spb = spb - 1;
            magicbox.Text = ab.ToString();
            skillpointsbox.Text = spb.ToString();

        }

        private void defenseplus_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(defencebox.Text);
            int spb = Convert.ToInt32(skillpointsbox.Text);
            ab = ab + 1;
            spb = spb - 1;
            defencebox.Text = ab.ToString();
            skillpointsbox.Text = spb.ToString();

        }

 



    }
            
        
        






}


