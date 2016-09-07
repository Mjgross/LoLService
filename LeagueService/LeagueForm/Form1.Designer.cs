namespace LeagueForm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftKDA = new System.Windows.Forms.Label();
            this.rightKDA = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.leftKDAcolor = new System.Windows.Forms.RichTextBox();
            this.rightKDAcolor = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.champBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Font = new System.Drawing.Font("Friz Quadrata Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search for summoner 1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox2.Font = new System.Drawing.Font("Friz Quadrata Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(605, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Search for summoner 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 15;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lookup User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(684, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(448, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Lookup User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FrizQuadrata BT", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FrizQuadrata BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FrizQuadrata BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(679, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("FrizQuadrata BT", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(397, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 71);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(343, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // leftKDA
            // 
            this.leftKDA.AutoSize = true;
            this.leftKDA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftKDA.Location = new System.Drawing.Point(129, 450);
            this.leftKDA.Name = "leftKDA";
            this.leftKDA.Size = new System.Drawing.Size(0, 43);
            this.leftKDA.TabIndex = 16;
            // 
            // rightKDA
            // 
            this.rightKDA.AutoSize = true;
            this.rightKDA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightKDA.Location = new System.Drawing.Point(574, 450);
            this.rightKDA.Name = "rightKDA";
            this.rightKDA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rightKDA.Size = new System.Drawing.Size(0, 43);
            this.rightKDA.TabIndex = 20;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "Summoner1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(154, 576);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "Summoner1";
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Summoner1";
            series4.ChartArea = "Summoner1";
            series4.Legend = "Legend1";
            series4.Name = "Summoner2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(542, 228);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // leftKDAcolor
            // 
            this.leftKDAcolor.BackColor = System.Drawing.Color.DimGray;
            this.leftKDAcolor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftKDAcolor.Font = new System.Drawing.Font("FrizQuadrata BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftKDAcolor.ForeColor = System.Drawing.SystemColors.Menu;
            this.leftKDAcolor.Location = new System.Drawing.Point(56, 398);
            this.leftKDAcolor.Name = "leftKDAcolor";
            this.leftKDAcolor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.leftKDAcolor.Size = new System.Drawing.Size(264, 49);
            this.leftKDAcolor.TabIndex = 25;
            this.leftKDAcolor.Text = "";
            // 
            // rightKDAcolor
            // 
            this.rightKDAcolor.BackColor = System.Drawing.Color.DimGray;
            this.rightKDAcolor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightKDAcolor.Font = new System.Drawing.Font("FrizQuadrata BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightKDAcolor.ForeColor = System.Drawing.SystemColors.Menu;
            this.rightKDAcolor.Location = new System.Drawing.Point(486, 398);
            this.rightKDAcolor.Name = "rightKDAcolor";
            this.rightKDAcolor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rightKDAcolor.Size = new System.Drawing.Size(261, 49);
            this.rightKDAcolor.TabIndex = 26;
            this.rightKDAcolor.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "KDA :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(584, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "KDA :";
            // 
            // champBox1
            // 
            this.champBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.champBox1.FormattingEnabled = true;
            this.champBox1.Items.AddRange(new object[] {
            "Aatrox",
            "Ahri",
            "Akali",
            "Alistar",
            "Amumu",
            "Anivia",
            "Annie",
            "Ashe",
            "Aurelion Sol",
            "Azir",
            "Bard",
            "Blitzcrank",
            "Brand",
            "Braum",
            "Caitlyn",
            "Cassiopeia",
            "Cho\'Gath",
            "Corki",
            "Darius",
            "Diana",
            "Dr. Mundo",
            "Draven",
            "Ekko",
            "Elise",
            "Evelynn",
            "Ezreal",
            "Fiddlesticks",
            "Fiora",
            "Fizz",
            "Galio",
            "Gangplank",
            "Garen",
            "Gnar",
            "Gragas",
            "Graves",
            "Hecarim",
            "Heimerdinger",
            "Illaoi",
            "Irelia",
            "Janna",
            "Jarvan IV",
            "Jax",
            "Jayce",
            "Jhin",
            "Jinx",
            "Kalista",
            "Karma",
            "Karthus",
            "Kassadin",
            "Katarina",
            "Kayle",
            "Kennen",
            "Kha\'Zix",
            "Kindred",
            "Kled",
            "Kog\'Maw",
            "LeBlanc",
            "Lee Sin",
            "Leona",
            "Lissandra",
            "Lucian",
            "Lulu",
            "Lux",
            "Malphite",
            "Malzahar",
            "Maokai",
            "Master Yi",
            "Miss Fortune",
            "Mordekaiser",
            "Morgana",
            "Nami",
            "Nasus",
            "Nautilus",
            "Nidalee",
            "Nocturne",
            "Nunu",
            "Olaf",
            "Orianna",
            "Pantheon",
            "Poppy",
            "Quinn",
            "Rammus",
            "Rek\'Sai",
            "Renekton",
            "Rengar",
            "Riven",
            "Rumble",
            "Ryze",
            "Sejuani",
            "Shaco",
            "Shen",
            "Shyvana",
            "Singed",
            "Sion",
            "Sivir",
            "Skarner",
            "Sona",
            "Soraka",
            "Swain",
            "Syndra",
            "Tahm Kench",
            "Taliyah",
            "Talon",
            "Taric",
            "Teemo",
            "Thresh",
            "Tristana",
            "Trundle",
            "Tryndamere",
            "Twisted Fate",
            "Twitch",
            "Udyr",
            "Urgot",
            "Varus",
            "Vayne",
            "Veigar",
            "Vel\'Koz",
            "Vi",
            "Viktor",
            "Vladimir",
            "Volibear",
            "Warwick",
            "Wukong",
            "Xerath",
            "Xin Zhao",
            "Yasuo",
            "Yorick",
            "Zac",
            "Zed",
            "Ziggs",
            "Zilean",
            "Zyra"});
            this.champBox1.Location = new System.Drawing.Point(342, 239);
            this.champBox1.Name = "champBox1";
            this.champBox1.Size = new System.Drawing.Size(121, 21);
            this.champBox1.TabIndex = 29;
            this.champBox1.SelectedIndexChanged += new System.EventHandler(this.champBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("FrizQuadrata BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Image = global::LeagueForm.Properties.Resources.background2;
            this.label7.Location = new System.Drawing.Point(51, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(698, 79);
            this.label7.TabIndex = 30;
            this.label7.Text = "League Stat Comparer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::LeagueForm.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 801);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.champBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightKDAcolor);
            this.Controls.Add(this.leftKDAcolor);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.rightKDA);
            this.Controls.Add(this.leftKDA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label leftKDA;
        private System.Windows.Forms.Label rightKDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox leftKDAcolor;
        private System.Windows.Forms.RichTextBox rightKDAcolor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox champBox1;
        private System.Windows.Forms.Label label7;
    }
}

