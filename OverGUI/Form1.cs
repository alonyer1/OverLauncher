using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OverGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FixFonts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = @"AppendHosts.exe";
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.CreateNoWindow = true;
            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    // Capture the output
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Display the output in a TextBox or other control
                    textBox1.Text += output + "\n" + error;

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The operation was canceled or failed: " + ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("OverLauncher.exe", OptionalArguments.Text);
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.CreateNoWindow = true;
            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    // Capture the output
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Display the output in a TextBox or other control
                    textBox1.Text += output + "\n" + error;

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The operation was canceled or failed: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
