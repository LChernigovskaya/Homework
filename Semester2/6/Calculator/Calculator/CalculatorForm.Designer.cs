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
            this.figure1 = new System.Windows.Forms.Button();
            this.figure3 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.figure4 = new System.Windows.Forms.Button();
            this.figure5 = new System.Windows.Forms.Button();
            this.figure6 = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.figure7 = new System.Windows.Forms.Button();
            this.figure8 = new System.Windows.Forms.Button();
            this.figure9 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.figure0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.expression = new System.Windows.Forms.TextBox();
            this.figure2 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.figure1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.figure3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.addition, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.figure4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.figure5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.figure6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.substraction, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.figure7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.figure8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.figure9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.multiplication, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.figure0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.result, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.division, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.expression, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.figure2, 1, 3);
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
            // figure1
            // 
            this.figure1.AutoSize = true;
            this.figure1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure1.Location = new System.Drawing.Point(3, 219);
            this.figure1.Name = "figure1";
            this.figure1.Size = new System.Drawing.Size(45, 66);
            this.figure1.TabIndex = 9;
            this.figure1.Text = "1";
            this.figure1.UseVisualStyleBackColor = true;
            this.figure1.Click += new System.EventHandler(this.OnFigureClick);
            // 
            // figure3
            // 
            this.figure3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure3.Location = new System.Drawing.Point(105, 219);
            this.figure3.Name = "figure3";
            this.figure3.Size = new System.Drawing.Size(45, 66);
            this.figure3.TabIndex = 11;
            this.figure3.Text = "3";
            this.figure3.UseVisualStyleBackColor = true;
            this.figure3.Click += new System.EventHandler(this.OnFigureClick);
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
            this.addition.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // figure4
            // 
            this.figure4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure4.Location = new System.Drawing.Point(3, 147);
            this.figure4.Name = "figure4";
            this.figure4.Size = new System.Drawing.Size(45, 66);
            this.figure4.TabIndex = 8;
            this.figure4.Text = "4";
            this.figure4.UseVisualStyleBackColor = true;
            this.figure4.Click += new System.EventHandler(this.OnFigureClick);
            // 
            // figure5
            // 
            this.figure5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure5.Location = new System.Drawing.Point(54, 147);
            this.figure5.Name = "figure5";
            this.figure5.Size = new System.Drawing.Size(45, 66);
            this.figure5.TabIndex = 7;
            this.figure5.Text = "5";
            this.figure5.UseVisualStyleBackColor = true;
            this.figure5.Click += new System.EventHandler(this.OnFigureClick);
            // 
            // figure6
            // 
            this.figure6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure6.Location = new System.Drawing.Point(105, 147);
            this.figure6.Name = "figure6";
            this.figure6.Size = new System.Drawing.Size(45, 66);
            this.figure6.TabIndex = 6;
            this.figure6.Text = "6";
            this.figure6.UseVisualStyleBackColor = true;
            this.figure6.Click += new System.EventHandler(this.OnFigureClick);
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
            this.substraction.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // figure7
            // 
            this.figure7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure7.Location = new System.Drawing.Point(3, 75);
            this.figure7.Name = "figure7";
            this.figure7.Size = new System.Drawing.Size(45, 66);
            this.figure7.TabIndex = 0;
            this.figure7.Text = "7";
            this.figure7.UseVisualStyleBackColor = true;
            this.figure7.Click += new System.EventHandler(this.OnFigureClick);
            // 
            // figure8
            // 
            this.figure8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure8.Location = new System.Drawing.Point(54, 75);
            this.figure8.Name = "figure8";
            this.figure8.Size = new System.Drawing.Size(45, 66);
            this.figure8.TabIndex = 1;
            this.figure8.Text = "8";
            this.figure8.UseVisualStyleBackColor = true;
            this.figure8.Click += new System.EventHandler(this.OnFigureClick);
            // 
            // figure9
            // 
            this.figure9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure9.Location = new System.Drawing.Point(105, 75);
            this.figure9.Name = "figure9";
            this.figure9.Size = new System.Drawing.Size(45, 66);
            this.figure9.TabIndex = 2;
            this.figure9.Text = "9";
            this.figure9.UseVisualStyleBackColor = true;
            this.figure9.Click += new System.EventHandler(this.OnFigureClick);
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
            this.multiplication.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // figure0
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.figure0, 2);
            this.figure0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure0.Location = new System.Drawing.Point(3, 291);
            this.figure0.Name = "figure0";
            this.figure0.Size = new System.Drawing.Size(96, 70);
            this.figure0.TabIndex = 16;
            this.figure0.Text = "0";
            this.figure0.UseVisualStyleBackColor = true;
            this.figure0.Click += new System.EventHandler(this.OnFigureClick);
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
            this.point.Click += new System.EventHandler(this.OnFigureClick);
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
            // division
            // 
            this.division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(156, 147);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(45, 66);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.OnOperationClick);
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
            // figure2
            // 
            this.figure2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figure2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figure2.Location = new System.Drawing.Point(54, 219);
            this.figure2.Name = "figure2";
            this.figure2.Size = new System.Drawing.Size(45, 66);
            this.figure2.TabIndex = 10;
            this.figure2.Text = "2";
            this.figure2.UseVisualStyleBackColor = true;
            this.figure2.Click += new System.EventHandler(this.OnFigureClick);
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
        private System.Windows.Forms.Button figure1;
        private System.Windows.Forms.Button figure2;
        private System.Windows.Forms.Button figure3;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button figure4;
        private System.Windows.Forms.Button figure5;
        private System.Windows.Forms.Button figure6;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button figure7;
        private System.Windows.Forms.Button figure8;
        private System.Windows.Forms.Button figure9;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button figure0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.Button delete;

    }
}

