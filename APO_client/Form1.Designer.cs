namespace APO_client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clubname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.League = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.leagueTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.trainerTextBox = new System.Windows.Forms.TextBox();
            this.stadiumTextBox = new System.Windows.Forms.TextBox();
            this.addClubButton = new System.Windows.Forms.Button();
            this.createEcselButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clubname,
            this.League,
            this.City,
            this.Trainer,
            this.Stadium});
            this.dataGridView1.Location = new System.Drawing.Point(12, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(577, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // Clubname
            // 
            this.Clubname.HeaderText = "Clubname";
            this.Clubname.Name = "Clubname";
            this.Clubname.Width = 79;
            // 
            // League
            // 
            this.League.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.League.HeaderText = "League";
            this.League.Name = "League";
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Trainer
            // 
            this.Trainer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trainer.HeaderText = "Trainer";
            this.Trainer.Name = "Trainer";
            // 
            // Stadium
            // 
            this.Stadium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stadium.HeaderText = "Stadium";
            this.Stadium.Name = "Stadium";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Лига:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Город:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тренер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Стадион:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(75, 182);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // leagueTextBox
            // 
            this.leagueTextBox.Location = new System.Drawing.Point(75, 204);
            this.leagueTextBox.Name = "leagueTextBox";
            this.leagueTextBox.Size = new System.Drawing.Size(150, 20);
            this.leagueTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(75, 226);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // trainerTextBox
            // 
            this.trainerTextBox.Location = new System.Drawing.Point(75, 248);
            this.trainerTextBox.Name = "trainerTextBox";
            this.trainerTextBox.Size = new System.Drawing.Size(150, 20);
            this.trainerTextBox.TabIndex = 9;
            // 
            // stadiumTextBox
            // 
            this.stadiumTextBox.Location = new System.Drawing.Point(75, 271);
            this.stadiumTextBox.Name = "stadiumTextBox";
            this.stadiumTextBox.Size = new System.Drawing.Size(150, 20);
            this.stadiumTextBox.TabIndex = 10;
            // 
            // addClubButton
            // 
            this.addClubButton.Location = new System.Drawing.Point(316, 193);
            this.addClubButton.Name = "addClubButton";
            this.addClubButton.Size = new System.Drawing.Size(212, 26);
            this.addClubButton.TabIndex = 11;
            this.addClubButton.Text = "Добавить клуб в БД";
            this.addClubButton.UseVisualStyleBackColor = true;
            this.addClubButton.Click += new System.EventHandler(this.addClubButton_Click);
            // 
            // createEcselButton
            // 
            this.createEcselButton.Location = new System.Drawing.Point(316, 230);
            this.createEcselButton.Name = "createEcselButton";
            this.createEcselButton.Size = new System.Drawing.Size(211, 24);
            this.createEcselButton.TabIndex = 12;
            this.createEcselButton.Text = "Экспортировать в Excel";
            this.createEcselButton.UseVisualStyleBackColor = true;
            this.createEcselButton.Click += new System.EventHandler(this.createEcselButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 309);
            this.Controls.Add(this.createEcselButton);
            this.Controls.Add(this.addClubButton);
            this.Controls.Add(this.stadiumTextBox);
            this.Controls.Add(this.trainerTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.leagueTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox leagueTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox trainerTextBox;
        private System.Windows.Forms.TextBox stadiumTextBox;
        private System.Windows.Forms.Button addClubButton;
        private System.Windows.Forms.Button createEcselButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clubname;
        private System.Windows.Forms.DataGridViewTextBoxColumn League;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadium;
    }
}

