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
    }
}
