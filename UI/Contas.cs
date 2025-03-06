using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Modal;

namespace UI
{
    public partial class Contas : Form
    {
        public Contas()
        {
            InitializeComponent();
        }

        private void botaoPrimario1_Click(object sender, EventArgs e)
        {
            new ContaModal().ShowDialog();
        }
    }
}
