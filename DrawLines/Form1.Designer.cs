namespace DrawLines
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtIncr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dessin = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Menu.Controls.Add(this.btnSave);
            this.Menu.Controls.Add(this.btnDraw);
            this.Menu.Controls.Add(this.txtIncr);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.txtLength);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.txtAngle);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.txtLines);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(627, 38);
            this.Menu.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(540, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 22);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sauvegarde";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.White;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Location = new System.Drawing.Point(443, 10);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 22);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Dessiner";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtIncr
            // 
            this.txtIncr.BackColor = System.Drawing.Color.White;
            this.txtIncr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncr.Location = new System.Drawing.Point(360, 10);
            this.txtIncr.Name = "txtIncr";
            this.txtIncr.Size = new System.Drawing.Size(43, 22);
            this.txtIncr.TabIndex = 7;
            this.txtIncr.Text = "10";
            this.txtIncr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Increment";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.White;
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Location = new System.Drawing.Point(252, 10);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(43, 22);
            this.txtLength.TabIndex = 5;
            this.txtLength.Text = "500";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Longeur";
            // 
            // txtAngle
            // 
            this.txtAngle.BackColor = System.Drawing.Color.White;
            this.txtAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAngle.Location = new System.Drawing.Point(150, 10);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(43, 22);
            this.txtAngle.TabIndex = 3;
            this.txtAngle.Text = "45";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle";
            // 
            // txtLines
            // 
            this.txtLines.BackColor = System.Drawing.Color.White;
            this.txtLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLines.Location = new System.Drawing.Point(54, 10);
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(43, 22);
            this.txtLines.TabIndex = 1;
            this.txtLines.Text = "10";
            this.txtLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lignes";
            // 
            // Dessin
            // 
            this.Dessin.BackColor = System.Drawing.Color.White;
            this.Dessin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dessin.Location = new System.Drawing.Point(0, 38);
            this.Dessin.Name = "Dessin";
            this.Dessin.Size = new System.Drawing.Size(627, 381);
            this.Dessin.TabIndex = 1;
            this.Dessin.Click += new System.EventHandler(this.Dessin_Click);
            this.Dessin.Paint += new System.Windows.Forms.PaintEventHandler(this.Dessin_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 419);
            this.Controls.Add(this.Dessin);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Lignes";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtIncr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dessin;
        private System.Windows.Forms.Button btnSave;
    }
}

