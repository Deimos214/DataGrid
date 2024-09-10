using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dvgAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            txtNome.Clear();
            txtCurso.Clear();
            MessageBox.Show("Aluno incluído com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lblTotal = dvgAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
                if (dvgAlunos.RowCount > 0)
                (
                    dvgAlunos.Rows.RemoveAt(dvgAlunos.CurrentRow.Index);

                    MessageBox.Show("Aluno Excluido com sucesso", "Exclusão",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblTotal.Text = dvgAlunos.RowCount.ToString();
        }

        private void dvgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dvgAlunos.RowCount > 0)
                {
                txtAlteracao.Text = dvgAlunos.CurrentRow.Cells["nome"].Value.ToString();
                }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "")
            {
                dvgAlunos.CurrentRow.Cells[""].Value = txtAlteracao.Text;
                MessageBox.Show("Aluno Alterado com sucesso", "Exclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtAlteracao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
