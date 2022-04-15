namespace ContractsList
{
    partial class RecordCardForm
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
            this.contractOmsu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contractPlace = new System.Windows.Forms.ComboBox();
            this.contractExecutor = new System.Windows.Forms.ComboBox();
            this.contractDuration = new System.Windows.Forms.DateTimePicker();
            this.contractDateCreate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.financesInfo = new System.Windows.Forms.TabPage();
            this.contractSubvenceExecutorPart = new System.Windows.Forms.MaskedTextBox();
            this.contractSubvencePricePart = new System.Windows.Forms.MaskedTextBox();
            this.contractPrice = new System.Windows.Forms.MaskedTextBox();
            this.contractExecutorPrice = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.contractSubvenceYear = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fileInfo = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.contractFilename = new System.Windows.Forms.LinkLabel();
            this.deleteFile = new System.Windows.Forms.Button();
            this.downloadFile = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cardInfo.SuspendLayout();
            this.mainInfo.SuspendLayout();
            this.financesInfo.SuspendLayout();
            this.fileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Муниципальный контракт номер:";
            // 
            // contractNumber
            // 
            this.contractNumber.Enabled = false;
            this.contractNumber.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contractNumber.Location = new System.Drawing.Point(511, 138);
            this.contractNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.Size = new System.Drawing.Size(579, 44);
            this.contractNumber.TabIndex = 2;
            this.contractNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractNumber_KeyPress);
            // 
            // cardInfo
            // 
            this.cardInfo.Controls.Add(this.mainInfo);
            this.cardInfo.Controls.Add(this.financesInfo);
            this.cardInfo.Controls.Add(this.fileInfo);
            this.cardInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardInfo.Location = new System.Drawing.Point(0, 220);
            this.cardInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.SelectedIndex = 0;
            this.cardInfo.Size = new System.Drawing.Size(1149, 398);
            this.cardInfo.TabIndex = 0;
            // 
            // mainInfo
            // 
            this.mainInfo.Controls.Add(this.contractOmsu);
            this.mainInfo.Controls.Add(this.label2);
            this.mainInfo.Controls.Add(this.contractPlace);
            this.mainInfo.Controls.Add(this.contractExecutor);
            this.mainInfo.Controls.Add(this.contractDuration);
            this.mainInfo.Controls.Add(this.contractDateCreate);
            this.mainInfo.Controls.Add(this.label6);
            this.mainInfo.Controls.Add(this.label7);
            this.mainInfo.Controls.Add(this.label4);
            this.mainInfo.Controls.Add(this.label5);
            this.mainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInfo.Location = new System.Drawing.Point(4, 25);
            this.mainInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainInfo.Name = "mainInfo";
            this.mainInfo.Size = new System.Drawing.Size(1141, 369);
            this.mainInfo.TabIndex = 0;
            this.mainInfo.Text = "Общая информация";
            this.mainInfo.UseVisualStyleBackColor = true;
            // 
            // contractOmsu
            // 
            this.contractOmsu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contractOmsu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contractOmsu.Enabled = false;
            this.contractOmsu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractOmsu.FormattingEnabled = true;
            this.contractOmsu.Items.AddRange(new object[] {
            "Администрация г.Тюмень",
            "ААААААААА"});
            this.contractOmsu.Location = new System.Drawing.Point(17, 267);
            this.contractOmsu.Margin = new System.Windows.Forms.Padding(4);
            this.contractOmsu.Name = "contractOmsu";
            this.contractOmsu.Size = new System.Drawing.Size(665, 37);
            this.contractOmsu.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Наименование Органа местного самоуправления";
            // 
            // contractPlace
            // 
            this.contractPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contractPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contractPlace.Enabled = false;
            this.contractPlace.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractPlace.FormattingEnabled = true;
            this.contractPlace.Items.AddRange(new object[] {
            "Тюмень",
            "Москва",
            "Владивосток"});
            this.contractPlace.Location = new System.Drawing.Point(17, 54);
            this.contractPlace.Margin = new System.Windows.Forms.Padding(4);
            this.contractPlace.Name = "contractPlace";
            this.contractPlace.Size = new System.Drawing.Size(665, 37);
            this.contractPlace.TabIndex = 21;
            // 
            // contractExecutor
            // 
            this.contractExecutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contractExecutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contractExecutor.Enabled = false;
            this.contractExecutor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractExecutor.FormattingEnabled = true;
            this.contractExecutor.Items.AddRange(new object[] {
            "автомобиль",
            "авианалет",
            "барбоскины",
            "функциональность",
            "цербер",
            "ковёр"});
            this.contractExecutor.Location = new System.Drawing.Point(17, 159);
            this.contractExecutor.Margin = new System.Windows.Forms.Padding(4);
            this.contractExecutor.Name = "contractExecutor";
            this.contractExecutor.Size = new System.Drawing.Size(665, 37);
            this.contractExecutor.TabIndex = 22;
            // 
            // contractDuration
            // 
            this.contractDuration.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractDuration.Enabled = false;
            this.contractDuration.Location = new System.Drawing.Point(803, 159);
            this.contractDuration.Margin = new System.Windows.Forms.Padding(4);
            this.contractDuration.Name = "contractDuration";
            this.contractDuration.Size = new System.Drawing.Size(265, 26);
            this.contractDuration.TabIndex = 25;
            // 
            // contractDateCreate
            // 
            this.contractDateCreate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractDateCreate.Enabled = false;
            this.contractDateCreate.Location = new System.Drawing.Point(803, 54);
            this.contractDateCreate.Margin = new System.Windows.Forms.Padding(4);
            this.contractDateCreate.Name = "contractDateCreate";
            this.contractDateCreate.Size = new System.Drawing.Size(265, 26);
            this.contractDateCreate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(797, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата действия МК";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(797, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата заключения МК";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Исполнитель МК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Место оказания услуги";
            // 
            // financesInfo
            // 
            this.financesInfo.Controls.Add(this.contractSubvenceExecutorPart);
            this.financesInfo.Controls.Add(this.contractSubvencePricePart);
            this.financesInfo.Controls.Add(this.contractPrice);
            this.financesInfo.Controls.Add(this.contractExecutorPrice);
            this.financesInfo.Controls.Add(this.label15);
            this.financesInfo.Controls.Add(this.label14);
            this.financesInfo.Controls.Add(this.label13);
            this.financesInfo.Controls.Add(this.label12);
            this.financesInfo.Controls.Add(this.contractSubvenceYear);
            this.financesInfo.Controls.Add(this.label8);
            this.financesInfo.Controls.Add(this.label9);
            this.financesInfo.Controls.Add(this.label10);
            this.financesInfo.Controls.Add(this.label11);
            this.financesInfo.Location = new System.Drawing.Point(4, 25);
            this.financesInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.financesInfo.Name = "financesInfo";
            this.financesInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.financesInfo.Size = new System.Drawing.Size(1141, 369);
            this.financesInfo.TabIndex = 1;
            this.financesInfo.Text = "Финансы";
            this.financesInfo.UseVisualStyleBackColor = true;
            // 
            // contractSubvenceExecutorPart
            // 
            this.contractSubvenceExecutorPart.Enabled = false;
            this.contractSubvenceExecutorPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractSubvenceExecutorPart.Location = new System.Drawing.Point(907, 257);
            this.contractSubvenceExecutorPart.Margin = new System.Windows.Forms.Padding(4);
            this.contractSubvenceExecutorPart.Mask = "099";
            this.contractSubvenceExecutorPart.Name = "contractSubvenceExecutorPart";
            this.contractSubvenceExecutorPart.Size = new System.Drawing.Size(64, 30);
            this.contractSubvenceExecutorPart.TabIndex = 37;
            this.contractSubvenceExecutorPart.ValidatingType = typeof(System.DateTime);
            // 
            // contractSubvencePricePart
            // 
            this.contractSubvencePricePart.Enabled = false;
            this.contractSubvencePricePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractSubvencePricePart.Location = new System.Drawing.Point(907, 144);
            this.contractSubvencePricePart.Margin = new System.Windows.Forms.Padding(4);
            this.contractSubvencePricePart.Mask = "099";
            this.contractSubvencePricePart.Name = "contractSubvencePricePart";
            this.contractSubvencePricePart.Size = new System.Drawing.Size(64, 30);
            this.contractSubvencePricePart.TabIndex = 36;
            this.contractSubvencePricePart.ValidatingType = typeof(System.DateTime);
            // 
            // contractPrice
            // 
            this.contractPrice.Enabled = false;
            this.contractPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractPrice.Location = new System.Drawing.Point(17, 54);
            this.contractPrice.Margin = new System.Windows.Forms.Padding(4);
            this.contractPrice.Mask = "$999,999,999.00";
            this.contractPrice.Name = "contractPrice";
            this.contractPrice.Size = new System.Drawing.Size(211, 36);
            this.contractPrice.TabIndex = 35;
            // 
            // contractExecutorPrice
            // 
            this.contractExecutorPrice.Enabled = false;
            this.contractExecutorPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractExecutorPrice.Location = new System.Drawing.Point(17, 266);
            this.contractExecutorPrice.Margin = new System.Windows.Forms.Padding(4);
            this.contractExecutorPrice.Mask = "$999,999,999.00";
            this.contractExecutorPrice.Name = "contractExecutorPrice";
            this.contractExecutorPrice.Size = new System.Drawing.Size(211, 36);
            this.contractExecutorPrice.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(979, 261);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "%";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(655, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 98);
            this.label14.TabIndex = 32;
            this.label14.Text = "Доля денежных средств из субвенции, выплаченной по контракту:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(979, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(980, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "г.";
            // 
            // contractSubvenceYear
            // 
            this.contractSubvenceYear.Enabled = false;
            this.contractSubvenceYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractSubvenceYear.Location = new System.Drawing.Point(907, 36);
            this.contractSubvenceYear.Margin = new System.Windows.Forms.Padding(4);
            this.contractSubvenceYear.Mask = "0000";
            this.contractSubvenceYear.Name = "contractSubvenceYear";
            this.contractSubvenceYear.Size = new System.Drawing.Size(64, 30);
            this.contractSubvenceYear.TabIndex = 28;
            this.contractSubvenceYear.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(655, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 53);
            this.label8.TabIndex = 25;
            this.label8.Text = "Доля субвенции в цене контракта:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(655, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 52);
            this.label9.TabIndex = 24;
            this.label9.Text = "Год, на который выдана субвенция: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(567, 60);
            this.label10.TabIndex = 22;
            this.label10.Text = "Объём денежных средств, выплаченных Исполнителю по контракту";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Цена контракта";
            // 
            // fileInfo
            // 
            this.fileInfo.Controls.Add(this.label16);
            this.fileInfo.Controls.Add(this.contractFilename);
            this.fileInfo.Controls.Add(this.deleteFile);
            this.fileInfo.Controls.Add(this.downloadFile);
            this.fileInfo.Location = new System.Drawing.Point(4, 25);
            this.fileInfo.Margin = new System.Windows.Forms.Padding(4);
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Padding = new System.Windows.Forms.Padding(4);
            this.fileInfo.Size = new System.Drawing.Size(1141, 369);
            this.fileInfo.TabIndex = 2;
            this.fileInfo.Text = "Файл контракта";
            this.fileInfo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(12, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 29);
            this.label16.TabIndex = 21;
            this.label16.Text = "Загруженный файл";
            // 
            // contractFilename
            // 
            this.contractFilename.AutoSize = true;
            this.contractFilename.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractFilename.Location = new System.Drawing.Point(12, 68);
            this.contractFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractFilename.Name = "contractFilename";
            this.contractFilename.Size = new System.Drawing.Size(0, 24);
            this.contractFilename.TabIndex = 14;
            this.contractFilename.Click += new System.EventHandler(this.contractFilename_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.BackColor = System.Drawing.Color.Firebrick;
            this.deleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFile.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteFile.Location = new System.Drawing.Point(217, 183);
            this.deleteFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(163, 39);
            this.deleteFile.TabIndex = 13;
            this.deleteFile.Text = "Удалить файл";
            this.deleteFile.UseVisualStyleBackColor = false;
            // 
            // downloadFile
            // 
            this.downloadFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.downloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFile.ForeColor = System.Drawing.SystemColors.Window;
            this.downloadFile.Location = new System.Drawing.Point(17, 183);
            this.downloadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downloadFile.Name = "downloadFile";
            this.downloadFile.Size = new System.Drawing.Size(163, 39);
            this.downloadFile.TabIndex = 11;
            this.downloadFile.Text = "Загрузить файл";
            this.downloadFile.UseVisualStyleBackColor = false;
            this.downloadFile.Click += new System.EventHandler(this.downloadFile_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.changeButton.Location = new System.Drawing.Point(23, 21);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(163, 39);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Window;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1149, 86);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(223, 21);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 39);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Firebrick;
            this.cancelButton.Enabled = false;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelButton.Location = new System.Drawing.Point(421, 21);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 39);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // RecordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1149, 618);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.cardInfo);
            this.Controls.Add(this.contractNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecordCard";
            this.Text = "Учётная карточка";
            this.cardInfo.ResumeLayout(false);
            this.mainInfo.ResumeLayout(false);
            this.mainInfo.PerformLayout();
            this.financesInfo.ResumeLayout(false);
            this.financesInfo.PerformLayout();
            this.fileInfo.ResumeLayout(false);
            this.fileInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contractNumber;
        private System.Windows.Forms.TabControl cardInfo;
        private System.Windows.Forms.TabPage mainInfo;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage financesInfo;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker contractDuration;
        private System.Windows.Forms.DateTimePicker contractDateCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox contractSubvenceYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage fileInfo;
        private System.Windows.Forms.MaskedTextBox contractExecutorPrice;
        private System.Windows.Forms.MaskedTextBox contractSubvenceExecutorPart;
        private System.Windows.Forms.MaskedTextBox contractSubvencePricePart;
        private System.Windows.Forms.MaskedTextBox contractPrice;
        private System.Windows.Forms.Button downloadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel contractFilename;
        private System.Windows.Forms.ComboBox contractExecutor;
        private System.Windows.Forms.ComboBox contractOmsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox contractPlace;
    }
}