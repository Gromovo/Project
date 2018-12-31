using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Core.View
{
    public partial class Purch_Card : Form
    {
        Purch p1;
        public Purch_Card(Purch p_1)
        {
            p1 = p_1;
            InitializeComponent();
        }
    }
}
