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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void cardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cF_Main_DatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cF_Main_DatabaseDataSet2.Cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter1.Fill(this.cF_Main_DatabaseDataSet2.Cards);
            // TODO: This line of code loads data into the 'cF_Main_DatabaseDataSet1.Cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter.Fill(this.cF_Main_DatabaseDataSet1.Cards);
            // TODO: This line of code loads data into the 'cF_Main_DatabaseDataSet.Cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter.Fill(this.cF_Main_DatabaseDataSet.Cards);


        }
        int loops = 0;
        int[] holding = new int[70];
        int pack = 2;
        Form2 f = new Form2();

        private void button_Flip_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int hold1 = rand.Next(1, 59);
            int hold2 = rand.Next(1, 59);
            int hold3 = rand.Next(1, 59);
            int hold4 = rand.Next(1, 59);
            int hold5 = rand.Next(1, 59);
            int hold6 = rand.Next(1, 59);
            int hold7 = rand.Next(60, 100);


            holding[0 + loops] = hold1;
            holding[1 + loops] = hold2;
            holding[2 + loops] = hold3;
            holding[3 + loops] = hold4;
            holding[4 + loops] = hold5;
            holding[5 + loops] = hold6;
            holding[6 + loops] = hold7;
            loops = loops + 7;

            listBox1.Text = hold1.ToString();
            listBox2.Text = hold2.ToString();
            listBox3.Text = hold3.ToString();
            listBox4.Text = hold4.ToString();
            listBox5.Text = hold5.ToString();
            listBox6.Text = hold6.ToString();
            listBox7.Text = hold7.ToString();


            if (holding[69] > 0)
            {
                button_Save.Enabled = true;
                foreach (var item in holding)
                {
                    listBox8.Items.Add("Card ID #"+item);
                }
            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;


            if (pack <= 10)
            {
                button_Flip.Enabled = false;
                button_Open.Enabled = true;
                button_Open.Text = "Open Pack ("+ pack+ "/10)";
                pack++;
           }
            if (pack > 10)
            {
                button_Flip.Enabled = false;

            }

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            button_Open.Enabled = false;
            button_Flip.Enabled = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;

            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;



        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            button_Deck.Enabled = true;
       }

        private void button_Editor_Click(object sender, EventArgs e)
        {

        }

        private void button_Deck_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            if (pack <= 10)
            {
                MessageBox.Show("To start, press the 'Open Pack (1/10)' button. This will allow you to simulate an opening of 10 packs of the card game. To open the next pack, press the flip button and repeat until you opened 10 packs.");
            }
            if (pack > 10)
            {
                MessageBox.Show("To continue, press the 'Save Draft' button and then press the 'To Deck Builder' button. Note: This simulation does not save your pulls and the deck builder will display every card from the main database.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pack = 2;
            loops = 0;

            button_Flip.Enabled = false;
            button_Open.Enabled = true;
            button_Save.Enabled = false;
            button_Deck.Enabled = false;

            button_Open.Text = "Open Pack("+(pack-1)+"/10)";
            holding[69] = 0;
        }
    }
}
