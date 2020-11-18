using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_OrdenamientoBurbuja {
    public partial class Form1 : Form {
        private static int intTamanioArregloObjetos = 50;
        private FabricaArticulosNavidenios[] miArregloFabricas = new FabricaArticulosNavidenios[intTamanioArregloObjetos];
        private ArrayList miArregloNumeros = new ArrayList();
        private Random intRand = new Random();
        private bool blnConSenial = false;

        public Form1() {
            InitializeComponent(); 
            dataGridView1.Columns.Add("N", "N");
            dataGridView2.Columns.Add("Nombre", "Nombre");
            dataGridView2.Columns.Add("Tamaño del territorio", "Tamaño del territorio");
            dataGridView2.Columns.Add("Clasificacion", "Clasificacion");
            dataGridView2.Columns.Add("Fecha inauguracion", "Fecha inauguracion");
            dataGridView2.Columns.Add("Tiene credito", "Tiene credito");
            dataGridView2.Columns.Add("Cantidad empleados", "Cantidad empleados");
            dataGridView2.Columns.Add("Cantidad proveedores", "Cantidad proveedores");
            dataGridView2.Columns.Add("Tipo", "Tipo");
        }

        private void btnIzquierda_Click(object sender, EventArgs e) {
            int intContador = 0, intIteraciones = 0; Stopwatch stp = Stopwatch.StartNew();
            blnConSenial = false;

            if (tabControl1.SelectedIndex == 0) {
                Izquierda(ref intIteraciones, ref intContador);
            } else {
                Izquierda(ref intIteraciones, ref intContador, true);
            }

            stp.Stop();

            MessageBox.Show("Se ordenaron los elementos por izquierda." + "\nMovimientos realizados: " + intContador + "\nNumero de iteraciones: "
                + intIteraciones + "\nTiempo de ejecucion: " + stp.ElapsedMilliseconds + " ms");
        }

        private void btnDerecha_Click(object sender, EventArgs e) {
            int intContador = 0, intIteraciones = 0; Stopwatch stp = Stopwatch.StartNew();
            blnConSenial = false;

            if (tabControl1.SelectedIndex == 0) {
                Derecha(ref intIteraciones, ref intContador);
            } else {
                Derecha(ref intIteraciones, ref intContador, true);
            }

            stp.Stop();

            MessageBox.Show("Se ordenaron los elementos por derecha." + "\nMovimientos realizados: " + intContador + "\nNumero de iteraciones: "
                + intIteraciones + "\nTiempo de ejecucion: " + stp.ElapsedMilliseconds + " ms");
        }

        private void btnSenialIzquierda_Click(object sender, EventArgs e) {
            int intContador = 0, intIteraciones = 0; Stopwatch stp = Stopwatch.StartNew();
            blnConSenial = true;

            if (tabControl1.SelectedIndex == 0) {
                Izquierda(ref intIteraciones, ref intContador);
            } else {
                Izquierda(ref intIteraciones, ref intContador, true);
            }

            stp.Stop();

            MessageBox.Show("Se ordenaron los elementos por izquierda con señal." + "\nMovimientos realizados: " + intContador + "\nNumero de iteraciones: "
                + intIteraciones + "\nTiempo de ejecucion: " + stp.ElapsedMilliseconds + " ms");
        }

        private void btnSenialDerecha_Click(object sender, EventArgs e) {
            int intContador = 0, intIteraciones = 0; Stopwatch stp = Stopwatch.StartNew();
            blnConSenial = true;

            if (tabControl1.SelectedIndex == 0) {
                Derecha(ref intIteraciones, ref intContador);
            } else {
                Derecha(ref intIteraciones, ref intContador, true);
            }

            stp.Stop();

            MessageBox.Show("Se ordenaron los elementos por derecha con señal." + "\nMovimientos realizados: " + intContador + "\nNumero de iteraciones: "
                + intIteraciones + "\nTiempo de ejecucion: " + stp.ElapsedMilliseconds + " ms");
        }

        private void Derecha(ref int intIteraciones, ref int intContador) {
            int intAux; bool blnBandera = true;
            for (int x = 0; x < miArregloNumeros.Count; x++) {
                if (!blnBandera && blnConSenial) break; 
                blnBandera = false;
                for (int y = miArregloNumeros.Count - 1; y > 0; y--) {
                    intIteraciones++;
                    if ((int)miArregloNumeros[y] < (int)miArregloNumeros[y - 1]) {
                        intAux = (int)miArregloNumeros[y];
                        miArregloNumeros[y] = miArregloNumeros[y - 1];
                        miArregloNumeros[y - 1] = intAux;
                        intContador++; blnBandera = true;

                        if (radPasoAPaso.Checked) {
                            Mostrar(true); MessageBox.Show("Se intercambia el elemento: " + miArregloNumeros[y - 1] + " con: " + miArregloNumeros[y] + ".");
                        }
                    }
                }
            }
            Mostrar(true);
        }

        private void Derecha(ref int intIteraciones, ref int intContador, bool b) {
            FabricaArticulosNavidenios fabAux; bool blnBandera = true;
            for (int x = 0; x < miArregloFabricas.Length; x++) {
                if (!blnBandera && blnConSenial) break;
                blnBandera = false;
                for (int y = miArregloFabricas.Length - 1; y > 0; y--) {
                    intIteraciones++;
                    if (miArregloFabricas[y].CompareTo(miArregloFabricas[y - 1]) == -1) {
                        fabAux = miArregloFabricas[y];
                        miArregloFabricas[y] = miArregloFabricas[y - 1];
                        miArregloFabricas[y - 1] = fabAux;
                        intContador++; blnBandera = true;

                        if (radPasoAPaso.Checked) {
                            Mostrar(false); MessageBox.Show("Se intercambia el elemento: " + miArregloFabricas[y - 1] + " con: " + miArregloFabricas[y] + ".");
                        }
                    }
                }
            }
            Mostrar(false);
        }

        private void Izquierda(ref int intIteraciones, ref int intContador) {
            int intAux; bool blnBandera = true;
            for (int x = 0; x < miArregloNumeros.Count; x++) {
                if (!blnBandera && blnConSenial) break;
                blnBandera = false;
                for (int y = 0; y < miArregloNumeros.Count - 1; y++) {
                    intIteraciones++;
                    if ((int)miArregloNumeros[y] > (int)miArregloNumeros[y + 1]) {
                        intAux = (int)miArregloNumeros[y];
                        miArregloNumeros[y] = miArregloNumeros[y + 1];
                        miArregloNumeros[y + 1] = intAux;
                        intContador++; blnBandera = true;

                        if (radPasoAPaso.Checked) {
                            Mostrar(true); MessageBox.Show("Se intercambia el elemento: " + miArregloNumeros[y + 1] + " con: " + miArregloNumeros[y] + ".");
                        }
                    }
                }
            }
            Mostrar(true);
        }

        private void Izquierda(ref int intIteraciones, ref int intContador, bool b) {
            FabricaArticulosNavidenios fabAux; bool blnBandera = true;
            for (int x = 0; x < miArregloFabricas.Length; x++) {
                if (!blnBandera && blnConSenial) break;
                blnBandera = false;
                for (int y = 0; y < miArregloFabricas.Length - 1; y++) {
                    intIteraciones++;
                    if (miArregloFabricas[y].CompareTo(miArregloFabricas[y + 1]) == 1) {
                        fabAux = miArregloFabricas[y];
                        miArregloFabricas[y] = miArregloFabricas[y + 1];
                        miArregloFabricas[y + 1] = fabAux;
                        intContador++; blnBandera = true;

                        if (radPasoAPaso.Checked) {
                            Mostrar(false); MessageBox.Show("Se intercambia el elemento: " + miArregloFabricas[y + 1] + " con: " + miArregloFabricas[y] + ".");
                        }
                    }
                }
            }
            Mostrar(false);
        }

        private void btnGenerar15Aleatorio_Click(object sender, EventArgs e) {
            miArregloNumeros.Clear();
            for (int x = 15; x > 0; x--)
                miArregloNumeros.Add(intRand.Next(0, 101));

            MessageBox.Show("Se generaron 15 numeros aleatorios.");
            Mostrar(true);
        }

        private void btnGenerar5Aleatorios_Click(object sender, EventArgs e) {
            miArregloNumeros.Clear();
            for (int x = 5; x > 0; x--)
                miArregloNumeros.Add(x);

            MessageBox.Show("Se generaron 5 numeros del 5 al 1.");
            Mostrar(true);
        }

        private void btn15objetosAleatorios_Click(object sender, EventArgs e) {
            FabricaArticulosNavidenios miFabrica;
            char[] chrClasificaciones = { 'C', 'B', 'A', 'S' };
            string[] strDependencias = { "Privada", "Publica", "Mixta" };

            for (int x = 0; x < intTamanioArregloObjetos; x++) {
                miFabrica = new FabricaArticulosNavidenios();

                miFabrica.Nombre = GenerarNombreAleatorio();
                miFabrica.TamanioTerritorio = intRand.Next(10, 1000);
                miFabrica.FechaInauguracion = GenerarFechaAleatoria();
                miFabrica.TieneCredito = intRand.Next(0, 2) == 1 ? true : false;
                miFabrica.CantidadEmpleados = intRand.Next(100, 100000);
                miFabrica.CantidadProveedores = intRand.Next(1, 100);
                miFabrica.Clasificacion = chrClasificaciones[intRand.Next(0, 4)];
                miFabrica.TipoSegunDependencia = strDependencias[intRand.Next(0, 3)];

                miArregloFabricas[x] = miFabrica;
            }

            MessageBox.Show("Se generaron " + intTamanioArregloObjetos + " objetos con datos aleatorios.");
            Mostrar(false);
        }

        private void Mostrar(bool t) {
            dataGridView2.Rows.Clear(); dataGridView1.Rows.Clear();
            if (t) {
                for (int x = 0; x < miArregloNumeros.Count; x++)
                    dataGridView1.Rows.Add(miArregloNumeros[x].ToString());
            } else {
                foreach (FabricaArticulosNavidenios f in miArregloFabricas) {
                    dataGridView2.Rows.Add(f.Nombre, f.TamanioTerritorio, f.Clasificacion, f.FechaInauguracion,
                        f.TieneCredito ? "Si" : "No", f.CantidadEmpleados, f.CantidadProveedores, f.TipoSegunDependencia);
                }
            }
        }

        private string GenerarNombreAleatorio() {
            string strPosibles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", strNombre = "FAB-";

            int intAux = intRand.Next(0, 100);
            strNombre += intAux < 10 ? "0" + intAux.ToString() : intAux.ToString(); strNombre += "-";

            for (int x = 0; x < 4; x++)
                strNombre += strPosibles[intRand.Next(0, 26)];

            return strNombre;
        }

        private DateTime GenerarFechaAleatoria() {
            DateTime dtmInicio = new DateTime(1900, 1, 1);
            int intRango = (DateTime.Today - dtmInicio).Days;
            return dtmInicio.AddDays(intRand.Next(intRango));
        }
    }
}
