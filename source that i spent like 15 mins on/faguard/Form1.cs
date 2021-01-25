using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace faguard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = @"C:\Program Files\Riot Vanguard\ballsack.sys";
            bool fileExist = File.Exists(path);
            if (fileExist)
                System.IO.File.Move(@"C:\Program Files\Riot Vanguard\ballsack.sys", @"C:\Program Files\Riot Vanguard\vgk.sys");
            else
                Console.WriteLine("Vanguard is already enabled.");
                this.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Riot Vanguard\vgk.sys";
            bool fileExist = File.Exists(path);
            if (fileExist)
                System.IO.File.Move(@"C:\Program Files\Riot Vanguard\vgk.sys", @"C:\Program Files\Riot Vanguard\ballsack.sys");
            else
                Console.WriteLine("Vanguard already is disabled.");
            this.BackColor = Color.Red;

        }
    }
}
