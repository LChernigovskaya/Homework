namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.figure_1 = new System.Windows.Forms.Button();
            this.figure_3 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.figure_4 = new System.Windows.Forms.Button();
            this.figure_5 = new System.Windows.Forms.Button();
            this.figure_6 = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.figure_7 = new System.Windows.Forms.Button();
            this.figure_8 = new System.Windows.Forms.Button();
            this.figure_9 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.figure_0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.devision = new System.Windows.Forms.Button();
            this.expression = new System.Windows.Forms.TextBox();
            this.figure_2 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.figure_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.figure_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.addition, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.figure_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.figure_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.figure_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.substraction, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.figure_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.figure_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.figure_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.multiplication, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.figure_0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.result, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.devision, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.expression, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.figure_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.delete, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // figure_1
            // 
            this.figure_1.AutoSize = true;
            this.figure_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_1.Location = new System.Drawing.Point(3, 219);
            this.figure_1.Name = "figure_1";
            this.figure_1.Size = new System.Drawing.Size(45, 66);
            this.figure_1.TabIndex = 9;
            this.figure_1.Text = "1";
            this.figure_1.UseVisualStyleBackColor = true;
            this.figure_1.Click += new System.EventHandler(this.OnFigure1Click);
            // 
            // figure_3
            // 
            this.figure_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_3.Location = new System.Drawing.Point(105, 219);
            this.figure_3.Name = "figure_3";
            this.figure_3.Size = new System.Drawing.Size(45, 66);
            this.figure_3.TabIndex = 11;
            this.figure_3.Text = "3";
            this.figure_3.UseVisualStyleBackColor = true;
            this.figure_3.Click += new System.EventHandler(this.OnFigure3Click);
            // 
            // addition
            // 
            this.addition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(156, 291);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(45, 70);
            this.addition.TabIndex = 14;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.OnAdditionClick);
            // 
            // figure_4
            // 
            this.figure_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_4.Location = new System.Drawing.Point(3, 147);
            this.figure_4.Name = "figure_4";
            this.figure_4.Size = new System.Drawing.Size(45, 66);
            this.figure_4.TabIndex = 8;
            this.figure_4.Text = "4";
            this.figure_4.UseVisualStyleBackColor = true;
            this.figure_4.Click += new System.EventHandler(this.OnFigure4Click);
            // 
            // figure_5
            // 
            this.figure_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_5.Location = new System.Drawing.Point(54, 147);
            this.figure_5.Name = "figure_5";
            this.figure_5.Size = new System.Drawing.Size(45, 66);
            this.figure_5.TabIndex = 7;
            this.figure_5.Text = "5";
            this.figure_5.UseVisualStyleBackColor = true;
            this.figure_5.Click += new System.EventHandler(this.OnFigure5Click);
            // 
            // figure_6
            // 
            this.figure_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_6.Location = new System.Drawing.Point(105, 147);
            this.figure_6.Name = "figure_6";
            this.figure_6.Size = new System.Drawing.Size(45, 66);
            this.figure_6.TabIndex = 6;
            this.figure_6.Text = "6";
            this.figure_6.UseVisualStyleBackColor = true;
            this.figure_6.Click += new System.EventHandler(this.OnFigure6Click);
            // 
            // substraction
            // 
            this.substraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.substraction.Location = new System.Drawing.Point(156, 219);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(45, 66);
            this.substraction.TabIndex = 12;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.OnSubstractionClick);
            // 
            // figure_7
            // 
            this.figure_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_7.Location = new System.Drawing.Point(3, 75);
            this.figure_7.Name = "figure_7";
            this.figure_7.Size = new System.Drawing.Size(45, 66);
            this.figure_7.TabIndex = 0;
            this.figure_7.Text = "7";
            this.figure_7.UseVisualStyleBackColor = true;
            this.figure_7.Click += new System.EventHandler(this.OnFigure7Click);
            // 
            // figure_8
            // 
            this.figure_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_8.Location = new System.Drawing.Point(54, 75);
            this.figure_8.Name = "figure_8";
            this.figure_8.Size = new System.Drawing.Size(45, 66);
            this.figure_8.TabIndex = 1;
            this.figure_8.Text = "8";
            this.figure_8.UseVisualStyleBackColor = true;
            this.figure_8.Click += new System.EventHandler(this.OnFigure8Click);
            // 
            // figure_9
            // 
            this.figure_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_9.Location = new System.Drawing.Point(105, 75);
            this.figure_9.Name = "figure_9";
            this.figure_9.Size = new System.Drawing.Size(45, 66);
            this.figure_9.TabIndex = 2;
            this.figure_9.Text = "9";
            this.figure_9.UseVisualStyleBackColor = true;
            this.figure_9.Click += new System.EventHandler(this.OnFigure9Click);
            // 
            // multiplication
            // 
            this.multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(156, 75);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(45, 66);
            this.multiplication.TabIndex = 3;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.OnMultiplicationClick);
            // 
            // figure_0
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.figure_0, 2);
            this.figure_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_0.Location = new System.Drawing.Point(3, 291);
            this.figure_0.Name = "figure_0";
            this.figure_0.Size = new System.Drawing.Size(96, 70);
            this.figure_0.TabIndex = 16;
            this.figure_0.Text = "0";
            this.figure_0.UseVisualStyleBackColor = true;
            this.figure_0.Click += new System.EventHandler(this.OnFigure0Click);
            // 
            // point
            // 
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.Location = new System.Drawing.Point(105, 291);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(45, 70);
            this.point.TabIndex = 15;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.OnPointClick);
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(207, 219);
            this.result.Name = "result";
            this.tableLayoutPanel1.SetRowSpan(this.result, 2);
            this.result.Size = new System.Drawing.Size(46, 142);
            this.result.TabIndex = 13;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.OnResultClick);
            // 
            // devision
            // 
            this.devision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devision.Location = new System.Drawing.Point(156, 147);
            this.devision.Name = "devision";
            this.devision.Size = new System.Drawing.Size(45, 66);
            this.devision.TabIndex = 5;
            this.devision.Text = "/";
            this.devision.UseVisualStyleBackColor = true;
            this.devision.Click += new System.EventHandler(this.OnDevisionClick);
            // 
            // expression
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.expression, 5);
            this.expression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expression.Enabled = false;
            this.expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expression.Location = new System.Drawing.Point(3, 3);
            this.expression.Multiline = true;
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(250, 66);
            this.expression.TabIndex = 16;
            // 
            // figure_2
            // 
            this.figure_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure_2.Location = new System.Drawing.Point(54, 219);
            this.figure_2.Name = "figure_2";
            this.figure_2.Size = new System.Drawing.Size(45, 66);
            this.figure_2.TabIndex = 10;
            this.figure_2.Text = "2";
            this.figure_2.UseVisualStyleBackColor = true;
            this.figure_2.Click += new System.EventHandler(this.OnFigure2Click);
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Location = new System.Drawing.Point(207, 75);
            this.delete.Name = "delete";
            this.tableLayoutPanel1.SetRowSpan(this.delete, 2);
            this.delete.Size = new System.Drawing.Size(46, 138);
            this.delete.TabIndex = 4;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(270, 400);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button figure_1;
        private System.Windows.Forms.Button figure_2;
        private System.Windows.Forms.Button figure_3;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button figure_4;
        private System.Windows.Forms.Button figure_5;
        private System.Windows.Forms.Button figure_6;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button figure_7;
        private System.Windows.Forms.Button figure_8;
        private System.Windows.Forms.Button figure_9;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button figure_0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button devision;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.Button delete;

    }
}

