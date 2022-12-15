
namespace CF_Cards_Final
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cardsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cF_Main_DatabaseDataSet = new CF_Cards_Final.CF_Main_DatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cardsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cardsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cardsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cardsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.cF_Main_DatabaseDataSet2 = new CF_Cards_Final.CF_Main_DatabaseDataSet2();
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsTableAdapter = new CF_Cards_Final.CF_Main_DatabaseDataSet2TableAdapters.CardsTableAdapter();
            this.cardsTableAdapter1 = new CF_Cards_Final.CF_Main_DatabaseDataSetTableAdapters.CardsTableAdapter();
            this.tableAdapterManager = new CF_Cards_Final.CF_Main_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.cardsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cF_Main_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cF_Main_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1862, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next 5 Cards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource1, "cardRarity", true));
            this.label1.Location = new System.Drawing.Point(79, 387);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 49);
            this.label1.TabIndex = 98;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsBindingSource1
            // 
            this.cardsBindingSource1.DataMember = "Cards";
            this.cardsBindingSource1.DataSource = this.cF_Main_DatabaseDataSet;
            // 
            // cF_Main_DatabaseDataSet
            // 
            this.cF_Main_DatabaseDataSet.DataSetName = "CF_Main_DatabaseDataSet";
            this.cF_Main_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource1, "cardPoints", true));
            this.label2.Location = new System.Drawing.Point(79, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 49);
            this.label2.TabIndex = 97;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource1, "cardSide", true));
            this.label3.Location = new System.Drawing.Point(79, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 49);
            this.label3.TabIndex = 96;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource1, "cardName", true));
            this.label4.Location = new System.Drawing.Point(79, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 49);
            this.label4.TabIndex = 95;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CF_Cards_Final.Properties.Resources.cardFront;
            this.pictureBox1.Location = new System.Drawing.Point(65, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource2, "cardRarity", true));
            this.label5.Location = new System.Drawing.Point(451, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 49);
            this.label5.TabIndex = 103;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsBindingSource2
            // 
            this.cardsBindingSource2.DataMember = "Cards";
            this.cardsBindingSource2.DataSource = this.cF_Main_DatabaseDataSet;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource2, "cardPoints", true));
            this.label6.Location = new System.Drawing.Point(451, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 49);
            this.label6.TabIndex = 102;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource2, "cardSide", true));
            this.label7.Location = new System.Drawing.Point(451, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 49);
            this.label7.TabIndex = 101;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource2, "cardName", true));
            this.label8.Location = new System.Drawing.Point(451, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 49);
            this.label8.TabIndex = 100;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::CF_Cards_Final.Properties.Resources.cardFront;
            this.pictureBox2.Location = new System.Drawing.Point(437, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 405);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource3, "cardRarity", true));
            this.label9.Location = new System.Drawing.Point(821, 387);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 49);
            this.label9.TabIndex = 108;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsBindingSource3
            // 
            this.cardsBindingSource3.DataMember = "Cards";
            this.cardsBindingSource3.DataSource = this.cF_Main_DatabaseDataSet;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource3, "cardPoints", true));
            this.label10.Location = new System.Drawing.Point(821, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 49);
            this.label10.TabIndex = 107;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource3, "cardSide", true));
            this.label11.Location = new System.Drawing.Point(821, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 49);
            this.label11.TabIndex = 106;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource3, "cardName", true));
            this.label12.Location = new System.Drawing.Point(821, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 49);
            this.label12.TabIndex = 105;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::CF_Cards_Final.Properties.Resources.cardFront;
            this.pictureBox3.Location = new System.Drawing.Point(807, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(272, 405);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource4, "cardRarity", true));
            this.label13.Location = new System.Drawing.Point(1190, 387);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 49);
            this.label13.TabIndex = 113;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsBindingSource4
            // 
            this.cardsBindingSource4.DataMember = "Cards";
            this.cardsBindingSource4.DataSource = this.cF_Main_DatabaseDataSet;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource4, "cardPoints", true));
            this.label14.Location = new System.Drawing.Point(1190, 275);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 49);
            this.label14.TabIndex = 112;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource4, "cardSide", true));
            this.label15.Location = new System.Drawing.Point(1190, 155);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 49);
            this.label15.TabIndex = 111;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource4, "cardName", true));
            this.label16.Location = new System.Drawing.Point(1190, 51);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(243, 49);
            this.label16.TabIndex = 110;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::CF_Cards_Final.Properties.Resources.cardFront;
            this.pictureBox4.Location = new System.Drawing.Point(1176, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(272, 405);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 114;
            this.pictureBox4.TabStop = false;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource5, "cardRarity", true));
            this.label17.Location = new System.Drawing.Point(1560, 387);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 49);
            this.label17.TabIndex = 118;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsBindingSource5
            // 
            this.cardsBindingSource5.DataMember = "Cards";
            this.cardsBindingSource5.DataSource = this.cF_Main_DatabaseDataSet;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource5, "cardPoints", true));
            this.label18.Location = new System.Drawing.Point(1560, 275);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(243, 49);
            this.label18.TabIndex = 117;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource5, "cardSide", true));
            this.label19.Location = new System.Drawing.Point(1560, 155);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(243, 49);
            this.label19.TabIndex = 116;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource5, "cardName", true));
            this.label20.Location = new System.Drawing.Point(1560, 51);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(243, 49);
            this.label20.TabIndex = 115;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::CF_Cards_Final.Properties.Resources.cardFront;
            this.pictureBox5.Location = new System.Drawing.Point(1546, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(272, 405);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 119;
            this.pictureBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 68);
            this.button2.TabIndex = 120;
            this.button2.Text = "Add to Deck";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 68);
            this.button3.TabIndex = 121;
            this.button3.Text = "Add to Deck";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(807, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 68);
            this.button4.TabIndex = 122;
            this.button4.Text = "Add to Deck";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1177, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(271, 68);
            this.button5.TabIndex = 123;
            this.button5.Text = "Add to Deck";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1547, 490);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(271, 68);
            this.button6.TabIndex = 124;
            this.button6.Text = "Add to Deck";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.cardsBindingSource1;
            this.listBox1.DisplayMember = "cardID";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(1939, 437);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(31, 35);
            this.listBox1.TabIndex = 125;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.cardsBindingSource2;
            this.listBox2.DisplayMember = "cardID";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(1939, 396);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(23, 35);
            this.listBox2.TabIndex = 126;
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.cardsBindingSource3;
            this.listBox3.DisplayMember = "cardID";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 31;
            this.listBox3.Location = new System.Drawing.Point(1968, 396);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(19, 35);
            this.listBox3.TabIndex = 127;
            // 
            // listBox4
            // 
            this.listBox4.DataSource = this.cardsBindingSource4;
            this.listBox4.DisplayMember = "cardID";
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 31;
            this.listBox4.Location = new System.Drawing.Point(1976, 437);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(22, 35);
            this.listBox4.TabIndex = 128;
            // 
            // listBox5
            // 
            this.listBox5.DataSource = this.cardsBindingSource5;
            this.listBox5.DisplayMember = "cardID";
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 31;
            this.listBox5.Location = new System.Drawing.Point(1993, 396);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(25, 35);
            this.listBox5.TabIndex = 129;
            // 
            // cF_Main_DatabaseDataSet2
            // 
            this.cF_Main_DatabaseDataSet2.DataSetName = "CF_Main_DatabaseDataSet2";
            this.cF_Main_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsBindingSource
            // 
            this.cardsBindingSource.DataMember = "Cards";
            this.cardsBindingSource.DataSource = this.cF_Main_DatabaseDataSet2;
            // 
            // cardsTableAdapter
            // 
            this.cardsTableAdapter.ClearBeforeFill = true;
            // 
            // cardsTableAdapter1
            // 
            this.cardsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = this.cardsTableAdapter1;
            this.tableAdapterManager.PlayerTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransferTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CF_Cards_Final.CF_Main_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 31;
            this.listBox6.Location = new System.Drawing.Point(1862, 285);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(257, 252);
            this.listBox6.TabIndex = 130;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(1862, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(257, 62);
            this.label21.TabIndex = 131;
            this.label21.Text = "Deck List:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1862, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 85);
            this.button7.TabIndex = 132;
            this.button7.Text = "HELP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cardsBindingSource6
            // 
            this.cardsBindingSource6.DataMember = "Cards";
            this.cardsBindingSource6.DataSource = this.cF_Main_DatabaseDataSet;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 579);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cF_Main_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cF_Main_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private CF_Main_DatabaseDataSet2 cF_Main_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private CF_Main_DatabaseDataSet2TableAdapters.CardsTableAdapter cardsTableAdapter;
        private CF_Main_DatabaseDataSet cF_Main_DatabaseDataSet;
        private System.Windows.Forms.BindingSource cardsBindingSource1;
        private CF_Main_DatabaseDataSetTableAdapters.CardsTableAdapter cardsTableAdapter1;
        private CF_Main_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cardsBindingSource2;
        private System.Windows.Forms.BindingSource cardsBindingSource3;
        private System.Windows.Forms.BindingSource cardsBindingSource4;
        private System.Windows.Forms.BindingSource cardsBindingSource5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource cardsBindingSource6;
    }
}