using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> deck = DeckBuilder.Generate();
        public Form1()
        {
            InitializeComponent();
        }

        private void cardsLeftLabel_Click(object sender, EventArgs e)
        {
            Text = deck.Count.ToString();
        }

        private void numCardsTextBox_TextChanged(object sender, EventArgs e)
        {
            numCardsTextBox.Text = "5";
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            int numCards = 0; //cards to deal
            int handValue = 0; //value of cards
            Random rand = new Random();

            DealtCardsListBox.Items.Clear();

            valueLabel.Text = "";

            if(int.TryParse(numCardsTextBox.Text, out numCards))
            {
                if(numCards > 0 && numCards <= deck.Count)
                {
                    for(int count = 0; count < numCards; count++)
                    {
                        int randNum = rand.Next(deck.Count);

                        var card = deck.ElementAt(randNum);

                        DealtCardsListBox.Items.Add(card.Key);

                        handValue += card.Value;
                        valueLabel.Text  = handValue.ToString();

                        deck.Remove(card.Key);

                        cardsLeftLabel.Text = deck.Count.ToString();
                    }
                }
                else
                {
                    if (deck.Count == 0)
                    {
                        MessageBox.Show("The deck is empty...");
                    }
                    else
                    {
                        MessageBox.Show($"Enter a number in the range of 1 through {deck.Count.ToString()}.....");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter an integer");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            valueLabel.Text = string.Empty;
            DealtCardsListBox.Items.Clear();
            cardsLeftLabel.Text= string.Empty;
            deck = DeckBuilder.Generate();
            cardsLeftLabel.Text += deck.Count.ToString();
        }
    }
}
