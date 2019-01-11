namespace GUI_Paint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRectSelect = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonWriteText = new System.Windows.Forms.Button();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.buttonDrawCurve = new System.Windows.Forms.Button();
            this.buttonDrawRect = new System.Windows.Forms.Button();
            this.buttonDrawPolly = new System.Windows.Forms.Button();
            this.buttonDrawElipse = new System.Windows.Forms.Button();
            this.textBoxStatusBar = new System.Windows.Forms.TextBox();
            this.pictureBoxDrawArea = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonFlipHoriz = new System.Windows.Forms.Button();
            this.buttonFlipVert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuView,
            this.MenuImage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuView
            // 
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(44, 20);
            this.MenuView.Text = "View";
            this.MenuView.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // MenuImage
            // 
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(52, 20);
            this.MenuImage.Text = "Image";
            this.MenuImage.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // buttonRectSelect
            // 
            this.buttonRectSelect.Location = new System.Drawing.Point(13, 28);
            this.buttonRectSelect.Name = "buttonRectSelect";
            this.buttonRectSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonRectSelect.TabIndex = 1;
            this.buttonRectSelect.Text = "Rect Select";
            this.buttonRectSelect.UseVisualStyleBackColor = true;
            this.buttonRectSelect.Click += new System.EventHandler(this.buttonRectSelect_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Location = new System.Drawing.Point(94, 28);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(42, 23);
            this.buttonBrush.TabIndex = 2;
            this.buttonBrush.Text = "Brush";
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Location = new System.Drawing.Point(142, 28);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(44, 23);
            this.buttonPencil.TabIndex = 3;
            this.buttonPencil.Text = "Pencil";
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonWriteText
            // 
            this.buttonWriteText.Location = new System.Drawing.Point(192, 28);
            this.buttonWriteText.Name = "buttonWriteText";
            this.buttonWriteText.Size = new System.Drawing.Size(66, 23);
            this.buttonWriteText.TabIndex = 4;
            this.buttonWriteText.Text = "Write Text";
            this.buttonWriteText.UseVisualStyleBackColor = true;
            this.buttonWriteText.Click += new System.EventHandler(this.buttonWriteText_Click);
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.Location = new System.Drawing.Point(264, 28);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(64, 23);
            this.buttonDrawLine.TabIndex = 5;
            this.buttonDrawLine.Text = "Draw Line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // buttonDrawCurve
            // 
            this.buttonDrawCurve.Location = new System.Drawing.Point(334, 28);
            this.buttonDrawCurve.Name = "buttonDrawCurve";
            this.buttonDrawCurve.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawCurve.TabIndex = 6;
            this.buttonDrawCurve.Text = "Draw Curve";
            this.buttonDrawCurve.UseVisualStyleBackColor = true;
            this.buttonDrawCurve.Click += new System.EventHandler(this.buttonDrawCurve_Click);
            // 
            // buttonDrawRect
            // 
            this.buttonDrawRect.Location = new System.Drawing.Point(415, 28);
            this.buttonDrawRect.Name = "buttonDrawRect";
            this.buttonDrawRect.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawRect.TabIndex = 7;
            this.buttonDrawRect.Text = "Draw Rect";
            this.buttonDrawRect.UseVisualStyleBackColor = true;
            this.buttonDrawRect.Click += new System.EventHandler(this.buttonDrawRect_Click);
            // 
            // buttonDrawPolly
            // 
            this.buttonDrawPolly.Location = new System.Drawing.Point(496, 28);
            this.buttonDrawPolly.Name = "buttonDrawPolly";
            this.buttonDrawPolly.Size = new System.Drawing.Size(81, 23);
            this.buttonDrawPolly.TabIndex = 8;
            this.buttonDrawPolly.Text = "Draw Polygon";
            this.buttonDrawPolly.UseVisualStyleBackColor = true;
            this.buttonDrawPolly.Click += new System.EventHandler(this.buttonDrawPolly_Click);
            // 
            // buttonDrawElipse
            // 
            this.buttonDrawElipse.Location = new System.Drawing.Point(583, 28);
            this.buttonDrawElipse.Name = "buttonDrawElipse";
            this.buttonDrawElipse.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawElipse.TabIndex = 9;
            this.buttonDrawElipse.Text = "Draw Elipse";
            this.buttonDrawElipse.UseVisualStyleBackColor = true;
            this.buttonDrawElipse.Click += new System.EventHandler(this.buttonDrawElipse_Click);
            // 
            // textBoxStatusBar
            // 
            this.textBoxStatusBar.Location = new System.Drawing.Point(112, 4);
            this.textBoxStatusBar.Name = "textBoxStatusBar";
            this.textBoxStatusBar.ReadOnly = true;
            this.textBoxStatusBar.Size = new System.Drawing.Size(651, 20);
            this.textBoxStatusBar.TabIndex = 10;
            // 
            // pictureBoxDrawArea
            // 
            this.pictureBoxDrawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDrawArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxDrawArea.Location = new System.Drawing.Point(13, 122);
            this.pictureBoxDrawArea.Name = "pictureBoxDrawArea";
            this.pictureBoxDrawArea.Size = new System.Drawing.Size(750, 409);
            this.pictureBoxDrawArea.TabIndex = 11;
            this.pictureBoxDrawArea.TabStop = false;
            this.pictureBoxDrawArea.Click += new System.EventHandler(this.pictureBoxDrawArea_Click);
            this.pictureBoxDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawArea_MouseDown);
            this.pictureBoxDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawArea_MouseMove);
            this.pictureBoxDrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawArea_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pick Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(13, 51);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 13;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Visible = false;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(582, 80);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonFlipHoriz
            // 
            this.buttonFlipHoriz.Location = new System.Drawing.Point(94, 51);
            this.buttonFlipHoriz.Name = "buttonFlipHoriz";
            this.buttonFlipHoriz.Size = new System.Drawing.Size(75, 23);
            this.buttonFlipHoriz.TabIndex = 15;
            this.buttonFlipHoriz.Text = "Flip Horiz";
            this.buttonFlipHoriz.UseVisualStyleBackColor = true;
            this.buttonFlipHoriz.Visible = false;
            this.buttonFlipHoriz.Click += new System.EventHandler(this.buttonFlipHoriz_Click);
            // 
            // buttonFlipVert
            // 
            this.buttonFlipVert.Location = new System.Drawing.Point(176, 51);
            this.buttonFlipVert.Name = "buttonFlipVert";
            this.buttonFlipVert.Size = new System.Drawing.Size(75, 23);
            this.buttonFlipVert.TabIndex = 16;
            this.buttonFlipVert.Text = "Flip Vert";
            this.buttonFlipVert.UseVisualStyleBackColor = true;
            this.buttonFlipVert.Visible = false;
            this.buttonFlipVert.Click += new System.EventHandler(this.buttonFlipVert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Write text here then press wirte text button then click on screen";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonFlipVert);
            this.Controls.Add(this.buttonFlipHoriz);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxDrawArea);
            this.Controls.Add(this.textBoxStatusBar);
            this.Controls.Add(this.buttonDrawElipse);
            this.Controls.Add(this.buttonDrawPolly);
            this.Controls.Add(this.buttonDrawRect);
            this.Controls.Add(this.buttonDrawCurve);
            this.Controls.Add(this.buttonDrawLine);
            this.Controls.Add(this.buttonWriteText);
            this.Controls.Add(this.buttonPencil);
            this.Controls.Add(this.buttonBrush);
            this.Controls.Add(this.buttonRectSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuView;
        private System.Windows.Forms.ToolStripMenuItem MenuImage;
        private System.Windows.Forms.Button buttonRectSelect;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonWriteText;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Button buttonDrawCurve;
        private System.Windows.Forms.Button buttonDrawRect;
        private System.Windows.Forms.Button buttonDrawPolly;
        private System.Windows.Forms.Button buttonDrawElipse;
        private System.Windows.Forms.TextBox textBoxStatusBar;
        private System.Windows.Forms.PictureBox pictureBoxDrawArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonFlipHoriz;
        private System.Windows.Forms.Button buttonFlipVert;
        private System.Windows.Forms.TextBox textBox1; 
        
    }
}

