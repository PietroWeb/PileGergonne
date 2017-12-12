/*	Copyright (c) 2017 Pietro Vitelli
	This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PileGergonne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            int i = 0;
            int n = (int)numN.Value; //Numero di carte presenti in ciascuna pila
            int p = (int)numP.Value; //Numero di pile (colonne)
            int x = (int)numX.Value; //Posizione iniziale della carta scelta dall'utente

            string[] ki = tbKi.Text.Split(',');
            int m = ki.Length; // m è il numero di ridistribuzioni di cui si compone una iterazione e ci è dato dal numero di valori k impostati

            int l = (int)numL.Value; //Numero di iterazioni scelto per il gioco (una iterazione corrisponde ad m ridistribuzioni)

            int sum = 0;
            int sum1 = 0;

            for (i = 1; i <= m * l; i++) {
                int k = Int16.Parse(ki[(i - 1) % m]);
                sum += (int)((k * n + p - 1) * Math.Pow(p, i - 1));
            }

            for (i = 1; i <= m; i++) // sum_{i=i}^{m}()
            {
                int k = Int16.Parse(ki[(i - 1)]);
                sum1 += (int)(k * n * Math.Pow(p, i - 1));
            }

            //Valore effettivo della posizione finale della carta scelta
            int numC = (int)Math.Floor((x + sum) / Math.Pow(p, m * l));

            //Valore di L, ossia valore del limite a cui tende la funzione di Harrison et al. che rappresenta le posizioni finali della carta scelta, 
            //quando il numero di iterazioni l tende ad infinito.
            double numF = (sum1) / (Math.Pow(p, m) - 1) + 1;

            //Posizione finale della carta, calcolata con la formula di Harrison:
            //L-1 se L è intero e x<L, Parte intera di L in tutti gli altri casi 
            if (numF == (double)((int)numF) && x < numF)
            {
                lblPosizioneHarrisonCValore.Text = "* " + ((int)Math.Floor(numF) - 1);
                lblPosizioneHarrisonC.Text = "Posizione finale formula Harrison corretta*";
            }
            else {
                lblPosizioneHarrisonCValore.Text = "" + (int)Math.Floor(numF);
                lblPosizioneHarrisonC.Text = "Posizione finale formula Harrison corretta";
            }

            //double numF2 = (sum1) / Math.Pow(p, m)+1;

            lblPosizioneEffettivaValore.Text = "" + numC;
            lblLimiteLValore.Text = "" + Math.Round(numF, 3);

            double mod = (double)(sum1 % (Math.Pow(p, m) - 1));
            if (x > numF)
            {
                lblValoreSogliaMinimoValue.Text = "" + Math.Round((Math.Log(Math.Abs(x - sum1 / (Math.Pow(p, m) - 1) - 1), p) / m + Math.Log(Math.Abs((Math.Pow(p, m) - 1) / (Math.Pow(p, m) - 1 - mod)), p) / m), 3);
            }
            else if (numF == (double)((int)numF))
            {
                lblValoreSogliaMinimoValue.Text = "" + Math.Round((Math.Log(Math.Abs(x - sum1 / (Math.Pow(p, m) - 1) - 1), p) / m), 3);
            }
            else
            {
                lblValoreSogliaMinimoValue.Text = "" + Math.Round((Math.Log(Math.Abs(x - sum1 / (Math.Pow(p, m) - 1) - 1), p) / m + Math.Log(Math.Abs((Math.Pow(p, m) - 1) / (mod)), p) / m), 3);
            }

            List<List<int>> kComb = new List<List<int>>();

            for (int k1 = 0; k1 < p; k1++)
            {
                for (int k2 = 0; k2 < p; k2++)
                {
                    if (m > 2) {
                        for (int k3 = 0; k3 < p; k3++)
                        {
                            if (m > 3)
                            {
                                for (int k4 = 0; k4 < p; k4++)
                                {
                                    kComb.Add(new List<int> { k1, k2, k3, k4 });
                                }
                            }
                            else
                            {
                                kComb.Add(new List<int> { k1, k2, k3 });
                            }
                        }
                    }
                    else
                    {
                        kComb.Add(new List<int> { k1, k2 });
                    }
                }
            }

            double VmMaxl = 0;
            btnColoreEsito.BackColor = Color.Green;
            btnColoreEsito.Text = "";
            int numErr = 1;

            tbAnalisi.Text = "";
            tbAnalisi.Text += "k1,...".PadRight(4) + " | L".PadRight(9) + " | f^l(x)".PadRight(4) + " | L2".PadRight(8) + " | int(L2)".PadRight(3) + " | Vm".PadRight(8) + " | \r\n";
            for (i = 0; i < kComb.Count; i++)
            {
                String line = "";
                foreach (int k in kComb[i]) { line += k + ","; }
                line += " | ";
                int sumK = 0, ii = 1;
                foreach (int k in kComb[i]) { sumK += (int)(k * n * Math.Pow(p, ii++ - 1)); }
                double L = (sumK) / (Math.Pow(p, m) - 1) + 1;
                String flStr = "";
                if (L == (double)((int)L))
                {
                    if (L != 1 && L != n + 1)
                    {
                        flStr = ("" + Math.Floor(L) + " o " + (Math.Floor(L) - 1));
                    }
                    else
                    {
                        if (L != 1)
                        {
                            flStr = ("" + (Math.Floor(L) - 1));
                        }
                        else
                        {
                            flStr = ("" + (Math.Floor(L)));
                        }
                    }
                }
                else
                {
                    flStr = ("" + (Math.Floor(L)));
                }

                double L1 = (sumK) / Math.Pow(p, m) + 1;
                String Lstr = "" + Math.Round(L, 3);
                String L1str = "" + Math.Round(L1, 3);
                String L1Intstr = "" + Math.Floor(L1);
                line += Lstr.PadRight(10-Lstr.Length);
                line += " | ";
                line += flStr.PadRight(10 - flStr.Length);
                line += " | ";
                line += L1str.PadRight(10 - L1str.Length);
                line += " | ";
                line += L1Intstr.PadRight(10 - L1Intstr.Length);
                line += " | ";

                double Vm = 0;
                double VmMax = 0;
                for (x = 1; x < n; x++) { 
                    mod = (double)(sumK % (Math.Pow(p, m) - 1));
                    if (x > L)
                    {
                        Vm = Math.Round((Math.Log(Math.Abs(x - sumK / (Math.Pow(p, m) - 1) - 1), p) / m + Math.Log(Math.Abs((Math.Pow(p, m) - 1) / (Math.Pow(p, m) - 1 - mod)), p) / m),3);
                    }
                    else if (L == (double)((int)L))
                    {
                        Vm = Math.Round((Math.Log(Math.Abs(x - sumK / (Math.Pow(p, m) - 1) - 1), p) / m),3);
                    }
                    else
                    {
                        Vm = Math.Round((Math.Log(Math.Abs(x - sumK / (Math.Pow(p, m) - 1) - 1), p) / m + Math.Log(Math.Abs((Math.Pow(p, m) - 1) / (mod)), p) / m),3);
                    }

                    //algoritmo Max
                    if (Vm > VmMax) VmMax = Vm;
                }

                String VmMaxStr = "" + VmMax;
                line += VmMaxStr.PadRight(10-VmMaxStr.Length);
                line += " | \r\n";

                tbAnalisi.Text += line;

                //algoritmo Max l
                if (VmMax > VmMaxl) VmMaxl = VmMax;

                if ((L == (double)((int)L)) && (L > 1 && L < n + 1))
                {
                    btnColoreEsito.BackColor = Color.Red;
                    btnColoreEsito.Text = ""+numErr++;
                }
            }

            lblEsito.Text = "" + VmMaxl;
        }

        private void tbKi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnCalcola_Click(sender, e);
        }
    }
}
