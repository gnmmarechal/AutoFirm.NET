using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFIRM.NET
{
    public partial class Form1 : Form
    {
        public bool detectedNAND = false;
        public bool detectedFIRM104 = false;
        public bool detectedFIRMX = false;
        public bool startok = false;
        public String[] statustext = {"Waiting", "Ready", "Backing up NAND", "Running 3DSFirm.exe", "Running 1st XOR", "Running 2nd XOR", "Running 3rd XOR", "Running 4rth XOR", "Renaming files", "Running 3DSFirm.exe", "Finished!"};
        public int curStatus = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void backupNAND(String path)
        {
            String NAND_backup_name = "NAND_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".bin";
            if (!Directory.Exists("backup")) Directory.CreateDirectory("backup");
            if (!Directory.Exists("backup\\tmp")) Directory.CreateDirectory("backup\\tmp");
            progressBar.PerformStep();
            curStatus = 2;
            File.Copy(path, "backup\\" + NAND_backup_name);
        }
        
        private void run3DSFIRM(int time)
        {
            curStatus++;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
          //  startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "bin\\3DSFirm.exe";
            if (time == 1)
            {
                startInfo.Arguments = "-d " + nandPathTextBox.Text + " backup\\tmp\\firm0.bin backup\\tmp\\firm1.bin >> log.txt";
            }
            else
            {
                startInfo.Arguments = "-i " + nandPathTextBox.Text + " backup\\tmp\\firm0new.bin backup\\tmp\\firm1new.bin >> log.txt";
            }
            process.StartInfo = startInfo;
            process.Start();
            progressBar.PerformStep();
        }

        private void xor(int time, String file1, String file2)
        {
            curStatus++;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "bin\\xor.exe";
            startInfo.Arguments = file1 + " " + file2 + ">> log.txt";
            process.StartInfo = startInfo;
            process.Start();

            progressBar.PerformStep();
        }

        private void renameFiles()
        {
            curStatus++;
            File.Move("backup\\tmp\\firm0.bin.out.out", "backup\\tmp\\firm0new.bin");
            File.Move("backup\\tmp\\firm1.bin.out.out", "backup\\tmp\\firm1new.bin");
            progressBar.PerformStep();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new About();
            aboutForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseNAND = new OpenFileDialog();
            chooseNAND.Filter = "NAND Image | *.bin";
            chooseNAND.ShowDialog();
            nandPathTextBox.Text = chooseNAND.FileName;
            if (File.Exists(nandPathTextBox.Text))
            {
                detectedNAND = true;
            }
            else
            {
                detectedNAND = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "AutoFIRM.NET - v" + Properties.Settings.Default.vString;
            firmComboBox.Text = "11.0.0";
            modelComboBox.Text = "Old 3DS/3DS XL/2DS";


        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checker_Tick(object sender, EventArgs e)
        {
            String firmn = "UNKWN", model = "UKNWN";
            //Set Model/Version
            switch(firmComboBox.Text)
            {
                case "11.0.0":
                    firmn = "110";
                    break;
                case "11.1.0":
                    firmn = "111";
                    break;
                case "11.2.0":
                    firmn = "112";
                    break;
                default:
                    firmComboBox.Text = "11.0.0";
                    break;
            }

            switch (modelComboBox.Text)
            {
                case "Old 3DS/3DS XL/2DS":
                    model = "OLD";
                    break;
                case "New 3DS/3DS XL":
                    model = "NEW";
                    break;
                default:
                    modelComboBox.Text = "Old 3DS/3DS XL/2DS";
                    break;
            }

            String firmxpath = "firmwares\\firm" + firmn + "_" + model + ".bin", firm104path = "firmwares\\firm104_" + model + ".bin";
            firm104TextBox.Text = firm104path;
            firmxTextBox.Text = firmxpath;
            //Check for FIRMs

            if (File.Exists(firmxpath))
            {
                detectedFIRMX = true;
            }
            else
            {
                detectedFIRMX = false;
            }
            if (File.Exists(firm104path))
            {
                detectedFIRM104 = true;
            }
            else
            {
                detectedFIRM104 = false;
            }

            //Other stuff

            
            if (!detectedNAND)
            {
                startok = false;
            }
            else
            {
                startok = true;
            }
            if (!detectedFIRM104)
            {
                firm104CheckColor.BackColor = Color.Red;
                firm104StatusLabel.Text = "10.4.0 FIRM Not Found!";
                startok = false;
            }
            else
            {
                firm104CheckColor.BackColor = Color.Green;
                firm104StatusLabel.Text = "10.4.0 FIRM Found!";
            }

            if (!detectedFIRMX)
            {
                firmxCheckColor.BackColor = Color.Red;
                firmxStatusLabel.Text = firmComboBox.Text + " FIRM Not Found!";
                startok = false;
            }
            else
            {
                firmxCheckColor.BackColor = Color.Green;
                firmxStatusLabel.Text = firmComboBox.Text + " FIRM Found!";
            }

            if (startok)
            {
                if (curStatus == 0)
                {
                    curStatus++;
                }
                startButton.Enabled = true;
            }
            else
            {
                if (curStatus != 0)
                {
                    curStatus = 0;
                }
                startButton.Enabled = false;
            }

            progressLabel.Text = statustext[curStatus];
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            backupNAND(nandPathTextBox.Text);
            run3DSFIRM(1);
            xor(1, "backup\\tmp\\firm0.bin", firmxTextBox.Text);
            xor(2, "backup\\tmp\\firm0.bin.out", firm104TextBox.Text);
            xor(3, "backup\\tmp\\firm1.bin", firmxTextBox.Text);
            xor(4, "backup\\tmp\\firm1.bin.out", firm104TextBox.Text);
            renameFiles();
            run3DSFIRM(2);
        }
    }
}
