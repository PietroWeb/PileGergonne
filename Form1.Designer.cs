namespace PileGergonne
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numL = new System.Windows.Forms.NumericUpDown();
            this.lblL = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.tbKi = new System.Windows.Forms.TextBox();
            this.lblKi = new System.Windows.Forms.Label();
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosizioneEffettiva = new System.Windows.Forms.Label();
            this.lblPosizioneEffettivaValore = new System.Windows.Forms.Label();
            this.lblPosizioneHarrisonC = new System.Windows.Forms.Label();
            this.lblPosizioneHarrisonCValore = new System.Windows.Forms.Label();
            this.lblLimiteLValore = new System.Windows.Forms.Label();
            this.lblLimiteL = new System.Windows.Forms.Label();
            this.lblValoreSogliaMinimo = new System.Windows.Forms.Label();
            this.lblValoreSogliaMinimoValue = new System.Windows.Forms.Label();
            this.tbAnalisi = new System.Windows.Forms.TextBox();
            this.lblFormulaValida = new System.Windows.Forms.Label();
            this.gBValori = new System.Windows.Forms.GroupBox();
            this.gBMessaggio = new System.Windows.Forms.GroupBox();
            this.lblEsito = new System.Windows.Forms.Label();
            this.gbAnalisi = new System.Windows.Forms.GroupBox();
            this.btnColoreEsito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            this.gBValori.SuspendLayout();
            this.gBMessaggio.SuspendLayout();
            this.gbAnalisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(6, 28);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(13, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numL);
            this.groupBox1.Controls.Add(this.lblL);
            this.groupBox1.Controls.Add(this.numX);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.btnCalcola);
            this.groupBox1.Controls.Add(this.tbKi);
            this.groupBox1.Controls.Add(this.lblKi);
            this.groupBox1.Controls.Add(this.numP);
            this.groupBox1.Controls.Add(this.numN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurazione";
            // 
            // numL
            // 
            this.numL.Location = new System.Drawing.Point(269, 26);
            this.numL.Name = "numL";
            this.numL.Size = new System.Drawing.Size(42, 20);
            this.numL.TabIndex = 14;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(251, 29);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(9, 13);
            this.lblL.TabIndex = 13;
            this.lblL.Text = "l";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(178, 26);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(42, 20);
            this.numX.TabIndex = 10;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(160, 29);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 13);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "x";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(518, 23);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // tbKi
            // 
            this.tbKi.Location = new System.Drawing.Point(357, 24);
            this.tbKi.Name = "tbKi";
            this.tbKi.Size = new System.Drawing.Size(100, 20);
            this.tbKi.TabIndex = 7;
            this.tbKi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKi_KeyDown);
            // 
            // lblKi
            // 
            this.lblKi.AutoSize = true;
            this.lblKi.Location = new System.Drawing.Point(329, 28);
            this.lblKi.Name = "lblKi";
            this.lblKi.Size = new System.Drawing.Size(22, 13);
            this.lblKi.TabIndex = 6;
            this.lblKi.Text = "K_i";
            // 
            // numP
            // 
            this.numP.Location = new System.Drawing.Point(99, 26);
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(42, 20);
            this.numP.TabIndex = 5;
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(25, 26);
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(42, 20);
            this.numN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "p";
            // 
            // lblPosizioneEffettiva
            // 
            this.lblPosizioneEffettiva.AutoSize = true;
            this.lblPosizioneEffettiva.Location = new System.Drawing.Point(5, 49);
            this.lblPosizioneEffettiva.Name = "lblPosizioneEffettiva";
            this.lblPosizioneEffettiva.Size = new System.Drawing.Size(132, 13);
            this.lblPosizioneEffettiva.TabIndex = 2;
            this.lblPosizioneEffettiva.Text = "Posizione finale della carta";
            // 
            // lblPosizioneEffettivaValore
            // 
            this.lblPosizioneEffettivaValore.AutoSize = true;
            this.lblPosizioneEffettivaValore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosizioneEffettivaValore.Location = new System.Drawing.Point(238, 49);
            this.lblPosizioneEffettivaValore.Name = "lblPosizioneEffettivaValore";
            this.lblPosizioneEffettivaValore.Size = new System.Drawing.Size(14, 13);
            this.lblPosizioneEffettivaValore.TabIndex = 3;
            this.lblPosizioneEffettivaValore.Text = "?";
            // 
            // lblPosizioneHarrisonC
            // 
            this.lblPosizioneHarrisonC.AutoSize = true;
            this.lblPosizioneHarrisonC.Location = new System.Drawing.Point(5, 82);
            this.lblPosizioneHarrisonC.Name = "lblPosizioneHarrisonC";
            this.lblPosizioneHarrisonC.Size = new System.Drawing.Size(198, 13);
            this.lblPosizioneHarrisonC.TabIndex = 6;
            this.lblPosizioneHarrisonC.Text = "Posizione finale formula Harrison corretta";
            // 
            // lblPosizioneHarrisonCValore
            // 
            this.lblPosizioneHarrisonCValore.AutoSize = true;
            this.lblPosizioneHarrisonCValore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosizioneHarrisonCValore.Location = new System.Drawing.Point(238, 82);
            this.lblPosizioneHarrisonCValore.Name = "lblPosizioneHarrisonCValore";
            this.lblPosizioneHarrisonCValore.Size = new System.Drawing.Size(14, 13);
            this.lblPosizioneHarrisonCValore.TabIndex = 7;
            this.lblPosizioneHarrisonCValore.Text = "?";
            // 
            // lblLimiteLValore
            // 
            this.lblLimiteLValore.AutoSize = true;
            this.lblLimiteLValore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteLValore.Location = new System.Drawing.Point(238, 114);
            this.lblLimiteLValore.Name = "lblLimiteLValore";
            this.lblLimiteLValore.Size = new System.Drawing.Size(14, 13);
            this.lblLimiteLValore.TabIndex = 12;
            this.lblLimiteLValore.Text = "?";
            // 
            // lblLimiteL
            // 
            this.lblLimiteL.AutoSize = true;
            this.lblLimiteL.Location = new System.Drawing.Point(5, 114);
            this.lblLimiteL.Name = "lblLimiteL";
            this.lblLimiteL.Size = new System.Drawing.Size(13, 13);
            this.lblLimiteL.TabIndex = 11;
            this.lblLimiteL.Text = "L";
            // 
            // lblValoreSogliaMinimo
            // 
            this.lblValoreSogliaMinimo.AutoSize = true;
            this.lblValoreSogliaMinimo.Location = new System.Drawing.Point(5, 143);
            this.lblValoreSogliaMinimo.Name = "lblValoreSogliaMinimo";
            this.lblValoreSogliaMinimo.Size = new System.Drawing.Size(113, 13);
            this.lblValoreSogliaMinimo.TabIndex = 13;
            this.lblValoreSogliaMinimo.Text = "Valore di soglia minimo";
            // 
            // lblValoreSogliaMinimoValue
            // 
            this.lblValoreSogliaMinimoValue.AutoSize = true;
            this.lblValoreSogliaMinimoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoreSogliaMinimoValue.Location = new System.Drawing.Point(238, 143);
            this.lblValoreSogliaMinimoValue.Name = "lblValoreSogliaMinimoValue";
            this.lblValoreSogliaMinimoValue.Size = new System.Drawing.Size(14, 13);
            this.lblValoreSogliaMinimoValue.TabIndex = 14;
            this.lblValoreSogliaMinimoValue.Text = "?";
            // 
            // tbAnalisi
            // 
            this.tbAnalisi.Location = new System.Drawing.Point(6, 19);
            this.tbAnalisi.Multiline = true;
            this.tbAnalisi.Name = "tbAnalisi";
            this.tbAnalisi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAnalisi.Size = new System.Drawing.Size(360, 334);
            this.tbAnalisi.TabIndex = 16;
            // 
            // lblFormulaValida
            // 
            this.lblFormulaValida.AutoSize = true;
            this.lblFormulaValida.Location = new System.Drawing.Point(18, 25);
            this.lblFormulaValida.Name = "lblFormulaValida";
            this.lblFormulaValida.Size = new System.Drawing.Size(113, 13);
            this.lblFormulaValida.TabIndex = 17;
            this.lblFormulaValida.Text = "Formula valida per l  > ";
            // 
            // gBValori
            // 
            this.gBValori.Controls.Add(this.lblValoreSogliaMinimoValue);
            this.gBValori.Controls.Add(this.lblValoreSogliaMinimo);
            this.gBValori.Controls.Add(this.lblLimiteLValore);
            this.gBValori.Controls.Add(this.lblLimiteL);
            this.gBValori.Controls.Add(this.lblPosizioneHarrisonCValore);
            this.gBValori.Controls.Add(this.lblPosizioneHarrisonC);
            this.gBValori.Controls.Add(this.lblPosizioneEffettivaValore);
            this.gBValori.Controls.Add(this.lblPosizioneEffettiva);
            this.gBValori.Location = new System.Drawing.Point(12, 145);
            this.gBValori.Name = "gBValori";
            this.gBValori.Size = new System.Drawing.Size(305, 360);
            this.gBValori.TabIndex = 18;
            this.gBValori.TabStop = false;
            this.gBValori.Text = "Valori";
            // 
            // gBMessaggio
            // 
            this.gBMessaggio.Controls.Add(this.label2);
            this.gBMessaggio.Controls.Add(this.btnColoreEsito);
            this.gBMessaggio.Controls.Add(this.lblEsito);
            this.gBMessaggio.Controls.Add(this.lblFormulaValida);
            this.gBMessaggio.Location = new System.Drawing.Point(12, 80);
            this.gBMessaggio.Name = "gBMessaggio";
            this.gBMessaggio.Size = new System.Drawing.Size(684, 59);
            this.gBMessaggio.TabIndex = 19;
            this.gBMessaggio.TabStop = false;
            this.gBMessaggio.Text = "Esito";
            // 
            // lblEsito
            // 
            this.lblEsito.AutoSize = true;
            this.lblEsito.Location = new System.Drawing.Point(124, 25);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Size = new System.Drawing.Size(13, 13);
            this.lblEsito.TabIndex = 18;
            this.lblEsito.Text = "?";
            // 
            // gbAnalisi
            // 
            this.gbAnalisi.Controls.Add(this.tbAnalisi);
            this.gbAnalisi.Location = new System.Drawing.Point(323, 145);
            this.gbAnalisi.Name = "gbAnalisi";
            this.gbAnalisi.Size = new System.Drawing.Size(372, 359);
            this.gbAnalisi.TabIndex = 20;
            this.gbAnalisi.TabStop = false;
            this.gbAnalisi.Text = "Analisi";
            // 
            // btnColoreEsito
            // 
            this.btnColoreEsito.Location = new System.Drawing.Point(602, 15);
            this.btnColoreEsito.Name = "btnColoreEsito";
            this.btnColoreEsito.Size = new System.Drawing.Size(75, 33);
            this.btnColoreEsito.TabIndex = 19;
            this.btnColoreEsito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Esito del gioco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 517);
            this.Controls.Add(this.gbAnalisi);
            this.Controls.Add(this.gBMessaggio);
            this.Controls.Add(this.gBValori);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Le pile di Gergonne - Simulatore";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            this.gBValori.ResumeLayout(false);
            this.gBValori.PerformLayout();
            this.gBMessaggio.ResumeLayout(false);
            this.gBMessaggio.PerformLayout();
            this.gbAnalisi.ResumeLayout(false);
            this.gbAnalisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKi;
        private System.Windows.Forms.Label lblKi;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label lblPosizioneEffettiva;
        private System.Windows.Forms.Label lblPosizioneEffettivaValore;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown numL;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblPosizioneHarrisonC;
        private System.Windows.Forms.Label lblPosizioneHarrisonCValore;
        private System.Windows.Forms.Label lblLimiteLValore;
        private System.Windows.Forms.Label lblLimiteL;
        private System.Windows.Forms.Label lblValoreSogliaMinimo;
        private System.Windows.Forms.Label lblValoreSogliaMinimoValue;
        private System.Windows.Forms.TextBox tbAnalisi;
        private System.Windows.Forms.Label lblFormulaValida;
        private System.Windows.Forms.GroupBox gBValori;
        private System.Windows.Forms.GroupBox gBMessaggio;
        private System.Windows.Forms.Label lblEsito;
        private System.Windows.Forms.GroupBox gbAnalisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColoreEsito;
    }
}

