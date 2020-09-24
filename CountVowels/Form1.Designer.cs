namespace CountVowels
{
    partial class FrmMain
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtNumVowels = new System.Windows.Forms.TextBox();
            this.lblVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(13, 13);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(1317, 32);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "Enter a paragraph of text. All vowels, upper and lowercase will be counted. Y is " +
    "not considered  a vowel.";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(19, 91);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1311, 38);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 206);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(152, 89);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtNumVowels
            // 
            this.txtNumVowels.Location = new System.Drawing.Point(170, 232);
            this.txtNumVowels.Name = "txtNumVowels";
            this.txtNumVowels.Size = new System.Drawing.Size(170, 38);
            this.txtNumVowels.TabIndex = 3;
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(346, 238);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(102, 32);
            this.lblVowels.TabIndex = 4;
            this.lblVowels.Text = "vowels";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 307);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.txtNumVowels);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblDirections);
            this.Name = "FrmMain";
            this.Text = "Count Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtNumVowels;
        private System.Windows.Forms.Label lblVowels;
    }
}

