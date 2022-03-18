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
            this.login = new System.Windows.Forms.TextBox();
            this.cardInfo = new System.Windows.Forms.TabControl();
            this.mainInfo = new System.Windows.Forms.TabPage();
            this.customerInfo = new System.Windows.Forms.TabPage();
            this.commonInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.cardInfo.SuspendLayout();
            this.mainInfo.SuspendLayout();
            this.customerInfo.SuspendLayout();
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
            // login
            // 
            this.login.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.login.Location = new System.Drawing.Point(383, 112);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(435, 37);
            this.login.TabIndex = 2;
            // 
            // cardInfo
            // 
            this.cardInfo.Controls.Add(this.mainInfo);
            this.cardInfo.Controls.Add(this.customerInfo);
            this.cardInfo.Controls.Add(this.commonInfo);
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
            this.commonInfo.Location = new System.Drawing.Point(4, 22);
            this.commonInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commonInfo.Name = "commonInfo";
            this.commonInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commonInfo.Size = new System.Drawing.Size(854, 297);
            this.commonInfo.TabIndex = 1;
            this.commonInfo.Text = "Общие данные";
            this.commonInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(862, 70);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "Отменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // nameMo
            // 
            this.nameMo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameMo.Location = new System.Drawing.Point(13, 191);
            this.nameMo.Margin = new System.Windows.Forms.Padding(2);
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
            this.nameOmsu.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
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
            this.label6.Location = new System.Drawing.Point(598, 80);
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
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(602, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // recordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardInfo);
            this.Controls.Add(this.login);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TabControl cardInfo;
        private System.Windows.Forms.TabPage mainInfo;
        private System.Windows.Forms.TabPage customerInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage commonInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
    }
}