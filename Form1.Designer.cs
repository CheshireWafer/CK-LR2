
namespace ЛР2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контейнерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеганоконтейнерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеганоконтейнерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cipher_LSB = new System.Windows.Forms.Button();
            this.decipher_LSB = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.resultValue = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LSB = new System.Windows.Forms.RadioButton();
            this.Koha_Zhao = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1693, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 29);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контейнерToolStripMenuItem,
            this.сообщениеToolStripMenuItem,
            this.стеганоконтейнерToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // контейнерToolStripMenuItem
            // 
            this.контейнерToolStripMenuItem.Name = "контейнерToolStripMenuItem";
            this.контейнерToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.контейнерToolStripMenuItem.Text = "Контейнер";
            this.контейнерToolStripMenuItem.Click += new System.EventHandler(this.контейнерToolStripMenuItem_Click);
            // 
            // сообщениеToolStripMenuItem
            // 
            this.сообщениеToolStripMenuItem.Name = "сообщениеToolStripMenuItem";
            this.сообщениеToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.сообщениеToolStripMenuItem.Text = "Сообщение";
            this.сообщениеToolStripMenuItem.Click += new System.EventHandler(this.сообщениеToolStripMenuItem_Click_1);
            // 
            // стеганоконтейнерToolStripMenuItem
            // 
            this.стеганоконтейнерToolStripMenuItem.Name = "стеганоконтейнерToolStripMenuItem";
            this.стеганоконтейнерToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.стеганоконтейнерToolStripMenuItem.Text = "Стеганоконтейнер";
            this.стеганоконтейнерToolStripMenuItem.Click += new System.EventHandler(this.стеганоконтейнерToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стеганоконтейнерToolStripMenuItem1,
            this.сообщениеToolStripMenuItem1});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // стеганоконтейнерToolStripMenuItem1
            // 
            this.стеганоконтейнерToolStripMenuItem1.Name = "стеганоконтейнерToolStripMenuItem1";
            this.стеганоконтейнерToolStripMenuItem1.Size = new System.Drawing.Size(264, 34);
            this.стеганоконтейнерToolStripMenuItem1.Text = "Стеганоконтейнер";
            this.стеганоконтейнерToolStripMenuItem1.Click += new System.EventHandler(this.стеганоконтейнерToolStripMenuItem1_Click);
            // 
            // сообщениеToolStripMenuItem1
            // 
            this.сообщениеToolStripMenuItem1.Name = "сообщениеToolStripMenuItem1";
            this.сообщениеToolStripMenuItem1.Size = new System.Drawing.Size(264, 34);
            this.сообщениеToolStripMenuItem1.Text = "Сообщение";
            this.сообщениеToolStripMenuItem1.Click += new System.EventHandler(this.сообщениеToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(99, 29);
            this.toolStripDropDownButton2.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 336);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Контейнер";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(506, 336);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стеганоконтейнер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(562, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сообщение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 151);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(562, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стегоключ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 265);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(506, 151);
            this.textBox2.TabIndex = 9;
            // 
            // cipher_LSB
            // 
            this.cipher_LSB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cipher_LSB.Location = new System.Drawing.Point(1111, 265);
            this.cipher_LSB.Name = "cipher_LSB";
            this.cipher_LSB.Size = new System.Drawing.Size(183, 61);
            this.cipher_LSB.TabIndex = 10;
            this.cipher_LSB.Text = "Зашифровать";
            this.cipher_LSB.UseVisualStyleBackColor = true;
            this.cipher_LSB.Click += new System.EventHandler(this.cipher_LSB_Click);
            // 
            // decipher_LSB
            // 
            this.decipher_LSB.Location = new System.Drawing.Point(1341, 265);
            this.decipher_LSB.Name = "decipher_LSB";
            this.decipher_LSB.Size = new System.Drawing.Size(183, 61);
            this.decipher_LSB.TabIndex = 11;
            this.decipher_LSB.Text = "Дешифровать";
            this.decipher_LSB.UseVisualStyleBackColor = true;
            this.decipher_LSB.Click += new System.EventHandler(this.decipher_LSB_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1341, 355);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 61);
            this.textBox3.TabIndex = 12;
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(1111, 355);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(183, 61);
            this.resultValue.TabIndex = 13;
            this.resultValue.Text = "Оценка результата шифрования";
            this.resultValue.UseVisualStyleBackColor = true;
            this.resultValue.Click += new System.EventHandler(this.resultValue_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(562, 472);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(506, 336);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(562, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выделение позиций сообщения";
            // 
            // LSB
            // 
            this.LSB.AutoSize = true;
            this.LSB.Location = new System.Drawing.Point(1111, 166);
            this.LSB.Name = "LSB";
            this.LSB.Size = new System.Drawing.Size(128, 29);
            this.LSB.TabIndex = 16;
            this.LSB.TabStop = true;
            this.LSB.Text = "Метод НЗБ";
            this.LSB.UseVisualStyleBackColor = true;
            // 
            // Koha_Zhao
            // 
            this.Koha_Zhao.AutoSize = true;
            this.Koha_Zhao.Location = new System.Drawing.Point(1111, 201);
            this.Koha_Zhao.Name = "Koha_Zhao";
            this.Koha_Zhao.Size = new System.Drawing.Size(181, 29);
            this.Koha_Zhao.TabIndex = 17;
            this.Koha_Zhao.TabStop = true;
            this.Koha_Zhao.Text = " Метод Коха-Жао";
            this.Koha_Zhao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 862);
            this.Controls.Add(this.Koha_Zhao);
            this.Controls.Add(this.LSB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.decipher_LSB);
            this.Controls.Add(this.cipher_LSB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контейнерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеганоконтейнерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеганоконтейнерToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сообщениеToolStripMenuItem1;
        private System.Windows.Forms.Button cipher_LSB;
        private System.Windows.Forms.Button decipher_LSB;
        private System.Windows.Forms.ToolStripMenuItem сообщениеToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button resultValue;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton LSB;
        private System.Windows.Forms.RadioButton Koha_Zhao;
    }
}

