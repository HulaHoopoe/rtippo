namespace ContractsList
{
    partial class recordCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.contractNumber = new System.Windows.Forms.TextBox();
            this.cardInfo = new System.Windows.Forms.TabControl();
            this.mainInfo = new System.Windows.Forms.TabPage();
            this.customerInfo = new System.Windows.Forms.TabPage();
            this.commonInfo = new System.Windows.Forms.TabPage();
            this.changeButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameMo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameOmsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.subvenceYear = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.fileInfo = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.downloadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardInfo.SuspendLayout();
            this.mainInfo.SuspendLayout();
            this.customerInfo.SuspendLayout();
            this.commonInfo.SuspendLayout();
            this.fileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Муниципальный контракт номер:";
            // 
            // contractNumber
            // 
            this.contractNumber.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contractNumber.Location = new System.Drawing.Point(383, 112);
            this.contractNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.Size = new System.Drawing.Size(435, 37);
            this.contractNumber.TabIndex = 2;
            this.contractNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractNumber_KeyPress);
            // 
            // cardInfo
            // 
            this.cardInfo.Controls.Add(this.mainInfo);
            this.cardInfo.Controls.Add(this.customerInfo);
            this.cardInfo.Controls.Add(this.commonInfo);
            this.cardInfo.Controls.Add(this.fileInfo);
            this.cardInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardInfo.Location = new System.Drawing.Point(0, 179);
            this.cardInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.SelectedIndex = 0;
            this.cardInfo.Size = new System.Drawing.Size(862, 323);
            this.cardInfo.TabIndex = 0;
            // 
            // mainInfo
            // 
            this.mainInfo.Controls.Add(this.dateTimePicker2);
            this.mainInfo.Controls.Add(this.dateTimePicker1);
            this.mainInfo.Controls.Add(this.label6);
            this.mainInfo.Controls.Add(this.label7);
            this.mainInfo.Controls.Add(this.textBox1);
            this.mainInfo.Controls.Add(this.label4);
            this.mainInfo.Controls.Add(this.textBox2);
            this.mainInfo.Controls.Add(this.label5);
            this.mainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInfo.Location = new System.Drawing.Point(4, 22);
            this.mainInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainInfo.Name = "mainInfo";
            this.mainInfo.Size = new System.Drawing.Size(854, 297);
            this.mainInfo.TabIndex = 0;
            this.mainInfo.Text = "Общая информация";
            this.mainInfo.UseVisualStyleBackColor = true;
            // 
            // customerInfo
            // 
            this.customerInfo.Controls.Add(this.nameMo);
            this.customerInfo.Controls.Add(this.label3);
            this.customerInfo.Controls.Add(this.nameOmsu);
            this.customerInfo.Controls.Add(this.label2);
            this.customerInfo.Location = new System.Drawing.Point(4, 22);
            this.customerInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(854, 297);
            this.customerInfo.TabIndex = 0;
            this.customerInfo.Text = "Заказчик";
            this.customerInfo.UseVisualStyleBackColor = true;
            // 
            // commonInfo
            // 
            this.commonInfo.Controls.Add(this.maskedTextBox4);
            this.commonInfo.Controls.Add(this.maskedTextBox3);
            this.commonInfo.Controls.Add(this.maskedTextBox2);
            this.commonInfo.Controls.Add(this.maskedTextBox1);
            this.commonInfo.Controls.Add(this.label15);
            this.commonInfo.Controls.Add(this.label14);
            this.commonInfo.Controls.Add(this.label13);
            this.commonInfo.Controls.Add(this.label12);
            this.commonInfo.Controls.Add(this.subvenceYear);
            this.commonInfo.Controls.Add(this.label8);
            this.commonInfo.Controls.Add(this.label9);
            this.commonInfo.Controls.Add(this.label10);
            this.commonInfo.Controls.Add(this.label11);
            this.commonInfo.Location = new System.Drawing.Point(4, 22);
            this.commonInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commonInfo.Name = "commonInfo";
            this.commonInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commonInfo.Size = new System.Drawing.Size(854, 297);
            this.commonInfo.TabIndex = 1;
            this.commonInfo.Text = "Общие данные";
            this.commonInfo.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.changeButton.Location = new System.Drawing.Point(17, 17);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(122, 32);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Window;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(862, 70);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(168, 17);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 32);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Firebrick;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelButton.Location = new System.Drawing.Point(316, 17);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 32);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // nameMo
            // 
            this.nameMo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameMo.Location = new System.Drawing.Point(13, 191);
            this.nameMo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameMo.Multiline = true;
            this.nameMo.Name = "nameMo";
            this.nameMo.Size = new System.Drawing.Size(500, 82);
            this.nameMo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Муниципальное образование";
            // 
            // nameOmsu
            // 
            this.nameOmsu.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOmsu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameOmsu.Location = new System.Drawing.Point(13, 44);
            this.nameOmsu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameOmsu.Multiline = true;
            this.nameOmsu.Name = "nameOmsu";
            this.nameOmsu.Size = new System.Drawing.Size(500, 82);
            this.nameOmsu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование Органа местного самоуправления";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(13, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 82);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Исполнитель МК";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(13, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 82);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Место оказания услуги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(598, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата действия МК";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(598, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата заключения МК";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(602, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(602, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(560, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 43);
            this.label8.TabIndex = 25;
            this.label8.Text = "Доля субвенции в цене контракта:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(564, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 42);
            this.label9.TabIndex = 24;
            this.label9.Text = "Год, на который выдана субвенция: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(425, 49);
            this.label10.TabIndex = 22;
            this.label10.Text = "Объём денежных средств, выплаченных Исполнителю по контракту";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Цена контракта";
            // 
            // subvenceYear
            // 
            this.subvenceYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subvenceYear.Location = new System.Drawing.Point(749, 26);
            this.subvenceYear.Mask = "0000";
            this.subvenceYear.Name = "subvenceYear";
            this.subvenceYear.Size = new System.Drawing.Size(49, 26);
            this.subvenceYear.TabIndex = 28;
            this.subvenceYear.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(804, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "г.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(803, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(564, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 80);
            this.label14.TabIndex = 32;
            this.label14.Text = "Доля денежных средств из субвенции, выплаченной по контракту:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(803, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "%";
            // 
            // fileInfo
            // 
            this.fileInfo.Controls.Add(this.pictureBox1);
            this.fileInfo.Controls.Add(this.downloadFile);
            this.fileInfo.Location = new System.Drawing.Point(4, 22);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Padding = new System.Windows.Forms.Padding(3);
            this.fileInfo.Size = new System.Drawing.Size(854, 297);
            this.fileInfo.TabIndex = 2;
            this.fileInfo.Text = "Файл контракта";
            this.fileInfo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(13, 216);
            this.maskedTextBox1.Mask = "$999,999,999.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 30);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(13, 44);
            this.maskedTextBox2.Mask = "$999,999,999.00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(159, 30);
            this.maskedTextBox2.TabIndex = 35;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox3.Location = new System.Drawing.Point(749, 114);
            this.maskedTextBox3.Mask = "099";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(49, 26);
            this.maskedTextBox3.TabIndex = 36;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox4.Location = new System.Drawing.Point(749, 206);
            this.maskedTextBox4.Mask = "099";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(49, 26);
            this.maskedTextBox4.TabIndex = 37;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // downloadFile
            // 
            this.downloadFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.downloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFile.ForeColor = System.Drawing.SystemColors.Window;
            this.downloadFile.Location = new System.Drawing.Point(13, 22);
            this.downloadFile.Margin = new System.Windows.Forms.Padding(2);
            this.downloadFile.Name = "downloadFile";
            this.downloadFile.Size = new System.Drawing.Size(122, 32);
            this.downloadFile.TabIndex = 11;
            this.downloadFile.Text = "Загрузить файл";
            this.downloadFile.UseVisualStyleBackColor = false;
            this.downloadFile.Click += new System.EventHandler(this.downloadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(286, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 132);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // recordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.cardInfo);
            this.Controls.Add(this.contractNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "recordCard";
            this.Text = "Учётная карточка";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cardInfo.ResumeLayout(false);
            this.mainInfo.ResumeLayout(false);
            this.mainInfo.PerformLayout();
            this.customerInfo.ResumeLayout(false);
            this.customerInfo.PerformLayout();
            this.commonInfo.ResumeLayout(false);
            this.commonInfo.PerformLayout();
            this.fileInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contractNumber;
        private System.Windows.Forms.TabControl cardInfo;
        private System.Windows.Forms.TabPage mainInfo;
        private System.Windows.Forms.TabPage customerInfo;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage commonInfo;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameMo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameOmsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox subvenceYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage fileInfo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button downloadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}