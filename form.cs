using System;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Card card1 = new Card(Rank.ACE, Suit.SPADES);

            MessageBox.Show(card1.ToString() + " (Value: " + card1.Value + ")");
        }
    }
}