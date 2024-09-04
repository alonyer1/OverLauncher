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
            MaximizeBox = false;
            FixFonts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This application requires admin privileges to modify system files. Please confirm to proceed.", "Admin Rights Needed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            ProcessStartInfo processInfo = new ProcessStartInfo();
            if (result == DialogResult.OK)
            {
                processInfo.Verb = "runas";
                processInfo.FileName = @"AppendHosts.exe";
                processInfo.UseShellExecute = true;
                processInfo.RedirectStandardOutput = false;
                processInfo.RedirectStandardError = false;
                processInfo.CreateNoWindow = true;
                textBox1.Text += "This operation requires administrator privilage.\n";
                try
                {
                    using (Process process = Process.Start(processInfo))
                    {
                        // Capture the output
                        //string output = process.StandardOutput.ReadToEnd();
                        //string error = process.StandardError.ReadToEnd();

                        // Display the output in a TextBox or other control
                        //textBox1.Text += output + "\n" + error;

                        process.WaitForExit();
                        textBox1.Text += "\nDone!\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The operation was canceled or failed: " + ex.Message);
                }
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog overwatch = new OpenFileDialog();
            overwatch.InitialDirectory = @"C:\";
            overwatch.DefaultExt = @".exe";
            overwatch.Filter = @"Overwatch beta executable|GameClientApp.exe|Overwatch executable|Overwatch.exe";
            overwatch.Title = "Browse for Overwatch client";
            overwatch.ShowDialog();
            if (overwatch.FileName != string.Empty)
            {
                string arguments = "\"" + overwatch.FileName + "\" " + OptionalArguments.Text;
                ProcessStartInfo processInfo = new ProcessStartInfo("OverLauncher.exe", arguments);
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

                        //process.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The operation was canceled or failed: " + ex.Message);
                }
            }
        }
        private void changeToWhite(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Image = Properties.Resources.buttonHover;
            //button.BackColor = Color.Transparent;
        }
        private void changeToYellow(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Image = Properties.Resources.buttonRegular;
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
