using Miner.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
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

        private void StartGame(object sender, EventArgs e)
        {
            Form defaultForm = new Form();
            defaultForm.Show();
            defaultForm.Width = this.Width;
            defaultForm.Height = this.Height;
            MapController.Init(defaultForm);
            
          
        }

        private void SettingsGame(object sender, EventArgs e)
        {   
            sizeField.Visible = true;
            comboSizeField.Visible = true;
            dificaltyGame.Visible = true;   
            comboDificaltyGame.Visible = true;
            back.Visible = true;
            startGameLab.Visible = false;
            settingsLLab.Visible = false;
            ExiteLab.Visible = false;
        }

        private void ExiteGame(object sender, EventArgs e)
        {
            Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            sizeField.Visible = false;
            comboSizeField.Visible = false;
            dificaltyGame.Visible = false;
            comboDificaltyGame.Visible = false;
            back.Visible = false;
            startGameLab.Visible = true;
            settingsLLab.Visible = true;
            ExiteLab.Visible = true;
        }

        private void stopGame_Click(object sender, EventArgs e)
        {

        }
    }
}
