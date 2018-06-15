namespace CatchTheButton
{
    partial class catchMeForm
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
            this.buttonCatchMe = new System.Windows.Forms.Button();
            this.winBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCatchMe
            // 
            this.buttonCatchMe.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonCatchMe.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonCatchMe.FlatAppearance.BorderSize = 3;
            this.buttonCatchMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatchMe.ForeColor = System.Drawing.Color.Navy;
            this.buttonCatchMe.Location = new System.Drawing.Point(38, 27);
            this.buttonCatchMe.Name = "buttonCatchMe";
            this.buttonCatchMe.Size = new System.Drawing.Size(69, 66);
            this.buttonCatchMe.TabIndex = 0;
            this.buttonCatchMe.Text = "Catch Me!";
            this.buttonCatchMe.UseVisualStyleBackColor = false;
            this.buttonCatchMe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCatchMe_MouseClick);
            this.buttonCatchMe.MouseEnter += new System.EventHandler(this.buttonCatchMe_MouseEnter);
            // 
            // winBox
            // 
            this.winBox.BackColor = System.Drawing.Color.PaleGreen;
            this.winBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winBox.ForeColor = System.Drawing.Color.Tomato;
            this.winBox.Location = new System.Drawing.Point(162, 89);
            this.winBox.Multiline = true;
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(121, 54);
            this.winBox.TabIndex = 1;
            this.winBox.Text = "Congratulations!\r\nYou win!";
            this.winBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winBox.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(185, 149);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // catchMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.winBox);
            this.Controls.Add(this.buttonCatchMe);
            this.Name = "catchMeForm";
            this.Text = "Catch Me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCatchMe;
        private System.Windows.Forms.TextBox winBox;
        private System.Windows.Forms.Button okButton;
    }
}

