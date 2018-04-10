namespace Caesar_Cipher
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
            this.PlainBox = new System.Windows.Forms.TextBox();
            this.CipherBox = new System.Windows.Forms.TextBox();
            this.CipherButton = new System.Windows.Forms.Button();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.PlainLabel = new System.Windows.Forms.Label();
            this.CipherLabel = new System.Windows.Forms.Label();
            this.ShiftInput = new System.Windows.Forms.NumericUpDown();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.ShiftAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftInput)).BeginInit();
            this.SuspendLayout();
            // 
            // PlainBox
            // 
            this.PlainBox.Location = new System.Drawing.Point(13, 32);
            this.PlainBox.Multiline = true;
            this.PlainBox.Name = "PlainBox";
            this.PlainBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PlainBox.Size = new System.Drawing.Size(259, 173);
            this.PlainBox.TabIndex = 0;
            // 
            // CipherBox
            // 
            this.CipherBox.Location = new System.Drawing.Point(13, 309);
            this.CipherBox.Multiline = true;
            this.CipherBox.Name = "CipherBox";
            this.CipherBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CipherBox.Size = new System.Drawing.Size(259, 183);
            this.CipherBox.TabIndex = 1;
            // 
            // CipherButton
            // 
            this.CipherButton.Location = new System.Drawing.Point(47, 260);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(75, 23);
            this.CipherButton.TabIndex = 2;
            this.CipherButton.Text = "Cipher";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // DecipherButton
            // 
            this.DecipherButton.Location = new System.Drawing.Point(157, 260);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(75, 23);
            this.DecipherButton.TabIndex = 3;
            this.DecipherButton.Text = "Decipher";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // PlainLabel
            // 
            this.PlainLabel.AutoSize = true;
            this.PlainLabel.Location = new System.Drawing.Point(13, 13);
            this.PlainLabel.Name = "PlainLabel";
            this.PlainLabel.Size = new System.Drawing.Size(30, 13);
            this.PlainLabel.TabIndex = 4;
            this.PlainLabel.Text = "Plain";
            // 
            // CipherLabel
            // 
            this.CipherLabel.AutoSize = true;
            this.CipherLabel.Location = new System.Drawing.Point(13, 290);
            this.CipherLabel.Name = "CipherLabel";
            this.CipherLabel.Size = new System.Drawing.Size(37, 13);
            this.CipherLabel.TabIndex = 5;
            this.CipherLabel.Text = "Cipher";
            // 
            // ShiftInput
            // 
            this.ShiftInput.Location = new System.Drawing.Point(101, 211);
            this.ShiftInput.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.ShiftInput.Minimum = new decimal(new int[] {
            26,
            0,
            0,
            -2147483648});
            this.ShiftInput.Name = "ShiftInput";
            this.ShiftInput.Size = new System.Drawing.Size(120, 20);
            this.ShiftInput.TabIndex = 6;
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Location = new System.Drawing.Point(64, 214);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(28, 13);
            this.ShiftLabel.TabIndex = 7;
            this.ShiftLabel.Text = "Shift";
            // 
            // ShiftAll
            // 
            this.ShiftAll.AutoSize = true;
            this.ShiftAll.Location = new System.Drawing.Point(110, 237);
            this.ShiftAll.Name = "ShiftAll";
            this.ShiftAll.Size = new System.Drawing.Size(60, 17);
            this.ShiftAll.TabIndex = 8;
            this.ShiftAll.Text = "Shift all";
            this.ShiftAll.UseVisualStyleBackColor = true;
            this.ShiftAll.CheckedChanged += new System.EventHandler(this.ShiftAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 500);
            this.Controls.Add(this.ShiftAll);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.ShiftInput);
            this.Controls.Add(this.CipherLabel);
            this.Controls.Add(this.PlainLabel);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.CipherBox);
            this.Controls.Add(this.PlainBox);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.ShiftInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlainBox;
        private System.Windows.Forms.TextBox CipherBox;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.Label PlainLabel;
        private System.Windows.Forms.Label CipherLabel;
        private System.Windows.Forms.NumericUpDown ShiftInput;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.CheckBox ShiftAll;
    }
}

