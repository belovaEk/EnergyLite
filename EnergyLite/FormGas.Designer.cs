
namespace EnergyLite
{
    partial class FormGas
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
            this.panelFormula = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.comboBoxChange = new System.Windows.Forms.ComboBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelFormula.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormula
            // 
            this.panelFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(58)))), ((int)(((byte)(90)))));
            this.panelFormula.Controls.Add(this.textBox2);
            this.panelFormula.Location = new System.Drawing.Point(785, 448);
            this.panelFormula.Name = "panelFormula";
            this.panelFormula.Size = new System.Drawing.Size(475, 319);
            this.panelFormula.TabIndex = 7;
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
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.panelInput.Controls.Add(this.textBoxInput);
            this.panelInput.Location = new System.Drawing.Point(25, 176);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(737, 591);
            this.panelInput.TabIndex = 5;
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBoxInput.Location = new System.Drawing.Point(18, 165);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(700, 29);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "Ввод параметров:";
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.comboBoxChange);
            this.panelQuestion.Controls.Add(this.textBoxQuestion);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(1282, 138);
            this.panelQuestion.TabIndex = 4;
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
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.textBoxQuestion.Location = new System.Drawing.Point(368, 12);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(506, 32);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = "Для чего производится расчёт?";
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(169)))), ((int)(((byte)(186)))));
            this.panelResult.Controls.Add(this.textBox1);
            this.panelResult.Location = new System.Drawing.Point(785, 176);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(474, 238);
            this.panelResult.TabIndex = 6;
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
            // FormGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 780);
            this.Controls.Add(this.panelFormula);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panelResult);
            this.Name = "FormGas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelFormula.ResumeLayout(false);
            this.panelFormula.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormula;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.ComboBox comboBoxChange;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}