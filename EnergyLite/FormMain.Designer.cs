
namespace EnergyLite
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxChange = new System.Windows.Forms.ComboBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxGas_Debit = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_RadiusZonaDrenirovania = new System.Windows.Forms.Label();
            this.label_KofSverhSgim = new System.Windows.Forms.Label();
            this.label_TempInPlast = new System.Windows.Forms.Label();
            this.label_BaskostiGasa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_KofPronic = new System.Windows.Forms.Label();
            this.textBoxInput_Heading = new System.Windows.Forms.TextBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelFormula = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox_Debit = new System.Windows.Forms.CheckBox();
            this.checkBox_Volume = new System.Windows.Forms.CheckBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox_h_effectivGasonasTolshPlasta = new System.Windows.Forms.TextBox();
            this.textBox_k_kofPonicaemosti = new System.Windows.Forms.TextBox();
            this.textBox_T_P_TempInPlast = new System.Windows.Forms.TextBox();
            this.textBox_μ_Γ_BaskosstiGasa = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox_R_RadiusZonaDrenirovania = new System.Windows.Forms.TextBox();
            this.textBox_z_KofSverhSgim = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelQuestion.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxGas_Debit.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelFormula.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.button1);
            this.panelQuestion.Controls.Add(this.comboBoxChange);
            this.panelQuestion.Controls.Add(this.textBoxQuestion);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(1282, 117);
            this.panelQuestion.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(962, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxChange
            // 
            this.comboBoxChange.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.comboBoxChange.FormattingEnabled = true;
            this.comboBoxChange.Items.AddRange(new object[] {
            "Газ",
            "Нефть"});
            this.comboBoxChange.Location = new System.Drawing.Point(43, 65);
            this.comboBoxChange.Name = "comboBoxChange";
            this.comboBoxChange.Size = new System.Drawing.Size(1186, 32);
            this.comboBoxChange.TabIndex = 1;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuestion.Font = new System.Drawing.Font("Freestyle Script", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.textBoxQuestion.Location = new System.Drawing.Point(368, 12);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(506, 33);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = "Для чего производится расчёт?";
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuestion.Enter += new System.EventHandler(this.textBoxQuestion_Enter);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.panelInput.Controls.Add(this.checkBox_Volume);
            this.panelInput.Controls.Add(this.checkBox_Debit);
            this.panelInput.Controls.Add(this.groupBox1);
            this.panelInput.Controls.Add(this.groupBoxGas_Debit);
            this.panelInput.Controls.Add(this.textBoxInput_Heading);
            this.panelInput.Location = new System.Drawing.Point(12, 142);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(750, 591);
            this.panelInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(18, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(467, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Коэффициент сверх сжимаемости реального газа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(10, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Пластовая температура";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(10, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Пластовое давление";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(331, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Средняя газонасыщенность пласта";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(10, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(233, 24);
            this.label14.TabIndex = 9;
            this.label14.Text = "Балансовые запасы газа";
            // 
            // groupBoxGas_Debit
            // 
            this.groupBoxGas_Debit.Controls.Add(this.textBox11);
            this.groupBoxGas_Debit.Controls.Add(this.textBox5);
            this.groupBoxGas_Debit.Controls.Add(this.textBox6);
            this.groupBoxGas_Debit.Controls.Add(this.textBox_R_RadiusZonaDrenirovania);
            this.groupBoxGas_Debit.Controls.Add(this.textBox_z_KofSverhSgim);
            this.groupBoxGas_Debit.Controls.Add(this.textBox_T_P_TempInPlast);
            this.groupBoxGas_Debit.Controls.Add(this.textBox_μ_Γ_BaskosstiGasa);
            this.groupBoxGas_Debit.Controls.Add(this.textBox_h_effectivGasonasTolshPlasta);
            this.groupBoxGas_Debit.Controls.Add(this.textBox_k_kofPonicaemosti);
            this.groupBoxGas_Debit.Controls.Add(this.label7);
            this.groupBoxGas_Debit.Controls.Add(this.label8);
            this.groupBoxGas_Debit.Controls.Add(this.label9);
            this.groupBoxGas_Debit.Controls.Add(this.label_RadiusZonaDrenirovania);
            this.groupBoxGas_Debit.Controls.Add(this.label_KofSverhSgim);
            this.groupBoxGas_Debit.Controls.Add(this.label_TempInPlast);
            this.groupBoxGas_Debit.Controls.Add(this.label_BaskostiGasa);
            this.groupBoxGas_Debit.Controls.Add(this.label2);
            this.groupBoxGas_Debit.Controls.Add(this.label_KofPronic);
            this.groupBoxGas_Debit.Location = new System.Drawing.Point(18, 57);
            this.groupBoxGas_Debit.Name = "groupBoxGas_Debit";
            this.groupBoxGas_Debit.Size = new System.Drawing.Size(694, 315);
            this.groupBoxGas_Debit.TabIndex = 1;
            this.groupBoxGas_Debit.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Депрессия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пластовое давление";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Радиус скважины";
            // 
            // label_RadiusZonaDrenirovania
            // 
            this.label_RadiusZonaDrenirovania.AutoSize = true;
            this.label_RadiusZonaDrenirovania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RadiusZonaDrenirovania.Location = new System.Drawing.Point(10, 177);
            this.label_RadiusZonaDrenirovania.Name = "label_RadiusZonaDrenirovania";
            this.label_RadiusZonaDrenirovania.Size = new System.Drawing.Size(260, 24);
            this.label_RadiusZonaDrenirovania.TabIndex = 5;
            this.label_RadiusZonaDrenirovania.Text = "Радиус зоны дренирования";
            // 
            // label_KofSverhSgim
            // 
            this.label_KofSverhSgim.AutoSize = true;
            this.label_KofSverhSgim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_KofSverhSgim.Location = new System.Drawing.Point(10, 146);
            this.label_KofSverhSgim.Name = "label_KofSverhSgim";
            this.label_KofSverhSgim.Size = new System.Drawing.Size(362, 24);
            this.label_KofSverhSgim.TabIndex = 4;
            this.label_KofSverhSgim.Text = "Коэффициент сверхсжимаемости газа";
            // 
            // label_TempInPlast
            // 
            this.label_TempInPlast.AutoSize = true;
            this.label_TempInPlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TempInPlast.Location = new System.Drawing.Point(10, 117);
            this.label_TempInPlast.Name = "label_TempInPlast";
            this.label_TempInPlast.Size = new System.Drawing.Size(333, 24);
            this.label_TempInPlast.TabIndex = 3;
            this.label_TempInPlast.Text = "Температура в пластовых условиях";
            // 
            // label_BaskostiGasa
            // 
            this.label_BaskostiGasa.AutoSize = true;
            this.label_BaskostiGasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BaskostiGasa.Location = new System.Drawing.Point(10, 87);
            this.label_BaskostiGasa.Name = "label_BaskostiGasa";
            this.label_BaskostiGasa.Size = new System.Drawing.Size(137, 24);
            this.label_BaskostiGasa.TabIndex = 2;
            this.label_BaskostiGasa.Text = "Вязкость газа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Эффективная газонасыщенная толщина пласта";
            // 
            // label_KofPronic
            // 
            this.label_KofPronic.AutoSize = true;
            this.label_KofPronic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_KofPronic.Location = new System.Drawing.Point(10, 27);
            this.label_KofPronic.Name = "label_KofPronic";
            this.label_KofPronic.Size = new System.Drawing.Size(283, 24);
            this.label_KofPronic.TabIndex = 0;
            this.label_KofPronic.Text = "Коэффициент проницаемости";
            // 
            // textBoxInput_Heading
            // 
            this.textBoxInput_Heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.textBoxInput_Heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput_Heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBoxInput_Heading.Location = new System.Drawing.Point(18, 22);
            this.textBoxInput_Heading.Name = "textBoxInput_Heading";
            this.textBoxInput_Heading.Size = new System.Drawing.Size(700, 29);
            this.textBoxInput_Heading.TabIndex = 0;
            this.textBoxInput_Heading.Text = "Ввод параметров:";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(169)))), ((int)(((byte)(186)))));
            this.panelResult.Controls.Add(this.textBox18);
            this.panelResult.Controls.Add(this.label16);
            this.panelResult.Controls.Add(this.textBox17);
            this.panelResult.Controls.Add(this.label15);
            this.panelResult.Controls.Add(this.textBox1);
            this.panelResult.Location = new System.Drawing.Point(786, 142);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(474, 238);
            this.panelResult.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(169)))), ((int)(((byte)(186)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.textBox1.Location = new System.Drawing.Point(26, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Рассчитанные параметры:";
            // 
            // panelFormula
            // 
            this.panelFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.panelFormula.Controls.Add(this.textBox2);
            this.panelFormula.Location = new System.Drawing.Point(786, 414);
            this.panelFormula.Name = "panelFormula";
            this.panelFormula.Size = new System.Drawing.Size(475, 319);
            this.panelFormula.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox2.Location = new System.Drawing.Point(26, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 29);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Используемые формулы:";
            // 
            // checkBox_Debit
            // 
            this.checkBox_Debit.AutoSize = true;
            this.checkBox_Debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Debit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.checkBox_Debit.Location = new System.Drawing.Point(503, 26);
            this.checkBox_Debit.Name = "checkBox_Debit";
            this.checkBox_Debit.Size = new System.Drawing.Size(89, 28);
            this.checkBox_Debit.TabIndex = 9;
            this.checkBox_Debit.Text = "Дебит";
            this.checkBox_Debit.UseVisualStyleBackColor = true;
            // 
            // checkBox_Volume
            // 
            this.checkBox_Volume.AutoSize = true;
            this.checkBox_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.checkBox_Volume.Location = new System.Drawing.Point(613, 26);
            this.checkBox_Volume.Name = "checkBox_Volume";
            this.checkBox_Volume.Size = new System.Drawing.Size(93, 28);
            this.checkBox_Volume.TabIndex = 10;
            this.checkBox_Volume.Text = "Объем";
            this.checkBox_Volume.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox12.Location = new System.Drawing.Point(535, 133);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 22;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox13.Location = new System.Drawing.Point(535, 105);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 21;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox14.Location = new System.Drawing.Point(535, 77);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 20;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox15.Location = new System.Drawing.Point(535, 49);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 19;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox16.Location = new System.Drawing.Point(535, 21);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 22);
            this.textBox16.TabIndex = 18;
            // 
            // textBox_h_effectivGasonasTolshPlasta
            // 
            this.textBox_h_effectivGasonasTolshPlasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_h_effectivGasonasTolshPlasta.Location = new System.Drawing.Point(535, 58);
            this.textBox_h_effectivGasonasTolshPlasta.Name = "textBox_h_effectivGasonasTolshPlasta";
            this.textBox_h_effectivGasonasTolshPlasta.Size = new System.Drawing.Size(100, 22);
            this.textBox_h_effectivGasonasTolshPlasta.TabIndex = 24;
            // 
            // textBox_k_kofPonicaemosti
            // 
            this.textBox_k_kofPonicaemosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_k_kofPonicaemosti.Location = new System.Drawing.Point(535, 27);
            this.textBox_k_kofPonicaemosti.Name = "textBox_k_kofPonicaemosti";
            this.textBox_k_kofPonicaemosti.Size = new System.Drawing.Size(100, 22);
            this.textBox_k_kofPonicaemosti.TabIndex = 23;
            // 
            // textBox_T_P_TempInPlast
            // 
            this.textBox_T_P_TempInPlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_T_P_TempInPlast.Location = new System.Drawing.Point(535, 119);
            this.textBox_T_P_TempInPlast.Name = "textBox_T_P_TempInPlast";
            this.textBox_T_P_TempInPlast.Size = new System.Drawing.Size(100, 22);
            this.textBox_T_P_TempInPlast.TabIndex = 26;
            // 
            // textBox_μ_Γ_BaskosstiGasa
            // 
            this.textBox_μ_Γ_BaskosstiGasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_μ_Γ_BaskosstiGasa.Location = new System.Drawing.Point(535, 89);
            this.textBox_μ_Γ_BaskosstiGasa.Name = "textBox_μ_Γ_BaskosstiGasa";
            this.textBox_μ_Γ_BaskosstiGasa.Size = new System.Drawing.Size(100, 22);
            this.textBox_μ_Γ_BaskosstiGasa.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox5.Location = new System.Drawing.Point(535, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox6.Location = new System.Drawing.Point(535, 211);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 29;
            // 
            // textBox_R_RadiusZonaDrenirovania
            // 
            this.textBox_R_RadiusZonaDrenirovania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_R_RadiusZonaDrenirovania.Location = new System.Drawing.Point(535, 180);
            this.textBox_R_RadiusZonaDrenirovania.Name = "textBox_R_RadiusZonaDrenirovania";
            this.textBox_R_RadiusZonaDrenirovania.Size = new System.Drawing.Size(100, 22);
            this.textBox_R_RadiusZonaDrenirovania.TabIndex = 28;
            // 
            // textBox_z_KofSverhSgim
            // 
            this.textBox_z_KofSverhSgim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_z_KofSverhSgim.Location = new System.Drawing.Point(535, 149);
            this.textBox_z_KofSverhSgim.Name = "textBox_z_KofSverhSgim";
            this.textBox_z_KofSverhSgim.Size = new System.Drawing.Size(100, 22);
            this.textBox_z_KofSverhSgim.TabIndex = 27;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox11.Location = new System.Drawing.Point(535, 273);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.label15.Location = new System.Drawing.Point(21, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(278, 29);
            this.label15.TabIndex = 2;
            this.label15.Text = "Дебит месторождения";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox17.Location = new System.Drawing.Point(320, 87);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 26);
            this.textBox17.TabIndex = 24;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox18.Location = new System.Drawing.Point(320, 149);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 26);
            this.textBox18.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.label16.Location = new System.Drawing.Point(21, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 29);
            this.label16.TabIndex = 25;
            this.label16.Text = "Объем запасов";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1282, 780);
            this.Controls.Add(this.panelFormula);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnergyLite - программа для расчетов параметров нефтяных и газовых скважин";
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGas_Debit.ResumeLayout(false);
            this.groupBoxGas_Debit.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelFormula.ResumeLayout(false);
            this.panelFormula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.ComboBox comboBoxChange;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelFormula;
        private System.Windows.Forms.TextBox textBoxInput_Heading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxGas_Debit;
        private System.Windows.Forms.Label label_KofPronic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_RadiusZonaDrenirovania;
        private System.Windows.Forms.Label label_KofSverhSgim;
        private System.Windows.Forms.Label label_TempInPlast;
        private System.Windows.Forms.Label label_BaskostiGasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Volume;
        private System.Windows.Forms.CheckBox checkBox_Debit;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_R_RadiusZonaDrenirovania;
        private System.Windows.Forms.TextBox textBox_z_KofSverhSgim;
        private System.Windows.Forms.TextBox textBox_T_P_TempInPlast;
        private System.Windows.Forms.TextBox textBox_μ_Γ_BaskosstiGasa;
        private System.Windows.Forms.TextBox textBox_h_effectivGasonasTolshPlasta;
        private System.Windows.Forms.TextBox textBox_k_kofPonicaemosti;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label15;
    }
}

