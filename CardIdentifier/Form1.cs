using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        

        private void Clubs2_Click(object sender, EventArgs e){
            CardName.Text = "2 of Clubs";
        }

        private void Diamonds8_Click(object sender, EventArgs e){
            CardName.Text = "8 of Diamonds";
        }

        private void SpadesA_Click(object sender, EventArgs e)
        {
            CardName.Text = "Ace of Spades";
        }

        private void Joker_Click(object sender, EventArgs e)
        {
            CardName.Text = "This is the Joker";
        }

        private void SpadesKing_Click(object sender, EventArgs e)
        {
            CardName.Text = "King of Spades";
        }
    }
}
