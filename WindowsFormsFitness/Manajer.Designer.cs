﻿namespace WindowsFormsFitness
{
    partial class Manajer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manajer));
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Найти = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AddClients = new System.Windows.Forms.TabPage();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.redact_client = new System.Windows.Forms.TabPage();
            this.materialTextBox11 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox13 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox14 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox15 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox16 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox17 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox18 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox19 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.dogovor = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.materialTextBox12 = new MaterialSkin.Controls.MaterialTextBox();
            this.goods = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl2.SuspendLayout();
            this.home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddClients.SuspendLayout();
            this.redact_client.SuspendLayout();
            this.dogovor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.home);
            this.materialTabControl2.Controls.Add(this.AddClients);
            this.materialTabControl2.Controls.Add(this.redact_client);
            this.materialTabControl2.Controls.Add(this.dogovor);
            this.materialTabControl2.Controls.Add(this.goods);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl2.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.materialTabControl2.ImageList = this.imageList1;
            this.materialTabControl2.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1394, 733);
            this.materialTabControl2.TabIndex = 3;
            // 
            // home
            // 
            this.home.Controls.Add(this.button1);
            this.home.Controls.Add(this.Удалить);
            this.home.Controls.Add(this.Найти);
            this.home.Controls.Add(this.dataGridView1);
            this.home.Controls.Add(this.materialTextBox1);
            this.home.Controls.Add(this.materialLabel1);
            this.home.ImageKey = "home.png";
            this.home.Location = new System.Drawing.Point(4, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1386, 690);
            this.home.TabIndex = 0;
            this.home.Text = " Главная";
            this.home.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(849, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Удалить
            // 
            this.Удалить.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Удалить.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Удалить.Location = new System.Drawing.Point(1137, 18);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(138, 49);
            this.Удалить.TabIndex = 6;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = true;
            // 
            // Найти
            // 
            this.Найти.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Найти.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Найти.Location = new System.Drawing.Point(993, 17);
            this.Найти.Name = "Найти";
            this.Найти.Size = new System.Drawing.Size(138, 49);
            this.Найти.TabIndex = 5;
            this.Найти.Text = "Найти";
            this.Найти.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1259, 516);
            this.dataGridView1.TabIndex = 4;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Введите данные пользователя";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(16, 17);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(827, 50);
            this.materialTextBox1.TabIndex = 3;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(1639, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // AddClients
            // 
            this.AddClients.Controls.Add(this.materialTextBox9);
            this.AddClients.Controls.Add(this.button2);
            this.AddClients.Controls.Add(this.materialTextBox10);
            this.AddClients.Controls.Add(this.materialTextBox7);
            this.AddClients.Controls.Add(this.materialTextBox8);
            this.AddClients.Controls.Add(this.materialTextBox6);
            this.AddClients.Controls.Add(this.materialTextBox5);
            this.AddClients.Controls.Add(this.materialTextBox4);
            this.AddClients.Controls.Add(this.materialTextBox3);
            this.AddClients.ImageKey = "add-user.png";
            this.AddClients.Location = new System.Drawing.Point(4, 39);
            this.AddClients.Name = "AddClients";
            this.AddClients.Size = new System.Drawing.Size(1386, 690);
            this.AddClients.TabIndex = 7;
            this.AddClients.Text = "Добавить сотрудника";
            this.AddClients.UseVisualStyleBackColor = true;
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.AnimateReadOnly = false;
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox9.Hint = "Адрес";
            this.materialTextBox9.LeadingIcon = null;
            this.materialTextBox9.Location = new System.Drawing.Point(674, 181);
            this.materialTextBox9.MaxLength = 50;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(545, 50);
            this.materialTextBox9.TabIndex = 16;
            this.materialTextBox9.Text = "";
            this.materialTextBox9.TrailingIcon = null;
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(997, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // materialTextBox10
            // 
            this.materialTextBox10.AnimateReadOnly = false;
            this.materialTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox10.Depth = 0;
            this.materialTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox10.Hint = "Должность";
            this.materialTextBox10.LeadingIcon = null;
            this.materialTextBox10.Location = new System.Drawing.Point(674, 287);
            this.materialTextBox10.MaxLength = 50;
            this.materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox10.Multiline = false;
            this.materialTextBox10.Name = "materialTextBox10";
            this.materialTextBox10.Size = new System.Drawing.Size(545, 50);
            this.materialTextBox10.TabIndex = 12;
            this.materialTextBox10.Text = "";
            this.materialTextBox10.TrailingIcon = null;
            // 
            // materialTextBox7
            // 
            this.materialTextBox7.AnimateReadOnly = false;
            this.materialTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox7.Depth = 0;
            this.materialTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox7.Hint = "Зарплата";
            this.materialTextBox7.LeadingIcon = null;
            this.materialTextBox7.Location = new System.Drawing.Point(674, 403);
            this.materialTextBox7.MaxLength = 50;
            this.materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox7.Multiline = false;
            this.materialTextBox7.Name = "materialTextBox7";
            this.materialTextBox7.Size = new System.Drawing.Size(545, 50);
            this.materialTextBox7.TabIndex = 10;
            this.materialTextBox7.Text = "";
            this.materialTextBox7.TrailingIcon = null;
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.AnimateReadOnly = false;
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox8.Hint = "Номер телефона";
            this.materialTextBox8.LeadingIcon = null;
            this.materialTextBox8.Location = new System.Drawing.Point(25, 402);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(534, 50);
            this.materialTextBox8.TabIndex = 6;
            this.materialTextBox8.Text = "";
            this.materialTextBox8.TrailingIcon = null;
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.Hint = "Отчество";
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(25, 287);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(534, 50);
            this.materialTextBox6.TabIndex = 4;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox5.Hint = "Имя";
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(25, 181);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(534, 50);
            this.materialTextBox5.TabIndex = 3;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.Hint = "Фамилия";
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(25, 62);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(534, 50);
            this.materialTextBox4.TabIndex = 2;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Паспорт";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(674, 62);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(545, 50);
            this.materialTextBox3.TabIndex = 1;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // redact_client
            // 
            this.redact_client.Controls.Add(this.materialTextBox11);
            this.redact_client.Controls.Add(this.materialTextBox13);
            this.redact_client.Controls.Add(this.materialTextBox14);
            this.redact_client.Controls.Add(this.materialTextBox15);
            this.redact_client.Controls.Add(this.materialTextBox16);
            this.redact_client.Controls.Add(this.materialTextBox17);
            this.redact_client.Controls.Add(this.materialTextBox18);
            this.redact_client.Controls.Add(this.materialTextBox19);
            this.redact_client.Controls.Add(this.materialTextBox21);
            this.redact_client.Controls.Add(this.button8);
            this.redact_client.ImageKey = "premium-icon-repair-2907922.png";
            this.redact_client.Location = new System.Drawing.Point(4, 39);
            this.redact_client.Name = "redact_client";
            this.redact_client.Size = new System.Drawing.Size(1386, 690);
            this.redact_client.TabIndex = 8;
            this.redact_client.Text = "Редактирование сотрудника";
            this.redact_client.UseVisualStyleBackColor = true;
            // 
            // materialTextBox11
            // 
            this.materialTextBox11.AnimateReadOnly = false;
            this.materialTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox11.Depth = 0;
            this.materialTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox11.Hint = "Адрес";
            this.materialTextBox11.LeadingIcon = null;
            this.materialTextBox11.Location = new System.Drawing.Point(671, 199);
            this.materialTextBox11.MaxLength = 50;
            this.materialTextBox11.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox11.Multiline = false;
            this.materialTextBox11.Name = "materialTextBox11";
            this.materialTextBox11.Size = new System.Drawing.Size(522, 50);
            this.materialTextBox11.TabIndex = 36;
            this.materialTextBox11.Text = "";
            this.materialTextBox11.TrailingIcon = null;
            // 
            // materialTextBox13
            // 
            this.materialTextBox13.AnimateReadOnly = false;
            this.materialTextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox13.Depth = 0;
            this.materialTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox13.Hint = "Должность";
            this.materialTextBox13.LeadingIcon = null;
            this.materialTextBox13.Location = new System.Drawing.Point(671, 305);
            this.materialTextBox13.MaxLength = 50;
            this.materialTextBox13.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox13.Multiline = false;
            this.materialTextBox13.Name = "materialTextBox13";
            this.materialTextBox13.Size = new System.Drawing.Size(522, 50);
            this.materialTextBox13.TabIndex = 35;
            this.materialTextBox13.Text = "";
            this.materialTextBox13.TrailingIcon = null;
            // 
            // materialTextBox14
            // 
            this.materialTextBox14.AnimateReadOnly = false;
            this.materialTextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox14.Depth = 0;
            this.materialTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox14.Hint = "Зарплата";
            this.materialTextBox14.LeadingIcon = null;
            this.materialTextBox14.Location = new System.Drawing.Point(671, 421);
            this.materialTextBox14.MaxLength = 50;
            this.materialTextBox14.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox14.Multiline = false;
            this.materialTextBox14.Name = "materialTextBox14";
            this.materialTextBox14.Size = new System.Drawing.Size(522, 50);
            this.materialTextBox14.TabIndex = 34;
            this.materialTextBox14.Text = "";
            this.materialTextBox14.TrailingIcon = null;
            // 
            // materialTextBox15
            // 
            this.materialTextBox15.AnimateReadOnly = false;
            this.materialTextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox15.Depth = 0;
            this.materialTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox15.Hint = "Номер телефона";
            this.materialTextBox15.LeadingIcon = null;
            this.materialTextBox15.Location = new System.Drawing.Point(51, 452);
            this.materialTextBox15.MaxLength = 50;
            this.materialTextBox15.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox15.Multiline = false;
            this.materialTextBox15.Name = "materialTextBox15";
            this.materialTextBox15.Size = new System.Drawing.Size(510, 50);
            this.materialTextBox15.TabIndex = 33;
            this.materialTextBox15.Text = "";
            this.materialTextBox15.TrailingIcon = null;
            // 
            // materialTextBox16
            // 
            this.materialTextBox16.AnimateReadOnly = false;
            this.materialTextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox16.Depth = 0;
            this.materialTextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox16.Hint = "Отчество";
            this.materialTextBox16.LeadingIcon = null;
            this.materialTextBox16.Location = new System.Drawing.Point(51, 337);
            this.materialTextBox16.MaxLength = 50;
            this.materialTextBox16.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox16.Multiline = false;
            this.materialTextBox16.Name = "materialTextBox16";
            this.materialTextBox16.Size = new System.Drawing.Size(510, 50);
            this.materialTextBox16.TabIndex = 32;
            this.materialTextBox16.Text = "";
            this.materialTextBox16.TrailingIcon = null;
            // 
            // materialTextBox17
            // 
            this.materialTextBox17.AnimateReadOnly = false;
            this.materialTextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox17.Depth = 0;
            this.materialTextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox17.Hint = "Имя";
            this.materialTextBox17.LeadingIcon = null;
            this.materialTextBox17.Location = new System.Drawing.Point(51, 231);
            this.materialTextBox17.MaxLength = 50;
            this.materialTextBox17.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox17.Multiline = false;
            this.materialTextBox17.Name = "materialTextBox17";
            this.materialTextBox17.Size = new System.Drawing.Size(510, 50);
            this.materialTextBox17.TabIndex = 31;
            this.materialTextBox17.Text = "";
            this.materialTextBox17.TrailingIcon = null;
            // 
            // materialTextBox18
            // 
            this.materialTextBox18.AnimateReadOnly = false;
            this.materialTextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox18.Depth = 0;
            this.materialTextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox18.Hint = "Фамилия";
            this.materialTextBox18.LeadingIcon = null;
            this.materialTextBox18.Location = new System.Drawing.Point(51, 139);
            this.materialTextBox18.MaxLength = 50;
            this.materialTextBox18.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox18.Multiline = false;
            this.materialTextBox18.Name = "materialTextBox18";
            this.materialTextBox18.Size = new System.Drawing.Size(510, 50);
            this.materialTextBox18.TabIndex = 30;
            this.materialTextBox18.Text = "";
            this.materialTextBox18.TrailingIcon = null;
            // 
            // materialTextBox19
            // 
            this.materialTextBox19.AnimateReadOnly = false;
            this.materialTextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox19.Depth = 0;
            this.materialTextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox19.Hint = "Паспорт";
            this.materialTextBox19.LeadingIcon = null;
            this.materialTextBox19.Location = new System.Drawing.Point(671, 79);
            this.materialTextBox19.MaxLength = 50;
            this.materialTextBox19.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox19.Multiline = false;
            this.materialTextBox19.Name = "materialTextBox19";
            this.materialTextBox19.Size = new System.Drawing.Size(522, 50);
            this.materialTextBox19.TabIndex = 29;
            this.materialTextBox19.Text = "";
            this.materialTextBox19.TrailingIcon = null;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.Hint = "ID";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(51, 35);
            this.materialTextBox21.MaxLength = 50;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Multiline = false;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.Size = new System.Drawing.Size(510, 50);
            this.materialTextBox21.TabIndex = 28;
            this.materialTextBox21.Text = "";
            this.materialTextBox21.TrailingIcon = null;
            // 
            // button8
            // 
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(971, 531);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(222, 45);
            this.button8.TabIndex = 26;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dogovor
            // 
            this.dogovor.Controls.Add(this.button7);
            this.dogovor.Controls.Add(this.dataGridView4);
            this.dogovor.Controls.Add(this.materialTextBox12);
            this.dogovor.ImageKey = "clipboard.png";
            this.dogovor.Location = new System.Drawing.Point(4, 39);
            this.dogovor.Name = "dogovor";
            this.dogovor.Size = new System.Drawing.Size(1386, 690);
            this.dogovor.TabIndex = 2;
            this.dogovor.Text = " Договор";
            this.dogovor.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(1081, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(191, 49);
            this.button7.TabIndex = 12;
            this.button7.Text = "Найти";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(18, 86);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1254, 526);
            this.dataGridView4.TabIndex = 11;
            // 
            // materialTextBox12
            // 
            this.materialTextBox12.AnimateReadOnly = false;
            this.materialTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox12.Depth = 0;
            this.materialTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox12.Hint = "Введите данные услуги";
            this.materialTextBox12.LeadingIcon = null;
            this.materialTextBox12.Location = new System.Drawing.Point(18, 17);
            this.materialTextBox12.MaxLength = 50;
            this.materialTextBox12.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox12.Multiline = false;
            this.materialTextBox12.Name = "materialTextBox12";
            this.materialTextBox12.Size = new System.Drawing.Size(1046, 50);
            this.materialTextBox12.TabIndex = 10;
            this.materialTextBox12.Text = "";
            this.materialTextBox12.TrailingIcon = null;
            // 
            // goods
            // 
            this.goods.Controls.Add(this.button5);
            this.goods.Controls.Add(this.button6);
            this.goods.Controls.Add(this.dataGridView2);
            this.goods.Controls.Add(this.materialTextBox2);
            this.goods.ImageKey = "product (1).png";
            this.goods.Location = new System.Drawing.Point(4, 39);
            this.goods.Name = "goods";
            this.goods.Size = new System.Drawing.Size(1386, 690);
            this.goods.TabIndex = 5;
            this.goods.Text = " Товары";
            this.goods.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(1082, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "Продать";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(885, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1255, 555);
            this.dataGridView2.TabIndex = 9;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Введите данные услуги";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(18, 21);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(860, 50);
            this.materialTextBox2.TabIndex = 8;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-user.png");
            this.imageList1.Images.SetKeyName(1, "clipboard.png");
            this.imageList1.Images.SetKeyName(2, "free-icon-fitness-1689458.png");
            this.imageList1.Images.SetKeyName(3, "free-icon-ruble-1867984.png");
            this.imageList1.Images.SetKeyName(4, "free-icon-shake-hands-3908041.png");
            this.imageList1.Images.SetKeyName(5, "home.png");
            this.imageList1.Images.SetKeyName(6, "premium-icon-customer-review-4288943.png");
            this.imageList1.Images.SetKeyName(7, "premium-icon-fitness-726860.png");
            this.imageList1.Images.SetKeyName(8, "premium-icon-repair-2907922.png");
            this.imageList1.Images.SetKeyName(9, "premium-icon-shopping-online-4791682.png");
            this.imageList1.Images.SetKeyName(10, "product (1).png");
            // 
            // Manajer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.materialTabControl2);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl2;
            this.Name = "Manajer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manajer";
            this.Load += new System.EventHandler(this.Manajer_Load);
            this.materialTabControl2.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AddClients.ResumeLayout(false);
            this.redact_client.ResumeLayout(false);
            this.dogovor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.goods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Найти;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage AddClients;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private System.Windows.Forms.TabPage redact_client;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox11;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox13;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox14;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox15;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox16;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox17;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox18;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox19;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox21;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage dogovor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox12;
        private System.Windows.Forms.TabPage goods;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private System.Windows.Forms.ImageList imageList1;
    }
}