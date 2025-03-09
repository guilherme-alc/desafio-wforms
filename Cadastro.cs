﻿namespace CadastroImobiliaria
{
    public partial class Cadastro : Form
    {
        private readonly Main _formPrincipal;
        public Cadastro(Main formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void menuPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _formPrincipal.Show();
            this.Close();
        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            errorProvider1.SetError(txt, Validacoes.validaCampoTexto(txt)); 
        }

        private void maskedTextBox_Validated(object sender, EventArgs e)
        {
            var txt = (MaskedTextBox)sender;
            errorProvider1.SetError(txt, Validacoes.validaCampoTextoMascara(txt));
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacoes.numeroInteiro(e);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _formPrincipal.Close();
        }
    }
}
