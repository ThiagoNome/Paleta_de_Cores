using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //Definir nossos métodos
        //Metodo atualizar cores()
        private void AtualizarCores()
        {
            lb_paleta.BackColor = Color.FromArgb(
                hScrollBarRed.Value,
                hScrollBarGreen.Value,
                hScrollBarBlue.Value);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AtualizarCores();
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            lb_NumRedCores.Text = hScrollBarRed.Value.ToString();
            AtualizarCores();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lb_NumBlueCores.Text = hScrollBarBlue.Value.ToString();
            AtualizarCores();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lb_NumGreeCore.Text = hScrollBarGreen.Value.ToString();
            AtualizarCores();
        }
    }
}
