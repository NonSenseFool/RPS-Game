using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace RPS_Game
{
    public partial class Window : Form
    {
        /*private Player _player;
        private Player _ai;
        private Weapon _playerweapon;
        private Weapon _aiweapon;
        string temp;*/
        Player _player = new Player();
        Player _ai = new Player();
        string result;

        public void PlayGame(string weaponType)
        {
            _player.WeaponName = weaponType;
            _ai.WeaponName = _ai.AIRandomize(out _ai.WeaponName);
            result = _player.CheckEffectiveness(_player.WeaponName, _ai.WeaponName);
            if (result == "win")
            {
                int temp = Convert.ToInt32(lblWins.Text);
                temp++;
                lblWins.Text = Convert.ToString(temp);
            }
            else if (result == "lose")
            {
                int temp = Convert.ToInt32(lblLosses.Text);
                temp++;
                lblLosses.Text = Convert.ToString(temp);
            }
            else
            {
                // invalid
            }
            lblResult1.Text = "They picked " + _ai.WeaponName + ".";
            lblResult2.Text = "You " + result + "!";
            rtbLog.Text += "You " + result + "!" + Environment.NewLine;
        }

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {
            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();
        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("scissors");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
