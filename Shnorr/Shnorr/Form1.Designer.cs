
namespace Shnorr
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
            this.sourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.signFilePathTextBox = new System.Windows.Forms.TextBox();
            this.srcFile = new System.Windows.Forms.Button();
            this.signFile = new System.Windows.Forms.Button();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.signbutton = new System.Windows.Forms.Button();
            this.checkbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_w = new System.Windows.Forms.TextBox();
            this.textBox_v = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Rand = new System.Windows.Forms.Button();
            this.RandAV = new System.Windows.Forms.Button();
            this.CalcV = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceFilePathTextBox
            // 
            this.sourceFilePathTextBox.Location = new System.Drawing.Point(29, 50);
            this.sourceFilePathTextBox.Name = "sourceFilePathTextBox";
            this.sourceFilePathTextBox.Size = new System.Drawing.Size(361, 26);
            this.sourceFilePathTextBox.TabIndex = 0;
            // 
            // signFilePathTextBox
            // 
            this.signFilePathTextBox.Location = new System.Drawing.Point(29, 119);
            this.signFilePathTextBox.Name = "signFilePathTextBox";
            this.signFilePathTextBox.Size = new System.Drawing.Size(356, 26);
            this.signFilePathTextBox.TabIndex = 1;
            // 
            // srcFile
            // 
            this.srcFile.Location = new System.Drawing.Point(476, 51);
            this.srcFile.Name = "srcFile";
            this.srcFile.Size = new System.Drawing.Size(168, 34);
            this.srcFile.TabIndex = 2;
            this.srcFile.Text = "Исходный файл";
            this.srcFile.UseVisualStyleBackColor = true;
            this.srcFile.Click += new System.EventHandler(this.srcFile_Click);
            // 
            // signFile
            // 
            this.signFile.Location = new System.Drawing.Point(479, 119);
            this.signFile.Name = "signFile";
            this.signFile.Size = new System.Drawing.Size(165, 34);
            this.signFile.TabIndex = 3;
            this.signFile.Text = "Файл протокола";
            this.signFile.UseVisualStyleBackColor = true;
            this.signFile.Click += new System.EventHandler(this.signFile_Click);
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(12, 285);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(126, 26);
            this.textBox_p.TabIndex = 4;
            this.textBox_p.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // signbutton
            // 
            this.signbutton.Location = new System.Drawing.Point(957, 328);
            this.signbutton.Name = "signbutton";
            this.signbutton.Size = new System.Drawing.Size(171, 56);
            this.signbutton.TabIndex = 6;
            this.signbutton.Text = "Подписать и сохранить протокол";
            this.signbutton.UseVisualStyleBackColor = true;
            this.signbutton.Click += new System.EventHandler(this.signbutton_Click);
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(6, 527);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(224, 35);
            this.checkbutton.TabIndex = 7;
            this.checkbutton.Text = "Проверить подпись";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Простое число p";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(192, 285);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(142, 26);
            this.textBox_q.TabIndex = 12;
            this.textBox_q.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(401, 285);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(141, 26);
            this.textBox_a.TabIndex = 13;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Число q";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Число a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Закрытый ключ w";
            // 
            // textBox_w
            // 
            this.textBox_w.Location = new System.Drawing.Point(574, 285);
            this.textBox_w.Name = "textBox_w";
            this.textBox_w.Size = new System.Drawing.Size(136, 26);
            this.textBox_w.TabIndex = 17;
            this.textBox_w.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_v
            // 
            this.textBox_v.Location = new System.Drawing.Point(745, 285);
            this.textBox_v.Name = "textBox_v";
            this.textBox_v.Size = new System.Drawing.Size(142, 26);
            this.textBox_v.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(746, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Открытый ключ v";
            // 
            // Rand
            // 
            this.Rand.Enabled = false;
            this.Rand.Location = new System.Drawing.Point(192, 327);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(142, 35);
            this.Rand.TabIndex = 28;
            this.Rand.Text = "Подобрать q";
            this.Rand.UseVisualStyleBackColor = true;
            this.Rand.Click += new System.EventHandler(this.Rand_Click);
            // 
            // RandAV
            // 
            this.RandAV.Enabled = false;
            this.RandAV.Location = new System.Drawing.Point(401, 328);
            this.RandAV.Name = "RandAV";
            this.RandAV.Size = new System.Drawing.Size(141, 34);
            this.RandAV.TabIndex = 29;
            this.RandAV.Text = "Подобрать a";
            this.RandAV.UseVisualStyleBackColor = true;
            this.RandAV.Click += new System.EventHandler(this.RandAV_Click);
            // 
            // CalcV
            // 
            this.CalcV.Enabled = false;
            this.CalcV.Location = new System.Drawing.Point(748, 327);
            this.CalcV.Name = "CalcV";
            this.CalcV.Size = new System.Drawing.Size(139, 33);
            this.CalcV.TabIndex = 30;
            this.CalcV.Text = "Вычислить V";
            this.CalcV.UseVisualStyleBackColor = true;
            this.CalcV.Click += new System.EventHandler(this.CalcV_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(0, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Генерация ключей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(902, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Генерация подписи";
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(980, 285);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(100, 26);
            this.textBox_r.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(953, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Случайное число r";
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(10, 467);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(128, 26);
            this.textBox_e.TabIndex = 36;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(192, 467);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(142, 26);
            this.textBox_y.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Подпись e";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Подпись y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "p-1 должно делиться на q";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "a^q = 1 {mod p}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(618, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "w<q";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(753, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "v=a^(q-w) {mod p}";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(0, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 32);
            this.label15.TabIndex = 44;
            this.label15.Text = "Проверка подписи";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 403);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "(Требуется так же ввести p,q,a,v)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(997, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "0<r<q";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcV);
            this.Controls.Add(this.RandAV);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_v);
            this.Controls.Add(this.textBox_w);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.signbutton);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.signFile);
            this.Controls.Add(this.srcFile);
            this.Controls.Add(this.signFilePathTextBox);
            this.Controls.Add(this.sourceFilePathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Электронная цифровая подпись Шнорра";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceFilePathTextBox;
        private System.Windows.Forms.TextBox signFilePathTextBox;
        private System.Windows.Forms.Button srcFile;
        private System.Windows.Forms.Button signFile;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Button signbutton;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_w;
        private System.Windows.Forms.TextBox textBox_v;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Rand;
        private System.Windows.Forms.Button RandAV;
        private System.Windows.Forms.Button CalcV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

