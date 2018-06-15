﻿namespace _13.TurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.buttonDrawHexagon = new System.Windows.Forms.Button();
            this.buttonDrawStar = new System.Windows.Forms.Button();
            this.buttonDrawSpiral = new System.Windows.Forms.Button();
            this.buttonDrawSun = new System.Windows.Forms.Button();
            this.buttonDrawTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 25);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 69);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(13, 114);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(75, 23);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // buttonDrawHexagon
            // 
            this.buttonDrawHexagon.Location = new System.Drawing.Point(13, 160);
            this.buttonDrawHexagon.Name = "buttonDrawHexagon";
            this.buttonDrawHexagon.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawHexagon.TabIndex = 3;
            this.buttonDrawHexagon.Text = "Hexagon";
            this.buttonDrawHexagon.UseVisualStyleBackColor = true;
            this.buttonDrawHexagon.Click += new System.EventHandler(this.buttonDrawHexagon_Click);
            // 
            // buttonDrawStar
            // 
            this.buttonDrawStar.Location = new System.Drawing.Point(13, 204);
            this.buttonDrawStar.Name = "buttonDrawStar";
            this.buttonDrawStar.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawStar.TabIndex = 4;
            this.buttonDrawStar.Text = "Star";
            this.buttonDrawStar.UseVisualStyleBackColor = true;
            this.buttonDrawStar.Click += new System.EventHandler(this.buttonDrawStar_Click);
            // 
            // buttonDrawSpiral
            // 
            this.buttonDrawSpiral.Location = new System.Drawing.Point(13, 249);
            this.buttonDrawSpiral.Name = "buttonDrawSpiral";
            this.buttonDrawSpiral.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawSpiral.TabIndex = 5;
            this.buttonDrawSpiral.Text = "Spiral";
            this.buttonDrawSpiral.UseVisualStyleBackColor = true;
            this.buttonDrawSpiral.Click += new System.EventHandler(this.buttonDrawSpiral_Click);
            // 
            // buttonDrawSun
            // 
            this.buttonDrawSun.Location = new System.Drawing.Point(12, 295);
            this.buttonDrawSun.Name = "buttonDrawSun";
            this.buttonDrawSun.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawSun.TabIndex = 6;
            this.buttonDrawSun.Text = "Sun";
            this.buttonDrawSun.UseVisualStyleBackColor = true;
            this.buttonDrawSun.Click += new System.EventHandler(this.buttonDrawSun_Click);
            // 
            // buttonDrawTriangle
            // 
            this.buttonDrawTriangle.Location = new System.Drawing.Point(12, 335);
            this.buttonDrawTriangle.Name = "buttonDrawTriangle";
            this.buttonDrawTriangle.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawTriangle.TabIndex = 7;
            this.buttonDrawTriangle.Text = "Triangle";
            this.buttonDrawTriangle.UseVisualStyleBackColor = true;
            this.buttonDrawTriangle.Click += new System.EventHandler(this.buttonDrawTriangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 359);
            this.Controls.Add(this.buttonDrawTriangle);
            this.Controls.Add(this.buttonDrawSun);
            this.Controls.Add(this.buttonDrawSpiral);
            this.Controls.Add(this.buttonDrawStar);
            this.Controls.Add(this.buttonDrawHexagon);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Turtle Graphics - Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button buttonDrawHexagon;
        private System.Windows.Forms.Button buttonDrawStar;
        private System.Windows.Forms.Button buttonDrawSpiral;
        private System.Windows.Forms.Button buttonDrawSun;
        private System.Windows.Forms.Button buttonDrawTriangle;
    }
}

