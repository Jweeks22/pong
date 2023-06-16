using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class settings : Form
    {
        public static int maxScore;
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }
        

        private void scoregoal_ValueChanged(object sender, EventArgs e)
        {
            string max = scoregoal.Value.ToString();
            maxScore = Convert.ToInt32(max);
            Pong score = new Pong();
            score.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close From1 and show Pong
            Pong play = new Pong();
            play.Show();

            this.Close();
        }
    }
}
