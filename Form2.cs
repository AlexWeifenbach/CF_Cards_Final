using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CF_Cards_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int count = 0;
        int[] deck = new int[20];
        int deckCount = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            int hold1 = count + 1;
            int hold2 = count + 2;
            int hold3 = count + 3;
            int hold4 = count + 4;
            int hold5 = count + 5;

            listBox1.Text = hold1.ToString();
            listBox2.Text = hold2.ToString();
            listBox3.Text = hold3.ToString();
            listBox4.Text = hold4.ToString();
            listBox5.Text = hold5.ToString();
            count = count + 5;

            if (count == 100)
            {
                count = count - 100;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cF_Main_DatabaseDataSet.Cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter1.Fill(this.cF_Main_DatabaseDataSet.Cards);
            // TODO: This line of code loads data into the 'cF_Main_DatabaseDataSet2.Cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter.Fill(this.cF_Main_DatabaseDataSet2.Cards);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deck[deckCount] = count - 4;
            deckCount++;
            listBox6.Items.Add("Card ID #" + (count - 4));
            if (deckCount == 20)
            {
                MessageBox.Show("Max deck size reached");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deck[deckCount] = count - 3;
            deckCount++;
            listBox6.Items.Add("Card ID #" + (count - 3));
            if (deckCount == 20)
            {
                MessageBox.Show("Max deck size reached");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deck[deckCount] = count - 2;
            deckCount++;
            listBox6.Items.Add("Card ID #" + (count - 2));
            if (deckCount == 20)
            {
                MessageBox.Show("Max deck size reached");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deck[deckCount] = count - 1;
            deckCount++;
            listBox6.Items.Add("Card ID #" + (count - 1));
            if (deckCount == 20)
            {
                MessageBox.Show("Max deck size reached");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deck[deckCount] = count;
            deckCount++;
            listBox6.Items.Add("Card ID #" + count);
            if (deckCount == 20)
            {
                MessageBox.Show("Max deck size reached");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (deckCount < 20)
            {
                MessageBox.Show("Click the 'Next 5 Cards' button to display the next five cards in ID order. You can click the 'Add to Deck' button to add the above card to your deck. The deck size limit is 20 cards.");
            }
            if (deckCount == 20)
            {
                MessageBox.Show("Your deck is now complete. You can cross reference your choices with the Cards table in the CF_Main_Database. After that you can design your own designs for the cards to play with in real life. Thank you for using this program!");
            }
        }
    }
}
