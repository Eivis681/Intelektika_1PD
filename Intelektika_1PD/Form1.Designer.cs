namespace Intelektika_1PD
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
            this.Calculate = new System.Windows.Forms.Button();
            this.neibCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.method2 = new System.Windows.Forms.RadioButton();
            this.method1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointCombo = new System.Windows.Forms.ComboBox();
            this.AllPoints = new System.Windows.Forms.ListView();
            this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointsTo = new System.Windows.Forms.ListView();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(56, 177);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // neibCombo
            // 
            this.neibCombo.FormattingEnabled = true;
            this.neibCombo.Location = new System.Drawing.Point(34, 81);
            this.neibCombo.Name = "neibCombo";
            this.neibCombo.Size = new System.Drawing.Size(121, 21);
            this.neibCombo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.method2);
            this.groupBox1.Controls.Add(this.method1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methods";
            // 
            // method2
            // 
            this.method2.AutoSize = true;
            this.method2.Location = new System.Drawing.Point(82, 19);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(70, 17);
            this.method2.TabIndex = 3;
            this.method2.TabStop = true;
            this.method2.Text = "Method 2";
            this.method2.UseVisualStyleBackColor = true;
            // 
            // method1
            // 
            this.method1.AutoSize = true;
            this.method1.Location = new System.Drawing.Point(6, 19);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(70, 17);
            this.method1.TabIndex = 4;
            this.method1.TabStop = true;
            this.method1.Text = "Method 1";
            this.method1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Neighbour number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Point to calculate:";
            // 
            // pointCombo
            // 
            this.pointCombo.FormattingEnabled = true;
            this.pointCombo.Location = new System.Drawing.Point(34, 130);
            this.pointCombo.Name = "pointCombo";
            this.pointCombo.Size = new System.Drawing.Size(121, 21);
            this.pointCombo.TabIndex = 4;
            // 
            // AllPoints
            // 
            this.AllPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.X,
            this.Y,
            this.Class});
            this.AllPoints.HideSelection = false;
            this.AllPoints.Location = new System.Drawing.Point(235, 24);
            this.AllPoints.Name = "AllPoints";
            this.AllPoints.Size = new System.Drawing.Size(183, 139);
            this.AllPoints.TabIndex = 6;
            this.AllPoints.UseCompatibleStateImageBehavior = false;
            this.AllPoints.View = System.Windows.Forms.View.Details;
            // 
            // X
            // 
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.Text = "Y";
            this.Y.Width = 69;
            // 
            // PointsTo
            // 
            this.PointsTo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.PointsTo.HideSelection = false;
            this.PointsTo.Location = new System.Drawing.Point(472, 24);
            this.PointsTo.Name = "PointsTo";
            this.PointsTo.Size = new System.Drawing.Size(182, 139);
            this.PointsTo.TabIndex = 7;
            this.PointsTo.UseCompatibleStateImageBehavior = false;
            this.PointsTo.View = System.Windows.Forms.View.Details;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(472, 180);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(42, 20);
            this.textBoxX.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "All Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Points To:";
            // 
            // Class
            // 
            this.Class.Text = "Class";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(579, 178);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 14;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(531, 180);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(42, 20);
            this.textBoxY.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 212);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.PointsTo);
            this.Controls.Add(this.AllPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pointCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.neibCombo);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ComboBox neibCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton method2;
        private System.Windows.Forms.RadioButton method1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pointCombo;
        private System.Windows.Forms.ListView AllPoints;
        private System.Windows.Forms.ColumnHeader X;
        private System.Windows.Forms.ColumnHeader Y;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ListView PointsTo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBoxY;
    }
}

