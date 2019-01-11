using System;
using System.Windows;
using System.Windows.Forms;
using System.ComponentModel;
namespace GuiCalculator
{
    partial class CalculatorGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MemoryClearButton = new System.Windows.Forms.Button();
            this.MemoryRecallButton = new System.Windows.Forms.Button();
            this.MemoryStoreButton = new System.Windows.Forms.Button();
            this.MemoryAddButton = new System.Windows.Forms.Button();
            this.Number7Button = new System.Windows.Forms.Button();
            this.Number8Button = new System.Windows.Forms.Button();
            this.Number9Button = new System.Windows.Forms.Button();
            this.Number4Button = new System.Windows.Forms.Button();
            this.Number5Button = new System.Windows.Forms.Button();
            this.Number6Button = new System.Windows.Forms.Button();
            this.Number1Button = new System.Windows.Forms.Button();
            this.Number2Button = new System.Windows.Forms.Button();
            this.Number3Button = new System.Windows.Forms.Button();
            this.Number0Button = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.EquationTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.EquateButton = new System.Windows.Forms.Button();
            this.ReciprocalButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.OpenParenButton = new System.Windows.Forms.Button();
            this.ClosedParenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.BackColor = System.Drawing.Color.White;
            this.NumberTextBox.Location = new System.Drawing.Point(10, 39);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(260, 20);
            this.NumberTextBox.TabIndex = 0;
            this.NumberTextBox.Text = "0";
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.ForeColor = System.Drawing.Color.Red;
            this.BackspaceButton.Location = new System.Drawing.Point(48, 65);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(69, 23);
            this.BackspaceButton.TabIndex = 1;
            this.BackspaceButton.Text = "Backspace";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.ForeColor = System.Drawing.Color.Red;
            this.ClearEntryButton.Location = new System.Drawing.Point(123, 65);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(66, 23);
            this.ClearEntryButton.TabIndex = 2;
            this.ClearEntryButton.Text = "Clear Entry";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearEntryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(195, 65);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MemoryClearButton
            // 
            this.MemoryClearButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryClearButton.Location = new System.Drawing.Point(10, 162);
            this.MemoryClearButton.Name = "MemoryClearButton";
            this.MemoryClearButton.Size = new System.Drawing.Size(36, 28);
            this.MemoryClearButton.TabIndex = 4;
            this.MemoryClearButton.Text = "MC";
            this.MemoryClearButton.UseVisualStyleBackColor = true;
            this.MemoryClearButton.Click += new System.EventHandler(this.MemoryClearButton_Click);
            // 
            // MemoryRecallButton
            // 
            this.MemoryRecallButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryRecallButton.Location = new System.Drawing.Point(10, 94);
            this.MemoryRecallButton.Name = "MemoryRecallButton";
            this.MemoryRecallButton.Size = new System.Drawing.Size(36, 28);
            this.MemoryRecallButton.TabIndex = 5;
            this.MemoryRecallButton.Text = "MR";
            this.MemoryRecallButton.UseVisualStyleBackColor = true;
            this.MemoryRecallButton.Click += new System.EventHandler(this.MemoryRecallButton_Click);
            // 
            // MemoryStoreButton
            // 
            this.MemoryStoreButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryStoreButton.Location = new System.Drawing.Point(10, 128);
            this.MemoryStoreButton.Name = "MemoryStoreButton";
            this.MemoryStoreButton.Size = new System.Drawing.Size(36, 28);
            this.MemoryStoreButton.TabIndex = 6;
            this.MemoryStoreButton.Text = "MS";
            this.MemoryStoreButton.UseVisualStyleBackColor = true;
            this.MemoryStoreButton.Click += new System.EventHandler(this.MemoryStoreButton_Click);
            // 
            // MemoryAddButton
            // 
            this.MemoryAddButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryAddButton.Location = new System.Drawing.Point(10, 196);
            this.MemoryAddButton.Name = "MemoryAddButton";
            this.MemoryAddButton.Size = new System.Drawing.Size(36, 28);
            this.MemoryAddButton.TabIndex = 8;
            this.MemoryAddButton.Text = "M+";
            this.MemoryAddButton.UseVisualStyleBackColor = true;
            this.MemoryAddButton.Click += new System.EventHandler(this.MemoryAddButton_Click);
            // 
            // Number7Button
            // 
            this.Number7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number7Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number7Button.Location = new System.Drawing.Point(52, 94);
            this.Number7Button.Name = "Number7Button";
            this.Number7Button.Size = new System.Drawing.Size(36, 28);
            this.Number7Button.TabIndex = 9;
            this.Number7Button.Text = "7";
            this.Number7Button.UseVisualStyleBackColor = true;
            this.Number7Button.Click += new System.EventHandler(this.Number7Button_Click);
            // 
            // Number8Button
            // 
            this.Number8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number8Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number8Button.Location = new System.Drawing.Point(94, 93);
            this.Number8Button.Name = "Number8Button";
            this.Number8Button.Size = new System.Drawing.Size(36, 28);
            this.Number8Button.TabIndex = 10;
            this.Number8Button.Text = "8";
            this.Number8Button.UseVisualStyleBackColor = true;
            this.Number8Button.Click += new System.EventHandler(this.Number8Button_Click);
            // 
            // Number9Button
            // 
            this.Number9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number9Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number9Button.Location = new System.Drawing.Point(136, 94);
            this.Number9Button.Name = "Number9Button";
            this.Number9Button.Size = new System.Drawing.Size(36, 28);
            this.Number9Button.TabIndex = 11;
            this.Number9Button.Text = "9";
            this.Number9Button.UseVisualStyleBackColor = true;
            this.Number9Button.Click += new System.EventHandler(this.Number9Button_Click);
            // 
            // Number4Button
            // 
            this.Number4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number4Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number4Button.Location = new System.Drawing.Point(52, 127);
            this.Number4Button.Name = "Number4Button";
            this.Number4Button.Size = new System.Drawing.Size(36, 28);
            this.Number4Button.TabIndex = 12;
            this.Number4Button.Text = "4";
            this.Number4Button.UseVisualStyleBackColor = true;
            this.Number4Button.Click += new System.EventHandler(this.Number4Button_Click);
            // 
            // Number5Button
            // 
            this.Number5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number5Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number5Button.Location = new System.Drawing.Point(94, 128);
            this.Number5Button.Name = "Number5Button";
            this.Number5Button.Size = new System.Drawing.Size(36, 28);
            this.Number5Button.TabIndex = 13;
            this.Number5Button.Text = "5";
            this.Number5Button.UseVisualStyleBackColor = true;
            this.Number5Button.Click += new System.EventHandler(this.Number5Button_Click);
            // 
            // Number6Button
            // 
            this.Number6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number6Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number6Button.Location = new System.Drawing.Point(136, 128);
            this.Number6Button.Name = "Number6Button";
            this.Number6Button.Size = new System.Drawing.Size(36, 28);
            this.Number6Button.TabIndex = 14;
            this.Number6Button.Text = "6";
            this.Number6Button.UseVisualStyleBackColor = true;
            this.Number6Button.Click += new System.EventHandler(this.Number6Button_Click);
            // 
            // Number1Button
            // 
            this.Number1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number1Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number1Button.Location = new System.Drawing.Point(52, 161);
            this.Number1Button.Name = "Number1Button";
            this.Number1Button.Size = new System.Drawing.Size(36, 28);
            this.Number1Button.TabIndex = 15;
            this.Number1Button.Text = "1";
            this.Number1Button.UseVisualStyleBackColor = true;
            this.Number1Button.Click += new System.EventHandler(this.Number1Button_Click);
            // 
            // Number2Button
            // 
            this.Number2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number2Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number2Button.Location = new System.Drawing.Point(94, 162);
            this.Number2Button.Name = "Number2Button";
            this.Number2Button.Size = new System.Drawing.Size(36, 28);
            this.Number2Button.TabIndex = 16;
            this.Number2Button.Text = "2";
            this.Number2Button.UseVisualStyleBackColor = true;
            this.Number2Button.Click += new System.EventHandler(this.Number2Button_Click);
            // 
            // Number3Button
            // 
            this.Number3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number3Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number3Button.Location = new System.Drawing.Point(136, 161);
            this.Number3Button.Name = "Number3Button";
            this.Number3Button.Size = new System.Drawing.Size(36, 28);
            this.Number3Button.TabIndex = 17;
            this.Number3Button.Text = "3";
            this.Number3Button.UseVisualStyleBackColor = true;
            this.Number3Button.Click += new System.EventHandler(this.Number3Button_Click);
            // 
            // Number0Button
            // 
            this.Number0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Number0Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Number0Button.Location = new System.Drawing.Point(52, 196);
            this.Number0Button.Name = "Number0Button";
            this.Number0Button.Size = new System.Drawing.Size(36, 28);
            this.Number0Button.TabIndex = 18;
            this.Number0Button.Text = "0";
            this.Number0Button.UseVisualStyleBackColor = true;
            this.Number0Button.Click += new System.EventHandler(this.Number0Button_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DecimalButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DecimalButton.Location = new System.Drawing.Point(136, 196);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(36, 28);
            this.DecimalButton.TabIndex = 19;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // SignButton
            // 
            this.SignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SignButton.Location = new System.Drawing.Point(94, 196);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(36, 28);
            this.SignButton.TabIndex = 20;
            this.SignButton.Text = "+/-";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // EquationTextBox
            // 
            this.EquationTextBox.BackColor = System.Drawing.Color.White;
            this.EquationTextBox.Location = new System.Drawing.Point(10, 13);
            this.EquationTextBox.Name = "EquationTextBox";
            this.EquationTextBox.ReadOnly = true;
            this.EquationTextBox.Size = new System.Drawing.Size(260, 20);
            this.EquationTextBox.TabIndex = 21;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.ForeColor = System.Drawing.Color.Red;
            this.AddButton.Location = new System.Drawing.Point(178, 93);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 28);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SubtractButton.ForeColor = System.Drawing.Color.Red;
            this.SubtractButton.Location = new System.Drawing.Point(178, 128);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(36, 28);
            this.SubtractButton.TabIndex = 23;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MultiplyButton.ForeColor = System.Drawing.Color.Red;
            this.MultiplyButton.Location = new System.Drawing.Point(178, 162);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(36, 28);
            this.MultiplyButton.TabIndex = 24;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DivideButton.ForeColor = System.Drawing.Color.Red;
            this.DivideButton.Location = new System.Drawing.Point(178, 196);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(36, 28);
            this.DivideButton.TabIndex = 25;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // EquateButton
            // 
            this.EquateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EquateButton.ForeColor = System.Drawing.Color.Red;
            this.EquateButton.Location = new System.Drawing.Point(220, 196);
            this.EquateButton.Name = "EquateButton";
            this.EquateButton.Size = new System.Drawing.Size(41, 28);
            this.EquateButton.TabIndex = 26;
            this.EquateButton.Text = "=";
            this.EquateButton.UseVisualStyleBackColor = true;
            this.EquateButton.Click += new EventHandler(this.EquateButton_Click);
            // 
            // ReciprocalButton
            // 
            this.ReciprocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReciprocalButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ReciprocalButton.Location = new System.Drawing.Point(220, 162);
            this.ReciprocalButton.Name = "ReciprocalButton";
            this.ReciprocalButton.Size = new System.Drawing.Size(41, 28);
            this.ReciprocalButton.TabIndex = 27;
            this.ReciprocalButton.Text = "1/x";
            this.ReciprocalButton.UseVisualStyleBackColor = true;
            this.ReciprocalButton.Click += new EventHandler(this.ReciprocalButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PercentButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PercentButton.Location = new System.Drawing.Point(220, 128);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(41, 28);
            this.PercentButton.TabIndex = 28;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = true;
            this.PercentButton.Click += new EventHandler(this.PercentButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SquareRootButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SquareRootButton.Location = new System.Drawing.Point(220, 94);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(41, 28);
            this.SquareRootButton.TabIndex = 29;
            this.SquareRootButton.Text = "Sqrt";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new EventHandler(this.SquareRootButton_Click);
            // 
            // OpenParenButon
            // 
            this.OpenParenButton.Location = new System.Drawing.Point(10, 64);
            this.OpenParenButton.Name = "OpenParenButon";
            this.OpenParenButton.Size = new System.Drawing.Size(14, 23);
            this.OpenParenButton.TabIndex = 30;
            this.OpenParenButton.Text = "(";
            this.OpenParenButton.UseVisualStyleBackColor = true;
            this.OpenParenButton.Click += new EventHandler(this.OpenParenButton_Click);
            // 
            // ClosedParenButton
            // 
            this.ClosedParenButton.Location = new System.Drawing.Point(30, 64);
            this.ClosedParenButton.Name = "ClosedParenButton";
            this.ClosedParenButton.Size = new System.Drawing.Size(14, 23);
            this.ClosedParenButton.TabIndex = 31;
            this.ClosedParenButton.Text = ")";
            this.ClosedParenButton.UseVisualStyleBackColor = true;
            this.ClosedParenButton.Click += new EventHandler(this.ClosedParenButton_Click);
            // 
            // CalculatorGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.ClosedParenButton);
            this.Controls.Add(this.OpenParenButton);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.PercentButton);
            this.Controls.Add(this.ReciprocalButton);
            this.Controls.Add(this.EquateButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EquationTextBox);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.Number0Button);
            this.Controls.Add(this.Number3Button);
            this.Controls.Add(this.Number2Button);
            this.Controls.Add(this.Number1Button);
            this.Controls.Add(this.Number6Button);
            this.Controls.Add(this.Number5Button);
            this.Controls.Add(this.Number4Button);
            this.Controls.Add(this.Number9Button);
            this.Controls.Add(this.Number8Button);
            this.Controls.Add(this.Number7Button);
            this.Controls.Add(this.MemoryAddButton);
            this.Controls.Add(this.MemoryStoreButton);
            this.Controls.Add(this.MemoryRecallButton);
            this.Controls.Add(this.MemoryClearButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.NumberTextBox);
            this.KeyPreview = true;
            this.Name = "CalculatorGui";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorGui_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyControl);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox NumberTextBox;
        private Button BackspaceButton;
        private Button ClearEntryButton;
        private Button ClearButton;
        private Button MemoryClearButton;
        private Button MemoryRecallButton;
        private Button MemoryStoreButton;
        private Button MemoryAddButton;
        private Button Number7Button;
        private Button Number8Button;
        private Button Number9Button;
        private Button Number4Button;
        private Button Number5Button;
        private Button Number6Button;
        private Button Number1Button;
        private Button Number2Button;
        private Button Number3Button;
        private Button Number0Button;
        private Button DecimalButton;
        private Button SignButton;
        private TextBox EquationTextBox;
        private Button AddButton;
        private Button SubtractButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Button EquateButton;
        private Button ReciprocalButton;
        private Button PercentButton;
        private Button SquareRootButton;
        private Button OpenParenButton;
        private Button ClosedParenButton;
    }
}

