using System;
using Sistema.Negocio;
using System.Windows.Forms;

namespace Sistema.Presentacion2
{
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }


        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NRol.Listar();
                this.Formato();
                LblTotal.Text = "Total Registros:" + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[0].HeaderText = "ID";
            DgvListado.Columns[1].Width = 200;
            DgvListado.Columns[1].HeaderText = "Nombre";

        }
        private void FrmRol_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

    }
}
