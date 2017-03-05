using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        // This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");


        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");




        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }


        private void label35_Click(object sender, EventArgs e)
        {


        }


        private void finishlabel_MouseEnter(object sender, EventArgs e)
        {
            ///shows when game is over
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulation You won");
            Close();
        }


        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }


        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
