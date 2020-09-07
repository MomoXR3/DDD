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
            LPF = LPF - 30;
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
            }
            else
            {
                attack.Enabled = false;
                enemytimer1.Start();




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
                hp = hp - 30;
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

        private void MusicWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            test();
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
    }
            
        
        






}


