namespace calculadora1
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSumar.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSumar.Location = new System.Drawing.Point(12, 122);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(100, 100);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestar.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRestar.Location = new System.Drawing.Point(118, 122);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(100, 100);
            this.btnRestar.TabIndex = 1;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMultiplicar.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMultiplicar.Location = new System.Drawing.Point(224, 122);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 100);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDividir.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDividir.Location = new System.Drawing.Point(330, 122);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(100, 100);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnBA
            // 
            this.btnBA.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBA.Font = new System.Drawing.Font("Core Circus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBA.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnBA.Location = new System.Drawing.Point(330, 228);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(100, 100);
            this.btnBA.TabIndex = 4;
            this.btnBA.Text = "🠠";
            this.btnBA.UseVisualStyleBackColor = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCE.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCE.Location = new System.Drawing.Point(330, 334);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(100, 100);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnResultado.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnResultado.Location = new System.Drawing.Point(330, 440);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 203);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtIngreso.Font = new System.Drawing.Font("DM Sans", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.ForeColor = System.Drawing.Color.Black;
            this.txtIngreso.Location = new System.Drawing.Point(12, 22);
            this.txtIngreso.MaximumSize = new System.Drawing.Size(418, 84);
            this.txtIngreso.MinimumSize = new System.Drawing.Size(418, 84);
            this.txtIngreso.Multiline = true;
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(418, 84);
            this.txtIngreso.TabIndex = 7;
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUno.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnUno.Location = new System.Drawing.Point(12, 228);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(100, 100);
            this.btnUno.TabIndex = 8;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDos.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnDos.Location = new System.Drawing.Point(118, 228);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(100, 100);
            this.btnDos.TabIndex = 9;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnTres.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnTres.Location = new System.Drawing.Point(224, 228);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(100, 100);
            this.btnTres.TabIndex = 10;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSeis.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnSeis.Location = new System.Drawing.Point(224, 334);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(100, 100);
            this.btnSeis.TabIndex = 13;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCinco.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCinco.Location = new System.Drawing.Point(118, 334);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(100, 100);
            this.btnCinco.TabIndex = 12;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCuatro.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCuatro.Location = new System.Drawing.Point(12, 334);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(100, 100);
            this.btnCuatro.TabIndex = 11;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNueve.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNueve.Location = new System.Drawing.Point(224, 440);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(100, 100);
            this.btnNueve.TabIndex = 16;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOcho.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnOcho.Location = new System.Drawing.Point(118, 440);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(100, 100);
            this.btnOcho.TabIndex = 15;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSiete.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnSiete.Location = new System.Drawing.Point(12, 440);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(100, 100);
            this.btnSiete.TabIndex = 14;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCero.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCero.Location = new System.Drawing.Point(12, 546);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(206, 100);
            this.btnCero.TabIndex = 17;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPunto.Font = new System.Drawing.Font("Core Circus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnPunto.Location = new System.Drawing.Point(224, 546);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(100, 100);
            this.btnPunto.TabIndex = 18;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(442, 688);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(464, 744);
            this.MinimumSize = new System.Drawing.Size(464, 744);
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
    }
}

