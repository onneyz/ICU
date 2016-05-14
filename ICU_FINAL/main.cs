using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ICU_FINAL
{
    public partial class main : MaterialForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnFormats_Click(object sender, EventArgs e)
        {
            fileformats form = new fileformats();
            form.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result form = new result();
            this.Hide();
            form.Show();
        }
    }
}
