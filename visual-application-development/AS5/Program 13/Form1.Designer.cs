namespace Program13
{
    partial class FormChampions
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTopPlayers = new Label();
            lblChampions = new Label();
            cboTopPlayers = new ComboBox();
            cboWimbledonChampions = new ComboBox();
            btnHowManyWins = new Button();
            btnB2B = new Button();
            btnExit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTopPlayers
            // 
            lblTopPlayers.AutoSize = true;
            lblTopPlayers.Location = new Point(12, 48);
            lblTopPlayers.Name = "lblTopPlayers";
            lblTopPlayers.Size = new Size(67, 15);
            lblTopPlayers.TabIndex = 0;
            lblTopPlayers.Text = "Top Players";
            // 
            // lblChampions
            // 
            lblChampions.AutoSize = true;
            lblChampions.Location = new Point(249, 48);
            lblChampions.Name = "lblChampions";
            lblChampions.Size = new Size(201, 15);
            lblChampions.TabIndex = 1;
            lblChampions.Text = "Wimbledon Champions (since 1968) ";
            // 
            // cboTopPlayers
            // 
            cboTopPlayers.FormattingEnabled = true;
            cboTopPlayers.Items.AddRange(new object[] { "Agnieszka Radwanska", "Amelie Mauresmo", "Andrea Jaeger", "Angelique Kerber", "Ann Jones", "Anna Kalinskaya", "Arantxa Sanchez Vicario", "Aryna Sabalenka", "Ashleigh Barty", "Barabora Krejcikova", "Beatriz Haddad Maia", "Betty Stove", "Bianca Andreescu", "Billie Jean King", "Caroline Garcia", "Chris Evert", "Coco Gauff", "Conchita Martinez", "Danielle Collins", "Daria Kasatkina", "Elena Rybakina", "Emma Navarro", "Emma Raducanu", "Eugenie Bouchard", "Evonne Goolagong", "Flavia Pennetta", "Gabriela Sabatini", "Garbine Muguruza", "Hana Mandlikova", "Helena Sukova", "Iga Swiatek", "Jana Novotna", "Jelena Ostapenko", "Jasmine Paolini", "Jennifer Capriati", "Jessica Pegula", "Judy Tegart", "Justine Henin", "Karolina Muchova", "Karolina Pliskova", "Kim Clijsters", "Lindsay Davenport", "Margaret Court", "Maria Sakkari", "Maria Sharapova", "Marion Bartoli", "Marketa Vondrousova", "Martina Hingis", "Martina Navratilova", "Mary Pierce", "Monica Seles", "Naomi Osaka", "Nathalie Tauziat", "Olga Morozova", "Ons Jabeur", "Paula Badosa", "Petra Kvitova", "Qinwen Zheng", "Sabine Lisicki", "Samantha Stosur", "Serena Williams", "Simona Halep", "Sloane Stephens", "Steffi Graf", "Svetlana Kuznetsova", "Tracy Austin", "Venus Williams", "Vera Zvonareva", "Virginia Wade", "Zina Garrison" });
            cboTopPlayers.Location = new Point(12, 66);
            cboTopPlayers.Name = "cboTopPlayers";
            cboTopPlayers.Size = new Size(216, 23);
            cboTopPlayers.TabIndex = 2;
            // 
            // cboWimbledonChampions
            // 
            cboWimbledonChampions.FormattingEnabled = true;
            cboWimbledonChampions.Items.AddRange(new object[] { "Billie Jean King", "Ann Jones", "Margaret Court", "Evonne Goolagong", "Billie Jean King", "Billie Jean King", "Chris Evert", "Billie Jean King", "Chris Evert", "Virginia Wade", "Martina Navratilova", "Martina Navratilova", "Evonne Goolagong", "Chris Evert", "Martina Navratilova", "Martina Navratilova", "Martina Navratilova", "Martina Navratilova", "Martina Navratilova", "Martina Navratilova", "Steffi Graf", "Steffi Graf", "Martina Navratilova", "Steffi Graf", "Steffi Graf", "Steffi Graf", "Conchita Martinez", "Steffi Graf", "Steffi Graf", "Martina Hingis", "Jana Novotna", "Lindsay Davenport", "Venus Williams", "Venus Williams", "Serena Williams", "Serena Williams", "Maria Sharapova", "Venus Williams", "Amelie Mauresmo", "Venus Williams", "Venus Williams", "Serena Williams", "Serena Williams", "Petra Kvitova", "Serena Williams", "Marion Bartoli", "Petra Kvitova", "Serena Williams", "Serena Williams", "Garbine Muguruza", "Angelique Kerber", "Simona Halep", "Ashleigh Barty", "Elena Rybakina", "Marketa Vondrousova", "Barabora Krejcikova" });
            cboWimbledonChampions.Location = new Point(249, 66);
            cboWimbledonChampions.Name = "cboWimbledonChampions";
            cboWimbledonChampions.Size = new Size(216, 23);
            cboWimbledonChampions.TabIndex = 3;
            // 
            // btnHowManyWins
            // 
            btnHowManyWins.Location = new Point(498, 12);
            btnHowManyWins.Name = "btnHowManyWins";
            btnHowManyWins.Size = new Size(240, 38);
            btnHowManyWins.TabIndex = 4;
            btnHowManyWins.Text = "How Many Wins?";
            btnHowManyWins.UseVisualStyleBackColor = true;
            btnHowManyWins.Click += btnHowManyWins_Click;
            // 
            // btnB2B
            // 
            btnB2B.Location = new Point(744, 12);
            btnB2B.Name = "btnB2B";
            btnB2B.Size = new Size(240, 39);
            btnB2B.TabIndex = 5;
            btnB2B.Text = "How Many Times Back2Back Champions?";
            btnB2B.UseVisualStyleBackColor = true;
            btnB2B.Click += btnB2B_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(990, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(498, 57);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(538, 73);
            lblResult.TabIndex = 7;
            // 
            // FormChampions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 144);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnB2B);
            Controls.Add(btnHowManyWins);
            Controls.Add(cboWimbledonChampions);
            Controls.Add(cboTopPlayers);
            Controls.Add(lblChampions);
            Controls.Add(lblTopPlayers);
            Name = "FormChampions";
            Text = "Wimbledon Champions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTopPlayers;
        private Label lblChampions;
        private ComboBox cboTopPlayers;
        private ComboBox cboWimbledonChampions;
        private Button btnHowManyWins;
        private Button btnB2B;
        private Button btnExit;
        private Label lblResult;
    }
}
