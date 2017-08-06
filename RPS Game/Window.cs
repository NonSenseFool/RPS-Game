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

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            _player.WeaponName = "rock";
            _ai.WeaponName = _ai.AIRandomize(out _ai.WeaponName);
            
            lblResult1.Text = _ai.WeaponName;
            lblResult2.Text = _player.WeaponName;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
