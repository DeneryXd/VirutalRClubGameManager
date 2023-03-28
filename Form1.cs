using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GameManager
{
    public partial class Form1 : Form
    {
        string AW1 = "192.168.50.225:5555";
        string AW2 = "192.168.50.172:5555";
        string AW3 = "192.168.50.205:5555";
        string AW4 = "192.168.50.226:5555";
        string AW5 = "192.168.50.253:5555";
        string AW6 = "192.168.50.167:5555";
        string AW7 = "192.168.50.251:5555";
        string AW8 = "192.168.50.202:5555";
        string Game1 = "com.owlchemylabs.jobsimulator/com.unity3d.player.UnityPlayerActivity";
        string Game2 = "com.HomeNetGames.WW1oculus/com.unity3d.player.UnityPlayerActivity";
        string Game3 = "com.resolutiongames.abvriop.santacruz/com.unity3d.player.UnityPlayerActivity";
        string Game4 = "unity.SUPERHOT_Team.SUPERHOT_VR_QA/com.unity3d.player.UnityPlayerActivity";
        string Game5 = "com.freelives.gorn/com.unity3d.player.UnityPlayerActivity";
        string Game6 = "com.halfbrick.fruitninjavr/com.unity3d.player.UnityPlayerActivity";
        string Game7 = "com.survios.Creed/com.epicgames.ue4.GameActivity";
        string Game8 = "com.WenklyStudio.ElvenAssassin/com.unity3d.player.UnityPlayerActivity";
        string Game9 = "com.beatgames.beatsaber/com.unity3d.player.UnityPlayerActivity";
        string Game10 = "com.cloudheadgames.pistolwhip/com.unity3d.player.UnityPlayerActivity";
        string Game11;
        string selectedGame;
        string selectedOculus;
        string selectedOculusGuardian;



        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("AW1");
            comboBox1.Items.Add("AW2");
            comboBox1.Items.Add("AW3");
            comboBox1.Items.Add("AW4");
            comboBox1.Items.Add("AW5");
            comboBox1.Items.Add("AW6");
            comboBox1.Items.Add("AW7");
            comboBox1.Items.Add("AW8");
            comboBox3.Items.Add("AW1");
            comboBox3.Items.Add("AW2");
            comboBox3.Items.Add("AW3");
            comboBox3.Items.Add("AW4");
            comboBox3.Items.Add("AW5");
            comboBox3.Items.Add("AW6");
            comboBox3.Items.Add("AW7");
            comboBox3.Items.Add("AW8");
            comboBox2.Items.Add("JobSimulator");
            comboBox2.Items.Add("WarPlanes");
            comboBox2.Items.Add("AngryBirds");
            comboBox2.Items.Add("SUPERHOT");
            comboBox2.Items.Add("GORN");
            comboBox2.Items.Add("Creed");
            comboBox2.Items.Add("FruitNinja");
            comboBox2.Items.Add("ElvenAssassin");
            comboBox2.Items.Add("BeatSaber");
            comboBox2.Items.Add("PistolWhip");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            startButton.Click += new System.EventHandler(this.startButton_Click);
            On.Click += new System.EventHandler(this.On_Click);
            Off.Click += new System.EventHandler(this.Off_Click_1);



        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOculus = comboBox1.SelectedItem.ToString();
            
        }
        void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOculusGuardian = comboBox3.SelectedItem.ToString();

        }
        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGame = comboBox2.SelectedItem.ToString();

            if(selectedGame == "JobSimulator")
            {
                selectedGame = Game1;
            }
            else if (selectedGame == "WarPlanes")
            {
                selectedGame = Game2;
            }
            else if (selectedGame == "AngryBirds")
            {
                selectedGame = Game3;
            }
            else if (selectedGame == "SUPERHOT")
            {
                selectedGame = Game4;
            }
            else if (selectedGame == "GORN")
            {
                selectedGame = Game5;
            }
            else if (selectedGame == "Creed")
            {
                selectedGame = Game7;
            }
            else if (selectedGame == "FruitNinja")
            {
                selectedGame = Game6;
            }
            else if (selectedGame == "ElvenAssassin")
            {
                selectedGame = Game8;
            }
            else if (selectedGame == "BeatSaber")
            {
                selectedGame = Game9;
            }
            else if (selectedGame == "PistolWhip")
            {
                selectedGame = Game10;
            }


        }
        public void startButton_Click(object sender, System.EventArgs e)
        {
            if (selectedOculus == "AW1")
            {
                selectedOculus = AW1;
            }
            else if (selectedOculus == "AW2")
            {
                selectedOculus = AW2;
            }
            else if (selectedOculus == "AW3")
            {
                selectedOculus = AW3;
            }
            else if (selectedOculus == "AW4")
            {
                selectedOculus = AW4;
            }
            else if (selectedOculus == "AW5")
            {
                selectedOculus = AW5;
            }
            else if (selectedOculus == "AW6")
            {
                selectedOculus = AW6;
            }
            else if (selectedOculus == "AW7")
            {
                selectedOculus = AW7;
            }
            else if (selectedOculus == "AW8")
            {
                selectedOculus = AW8;
            }

            ProcessStartInfo cmdStartGame = new ProcessStartInfo();
            cmdStartGame.FileName = @"cmd.exe";
            cmdStartGame.Arguments = $@"/c cd C:\\Another_World\\VR\\AndroidSDK_30.0.5\\platform-tools && adb -s {selectedOculusGuardian} shell am start -S -n {selectedGame}";
            Process.Start(cmdStartGame);
            MessageBox.Show("Игра запущена!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void On_Click(object sender, EventArgs e)
        {
            if (selectedOculusGuardian == "AW1")
            {
                selectedOculusGuardian = AW1;
            }
            else if (selectedOculusGuardian == "AW2")
            {
                selectedOculusGuardian = AW2;
            }
            else if (selectedOculusGuardian == "AW3")
            {
                selectedOculusGuardian = AW3;
            }
            else if (selectedOculusGuardian == "AW4")
            {
                selectedOculusGuardian = AW4;
            }
            else if (selectedOculusGuardian == "AW5")
            {
                selectedOculusGuardian = AW5;
            }
            else if (selectedOculusGuardian == "AW6")
            {
                selectedOculusGuardian = AW6;
            }
            else if (selectedOculusGuardian == "AW7")
            {
                selectedOculusGuardian = AW7;
            }
            else if (selectedOculusGuardian == "AW8")
            {
                selectedOculusGuardian = AW8;
            }
            ProcessStartInfo cmdEnableGuardian = new ProcessStartInfo();
            cmdEnableGuardian.FileName = @"cmd.exe";
            cmdEnableGuardian.Arguments = $@"/c cd C:\\Another_World\\VR\\AndroidSDK_30.0.5\\platform-tools && adb -s {selectedOculusGuardian} shell setprop debug.oculus.guardian_pause 0";
            Process.Start(cmdEnableGuardian);
            
        }

        private void Off_Click_1(object sender, EventArgs e)
        {
            if (selectedOculusGuardian == "AW1")
            {
                selectedOculusGuardian = AW1;
            }
            else if (selectedOculusGuardian == "AW2")
            {
                selectedOculusGuardian = AW2;
            }
            else if (selectedOculusGuardian == "AW3")
            {
                selectedOculusGuardian = AW3;
            }
            else if (selectedOculusGuardian == "AW4")
            {
                selectedOculusGuardian = AW4;
            }
            else if (selectedOculusGuardian == "AW5")
            {
                selectedOculusGuardian = AW5;
            }
            else if (selectedOculusGuardian == "AW6")
            {
                selectedOculusGuardian = AW6;
            }
            else if (selectedOculusGuardian == "AW7")
            {
                selectedOculusGuardian = AW7;
            }
            else if (selectedOculusGuardian == "AW8")
            {
                selectedOculusGuardian = AW8;
            }
            ProcessStartInfo cmdDisableGuardian = new ProcessStartInfo();
            cmdDisableGuardian.FileName = @"cmd.exe";
            cmdDisableGuardian.Arguments = $@"/c cd C:\\Another_World\\VR\\AndroidSDK_30.0.5\\platform-tools && adb -s {selectedOculusGuardian} shell setprop debug.oculus.guardian_pause 1";
            Process.Start(cmdDisableGuardian);
            
        }
    }
}
