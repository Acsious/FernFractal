namespace FractalKG
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.txtLmin = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.picFractal = new System.Windows.Forms.PictureBox();
            this.chbClear = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtAlpha, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBeta, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLmin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtK, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtK1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.picFractal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chbClear, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbColors, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(324, 3);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(35, 20);
            this.txtAlpha.TabIndex = 0;
            this.txtAlpha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlpha_KeyDown);
            this.txtAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // txtBeta
            // 
            this.txtBeta.Location = new System.Drawing.Point(324, 29);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(35, 20);
            this.txtBeta.TabIndex = 1;
            this.txtBeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlpha_KeyDown);
            this.txtBeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // txtLmin
            // 
            this.txtLmin.Location = new System.Drawing.Point(324, 55);
            this.txtLmin.Name = "txtLmin";
            this.txtLmin.Size = new System.Drawing.Size(35, 20);
            this.txtLmin.TabIndex = 2;
            this.txtLmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlpha_KeyDown);
            this.txtLmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(324, 81);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(35, 20);
            this.txtK.TabIndex = 3;
            this.txtK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlpha_KeyDown);
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(289, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "α:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(289, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "β:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(289, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lmin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(289, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "k:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(289, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "k1:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtK1
            // 
            this.txtK1.Location = new System.Drawing.Point(324, 107);
            this.txtK1.Name = "txtK1";
            this.txtK1.Size = new System.Drawing.Size(35, 20);
            this.txtK1.TabIndex = 4;
            this.txtK1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlpha_KeyDown);
            this.txtK1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // picFractal
            // 
            this.picFractal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFractal.Location = new System.Drawing.Point(3, 3);
            this.picFractal.Name = "picFractal";
            this.tableLayoutPanel1.SetRowSpan(this.picFractal, 14);
            this.picFractal.Size = new System.Drawing.Size(283, 573);
            this.picFractal.TabIndex = 3;
            this.picFractal.TabStop = false;
            // 
            // chbClear
            // 
            this.chbClear.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chbClear, 2);
            this.chbClear.Location = new System.Drawing.Point(292, 133);
            this.chbClear.Name = "chbClear";
            this.chbClear.Size = new System.Drawing.Size(73, 17);
            this.chbClear.TabIndex = 6;
            this.chbClear.Text = "Очистить";
            this.chbClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(292, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbColors
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbColors, 2);
            this.cmbColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Items.AddRange(new object[] {
            "Черно-белый",
            "Радуга",
            "Случайная радуга",
            "Выбрать..."});
            this.cmbColors.Location = new System.Drawing.Point(292, 156);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(76, 21);
            this.cmbColors.TabIndex = 7;
            this.cmbColors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Папоротник";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.TextBox txtLmin;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtK1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picFractal;
        private System.Windows.Forms.CheckBox chbClear;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.ColorDialog colorDialog1;

    }
}

