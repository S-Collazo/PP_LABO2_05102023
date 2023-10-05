using System.ComponentModel;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Text = string.Empty;
            this.txtSegundoOperador.Text = string.Empty;
            this.lblResultado.Text = "Resultado:";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedItem != null && txtPrimerOperador.Text != "" && txtSegundoOperador.Text != "")
            {
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            string closingTxt = "¿Desea cerrar la calculadora?";
            string closingCaption = "Cierre";
            DialogResult closing = MessageBox.Show(closingTxt, closingCaption, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (closing == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtprimerOperador_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtPrimerOperador.Text)
            {
                if (!(c < '0' || c > '9'))
                {
                }
                else
                {

                }
            }
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtSegundoOperador.Text)
            {
                if (!(c < '0' || c > '9'))
                {

                }
                else
                {
                }
            }
        }
    }
}