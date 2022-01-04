
namespace PracticeQuestions
{
    partial class Form1
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
            this.lblmark = new System.Windows.Forms.Label();
            this.lblTodayWork = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.textBoxCarNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDriverFio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnimportantInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmark
            // 
            this.lblmark.AutoSize = true;
            this.lblmark.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmark.Location = new System.Drawing.Point(25, 32);
            this.lblmark.Name = "lblmark";
            this.lblmark.Size = new System.Drawing.Size(49, 16);
            this.lblmark.TabIndex = 0;
            this.lblmark.Text = "Марка";
            // 
            // lblTodayWork
            // 
            this.lblTodayWork.AutoSize = true;
            this.lblTodayWork.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTodayWork.Location = new System.Drawing.Point(25, 167);
            this.lblTodayWork.Name = "lblTodayWork";
            this.lblTodayWork.Size = new System.Drawing.Size(128, 16);
            this.lblTodayWork.TabIndex = 6;
            this.lblTodayWork.Text = "Сегодня работают";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(565, 68);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Результаты: ";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(25, 420);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(601, 84);
            this.listBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(331, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(25, 68);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 16);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Цвет";
            // 
            // textBoxCarNumber
            // 
            this.textBoxCarNumber.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCarNumber.Location = new System.Drawing.Point(428, 20);
            this.textBoxCarNumber.Name = "textBoxCarNumber";
            this.textBoxCarNumber.Size = new System.Drawing.Size(157, 22);
            this.textBoxCarNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(337, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "гос.Номер";
            // 
            // textBoxDriverFio
            // 
            this.textBoxDriverFio.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDriverFio.Location = new System.Drawing.Point(428, 64);
            this.textBoxDriverFio.Name = "textBoxDriverFio";
            this.textBoxDriverFio.Size = new System.Drawing.Size(157, 22);
            this.textBoxDriverFio.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(331, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ФИО шофера";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStatus.Location = new System.Drawing.Point(97, 104);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(157, 22);
            this.textBoxStatus.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Состояние";
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Items.AddRange(new object[] {
            "Range Rower",
            "Porche",
            "Lexus",
            "BMV",
            "Mercedes",
            "Lamborgini"});
            this.comboBoxMark.Location = new System.Drawing.Point(97, 32);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(157, 24);
            this.comboBoxMark.TabIndex = 22;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Black",
            "Pink",
            "White",
            "Green",
            "Brown",
            "Grey",
            "Orange"});
            this.comboBoxColor.Location = new System.Drawing.Point(97, 65);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(157, 24);
            this.comboBoxColor.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(337, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Модел";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxModel.Location = new System.Drawing.Point(428, 100);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(157, 22);
            this.textBoxModel.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mark,
            this.model,
            this.carNumber,
            this.fioDriver,
            this.UnimportantInfo});
            this.dataGridView1.Location = new System.Drawing.Point(25, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(601, 150);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mark
            // 
            this.mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mark.HeaderText = "Марка";
            this.mark.Name = "mark";
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.model.HeaderText = "Модел";
            this.model.Name = "model";
            // 
            // carNumber
            // 
            this.carNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carNumber.HeaderText = "Гос. Номер";
            this.carNumber.Name = "carNumber";
            // 
            // fioDriver
            // 
            this.fioDriver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fioDriver.HeaderText = "ФИО Шофера";
            this.fioDriver.Name = "fioDriver";
            // 
            // UnimportantInfo
            // 
            this.UnimportantInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UnimportantInfo.HeaderText = "Необязтельные данные";
            this.UnimportantInfo.Name = "UnimportantInfo";
            this.UnimportantInfo.Width = 148;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(331, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 27);
            this.button2.TabIndex = 25;
            this.button2.Text = "Let\'s go!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(657, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxMark);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDriverFio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCarNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblTodayWork);
            this.Controls.Add(this.lblmark);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmark;
        private System.Windows.Forms.Label lblTodayWork;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox textBoxCarNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDriverFio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnimportantInfo;
        private System.Windows.Forms.Button button2;
    }
}

