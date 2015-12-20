namespace GraphicsEditor
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.addLine = new System.Windows.Forms.ToolStripButton();
            this.cursor = new System.Windows.Forms.ToolStripButton();
            this.removeElement = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 404);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redo,
            this.undo,
            this.addLine,
            this.cursor,
            this.removeElement});
            this.toolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolBar.Size = new System.Drawing.Size(896, 31);
            this.toolBar.Stretch = true;
            this.toolBar.TabIndex = 2;
            // 
            // redo
            // 
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Enabled = false;
            this.redo.Image = ((System.Drawing.Image)(resources.GetObject("redo.Image")));
            this.redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(23, 28);
            this.redo.Text = "redo";
            this.redo.Click += new System.EventHandler(this.redoClick);
            // 
            // undo
            // 
            this.undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo.Enabled = false;
            this.undo.Image = ((System.Drawing.Image)(resources.GetObject("undo.Image")));
            this.undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(23, 28);
            this.undo.Text = "undo";
            this.undo.Click += new System.EventHandler(this.undoClick);
            // 
            // addLine
            // 
            this.addLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addLine.Image = ((System.Drawing.Image)(resources.GetObject("addLine.Image")));
            this.addLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(23, 28);
            this.addLine.Text = "add line";
            this.addLine.Click += new System.EventHandler(this.addLineClick);
            // 
            // cursor
            // 
            this.cursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursor.Image = ((System.Drawing.Image)(resources.GetObject("cursor.Image")));
            this.cursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cursor.Name = "cursor";
            this.cursor.Size = new System.Drawing.Size(23, 28);
            this.cursor.Text = "cursor";
            this.cursor.Click += new System.EventHandler(this.cursorClick);
            // 
            // removeElement
            // 
            this.removeElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeElement.Image = ((System.Drawing.Image)(resources.GetObject("removeElement.Image")));
            this.removeElement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeElement.Name = "removeElement";
            this.removeElement.Size = new System.Drawing.Size(23, 28);
            this.removeElement.Text = "remove";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 436);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Editor";
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton redo;
        private System.Windows.Forms.ToolStripButton undo;
        private System.Windows.Forms.ToolStripButton addLine;
        private System.Windows.Forms.ToolStripButton removeElement;
        private System.Windows.Forms.ToolStripButton cursor;
        private System.Windows.Forms.TextBox textBox1;
    }
}

