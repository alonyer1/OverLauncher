namespace OverGUI
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

        #region Alon Region
        private void FixFonts()
        {
            //label1.Font = new Font("Myriad Pro", 20F);
            //button1.Font = new Font("Myriad Pro", 25F);
            //button3.Font = new Font("Myriad Pro", 25F);
            SuspendLayout();
            textBox1.Font = new Font("Microsoft Sans Serif", 20F);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label2;
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            textBox1 = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            OptionalArguments = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 199, 199, 199);
            button1.BackgroundImage = Properties.Resources.button1;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Microsoft Sans Serif", 25F);
            button1.Location = new Point(623, 334);
            button1.Name = "button1";
            button1.Size = new Size(445, 163);
            button1.TabIndex = 0;
            button1.Text = "Redirect Domains";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(65, 199, 199, 199);
            button3.BackgroundImage = Properties.Resources.button2;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("Microsoft Sans Serif", 25F);
            button3.Location = new Point(623, 574);
            button3.Name = "button3";
            button3.Size = new Size(445, 163);
            button3.TabIndex = 0;
            button3.Text = "Patch&&Launch";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.BackgroundImage = Properties.Resources.gallery_001455;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1010, 400);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Font = new Font("Consolas", 12F);
            textBox1.Location = new Point(90, 856);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(900, 170);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(90, 821);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 3;
            label1.Text = "Logs";
            label1.Click += label1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OptionalArguments
            // 
            OptionalArguments.Anchor = AnchorStyles.Bottom;
            OptionalArguments.Font = new Font("Consolas", 20F);
            OptionalArguments.Location = new Point(90, 764);
            OptionalArguments.Name = "OptionalArguments";
            OptionalArguments.ScrollBars = ScrollBars.Vertical;
            OptionalArguments.Size = new Size(900, 39);
            OptionalArguments.TabIndex = 2;
            OptionalArguments.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(90, 729);
            label2.Name = "label2";
            label2.Size = new Size(446, 32);
            label2.TabIndex = 3;
            label2.Text = "Optional Command Line Arguments";
            label2.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(31, 38, 46);
            BackgroundImage = Properties.Resources.sombra1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1080, 1061);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OptionalArguments);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 13, 3, 13);
            Name = "Form1";
            Text = "OverPatcher";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBox1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox OptionalArguments;
    }
}