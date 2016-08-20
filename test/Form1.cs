using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Func<int, string> toString;

        public Form1()
        {
            InitializeComponent();
            toString = new Func<int, string>(this.ToString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = toString(5);
            MessageBox.Show(result);
        }

        public string ToString(int i)
        {
            return "string" + i.ToString();
        }
    }
}
