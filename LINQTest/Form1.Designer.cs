namespace LINQTest
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
            this.textBoxOriginalArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.buttonPartDescription = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.buttonQuantity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOriginalArray
            // 
            this.textBoxOriginalArray.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginalArray.Location = new System.Drawing.Point(12, 48);
            this.textBoxOriginalArray.Multiline = true;
            this.textBoxOriginalArray.Name = "textBoxOriginalArray";
            this.textBoxOriginalArray.ReadOnly = true;
            this.textBoxOriginalArray.Size = new System.Drawing.Size(601, 210);
            this.textBoxOriginalArray.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Invoices:";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSorted.ForeColor = System.Drawing.Color.Red;
            this.textBoxSorted.Location = new System.Drawing.Point(12, 377);
            this.textBoxSorted.Multiline = true;
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.ReadOnly = true;
            this.textBoxSorted.Size = new System.Drawing.Size(601, 210);
            this.textBoxSorted.TabIndex = 7;
            // 
            // buttonPartDescription
            // 
            this.buttonPartDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPartDescription.Location = new System.Drawing.Point(12, 330);
            this.buttonPartDescription.Name = "buttonPartDescription";
            this.buttonPartDescription.Size = new System.Drawing.Size(174, 34);
            this.buttonPartDescription.TabIndex = 4;
            this.buttonPartDescription.Text = "PART DESCRIPTION";
            this.buttonPartDescription.UseVisualStyleBackColor = false;
            this.buttonPartDescription.Click += new System.EventHandler(this.buttonPartDescription_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPrice.Location = new System.Drawing.Point(206, 330);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(85, 34);
            this.buttonPrice.TabIndex = 5;
            this.buttonPrice.Text = "PRICE";
            this.buttonPrice.UseVisualStyleBackColor = false;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonQuantity
            // 
            this.buttonQuantity.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonQuantity.Location = new System.Drawing.Point(306, 330);
            this.buttonQuantity.Name = "buttonQuantity";
            this.buttonQuantity.Size = new System.Drawing.Size(307, 34);
            this.buttonQuantity.TabIndex = 6;
            this.buttonQuantity.Text = "QUANTITY (show only Part Desc. and Qtdy)";
            this.buttonQuantity.UseVisualStyleBackColor = false;
            this.buttonQuantity.Click += new System.EventHandler(this.buttonQuantity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Invoices Sorted By:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.54153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.45847F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox16, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(655, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 304);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "COURSE:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(153, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Programming 3";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.Location = new System.Drawing.Point(6, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "COURSE CODE:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(153, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "COMP 212 (Sec002)";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.Location = new System.Drawing.Point(6, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "ASSIGNMENT:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(153, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(235, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Lab#02";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox7.Location = new System.Drawing.Point(6, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(138, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "EXERCISE#02:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(153, 120);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(235, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "LINQ";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox9.Location = new System.Drawing.Point(6, 158);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(138, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "STUDENT:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(153, 158);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(235, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "Leonardo de Almeida";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox11.Location = new System.Drawing.Point(6, 196);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(138, 20);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "STUDENT ID:";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(153, 196);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(235, 20);
            this.textBox12.TabIndex = 11;
            this.textBox12.Text = "300918620";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox13.Location = new System.Drawing.Point(6, 234);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(138, 20);
            this.textBox13.TabIndex = 12;
            this.textBox13.Text = "FACULTY:";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(153, 234);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(235, 20);
            this.textBox14.TabIndex = 13;
            this.textBox14.Text = "Sujeet Lohan";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Control;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox15.Location = new System.Drawing.Point(6, 272);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(138, 20);
            this.textBox15.TabIndex = 14;
            this.textBox15.Text = "DATE:";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(153, 272);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(235, 20);
            this.textBox16.TabIndex = 15;
            this.textBox16.Text = "OCT 13, 2018";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 646);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonQuantity);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.buttonPartDescription);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOriginalArray);
            this.Name = "Form1";
            this.Text = "Leonardo-Almeida_COMP212_Sec002_Lab#02_Ex#02_LINQTest";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOriginalArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.Button buttonPartDescription;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.Button buttonQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
    }
}

