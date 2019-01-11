namespace GUIScheduler
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
            this.buttonAddHighest = new System.Windows.Forms.Button();
            this.buttonAddAboveNormal = new System.Windows.Forms.Button();
            this.buttonAddNormal = new System.Windows.Forms.Button();
            this.buttonAddBelowNormal = new System.Windows.Forms.Button();
            this.buttonAddLowest = new System.Windows.Forms.Button();
            this.labelAddJobs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishJobBy = new System.Windows.Forms.TextBox();
            this.buttonWrapUp = new System.Windows.Forms.Button();
            this.textboxGlobalCounter = new System.Windows.Forms.TextBox();
            this.textboxLocalCounter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loggerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddHighest
            // 
            this.buttonAddHighest.Location = new System.Drawing.Point(30, 33);
            this.buttonAddHighest.Name = "buttonAddHighest";
            this.buttonAddHighest.Size = new System.Drawing.Size(104, 23);
            this.buttonAddHighest.TabIndex = 0;
            this.buttonAddHighest.Text = "Add Highest";
            this.buttonAddHighest.UseVisualStyleBackColor = true;
            this.buttonAddHighest.Click += new System.EventHandler(this.buttonAddHighest_Click);
            // 
            // buttonAddAboveNormal
            // 
            this.buttonAddAboveNormal.Location = new System.Drawing.Point(30, 62);
            this.buttonAddAboveNormal.Name = "buttonAddAboveNormal";
            this.buttonAddAboveNormal.Size = new System.Drawing.Size(104, 23);
            this.buttonAddAboveNormal.TabIndex = 1;
            this.buttonAddAboveNormal.Text = "Add Above Normal";
            this.buttonAddAboveNormal.UseVisualStyleBackColor = true;
            this.buttonAddAboveNormal.Click += new System.EventHandler(this.buttonAddAboveNormal_Click);
            // 
            // buttonAddNormal
            // 
            this.buttonAddNormal.Location = new System.Drawing.Point(30, 91);
            this.buttonAddNormal.Name = "buttonAddNormal";
            this.buttonAddNormal.Size = new System.Drawing.Size(104, 23);
            this.buttonAddNormal.TabIndex = 2;
            this.buttonAddNormal.Text = "Add Normal";
            this.buttonAddNormal.UseVisualStyleBackColor = true;
            this.buttonAddNormal.Click += new System.EventHandler(this.buttonAddNormal_Click);
            // 
            // buttonAddBelowNormal
            // 
            this.buttonAddBelowNormal.Location = new System.Drawing.Point(30, 120);
            this.buttonAddBelowNormal.Name = "buttonAddBelowNormal";
            this.buttonAddBelowNormal.Size = new System.Drawing.Size(104, 23);
            this.buttonAddBelowNormal.TabIndex = 3;
            this.buttonAddBelowNormal.Text = "Add Below Normal";
            this.buttonAddBelowNormal.UseVisualStyleBackColor = true;
            this.buttonAddBelowNormal.Click += new System.EventHandler(this.buttonAddBelowNormal_Click);
            // 
            // buttonAddLowest
            // 
            this.buttonAddLowest.Location = new System.Drawing.Point(30, 149);
            this.buttonAddLowest.Name = "buttonAddLowest";
            this.buttonAddLowest.Size = new System.Drawing.Size(104, 23);
            this.buttonAddLowest.TabIndex = 4;
            this.buttonAddLowest.Text = "Add Lowest";
            this.buttonAddLowest.UseVisualStyleBackColor = true;
            this.buttonAddLowest.Click += new System.EventHandler(this.buttonAddLowest_Click);
            // 
            // labelAddJobs
            // 
            this.labelAddJobs.AutoSize = true;
            this.labelAddJobs.Location = new System.Drawing.Point(30, 14);
            this.labelAddJobs.Name = "labelAddJobs";
            this.labelAddJobs.Size = new System.Drawing.Size(77, 13);
            this.labelAddJobs.TabIndex = 5;
            this.labelAddJobs.Text = "Add Jobs Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Timout Time";
            // 
            // FinishJobBy
            // 
            this.FinishJobBy.Location = new System.Drawing.Point(30, 201);
            this.FinishJobBy.Name = "FinishJobBy";
            this.FinishJobBy.Size = new System.Drawing.Size(100, 20);
            this.FinishJobBy.TabIndex = 7;
            this.FinishJobBy.TextChanged += new System.EventHandler(this.FinishJobBy_TextChanged);
            // 
            // buttonWrapUp
            // 
            this.buttonWrapUp.Location = new System.Drawing.Point(641, 437);
            this.buttonWrapUp.Name = "buttonWrapUp";
            this.buttonWrapUp.Size = new System.Drawing.Size(104, 23);
            this.buttonWrapUp.TabIndex = 8;
            this.buttonWrapUp.Text = "Wrap Up";
            this.buttonWrapUp.UseVisualStyleBackColor = true;
            this.buttonWrapUp.Click += new System.EventHandler(this.buttonWrapUp_Click);
            // 
            // textboxGlobalCounter
            // 
            this.textboxGlobalCounter.Location = new System.Drawing.Point(645, 36);
            this.textboxGlobalCounter.Name = "textboxGlobalCounter";
            this.textboxGlobalCounter.ReadOnly = true;
            this.textboxGlobalCounter.Size = new System.Drawing.Size(100, 20);
            this.textboxGlobalCounter.TabIndex = 9;
            this.textboxGlobalCounter.TextChanged += new System.EventHandler(this.textboxGlobalCounter_TextChanged);
            // 
            // textboxLocalCounter
            // 
            this.textboxLocalCounter.Location = new System.Drawing.Point(645, 94);
            this.textboxLocalCounter.Name = "textboxLocalCounter";
            this.textboxLocalCounter.ReadOnly = true;
            this.textboxLocalCounter.Size = new System.Drawing.Size(100, 20);
            this.textboxLocalCounter.TabIndex = 10;
            this.textboxLocalCounter.TextChanged += new System.EventHandler(this.textboxLocalCounter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Global Counter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Local Counters Added Up";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(156, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Increment Counter\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loggerTextBox
            // 
            this.loggerTextBox.Location = new System.Drawing.Point(30, 249);
            this.loggerTextBox.Multiline = true;
            this.loggerTextBox.Name = "loggerTextBox";
            this.loggerTextBox.ReadOnly = true;
            this.loggerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loggerTextBox.Size = new System.Drawing.Size(515, 301);
            this.loggerTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.loggerTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxLocalCounter);
            this.Controls.Add(this.textboxGlobalCounter);
            this.Controls.Add(this.buttonWrapUp);
            this.Controls.Add(this.FinishJobBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddJobs);
            this.Controls.Add(this.buttonAddLowest);
            this.Controls.Add(this.buttonAddBelowNormal);
            this.Controls.Add(this.buttonAddNormal);
            this.Controls.Add(this.buttonAddAboveNormal);
            this.Controls.Add(this.buttonAddHighest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddHighest;
        private System.Windows.Forms.Button buttonAddAboveNormal;
        private System.Windows.Forms.Button buttonAddNormal;
        private System.Windows.Forms.Button buttonAddBelowNormal;
        private System.Windows.Forms.Button buttonAddLowest;
        private System.Windows.Forms.Label labelAddJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FinishJobBy;
        private System.Windows.Forms.Button buttonWrapUp;
        private System.Windows.Forms.TextBox textboxGlobalCounter;
        private System.Windows.Forms.TextBox textboxLocalCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox loggerTextBox;
    }
}

