using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhong
{
    public partial class MoPhong_Nhom5 : Form
    {
      
        public MoPhong_Nhom5()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            FiFo fiFo = new FiFo();
            fiFo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LRU_Stack lru = new LRU_Stack();
            lru.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DemoToiUu demoToiUu = new DemoToiUu();
            demoToiUu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            clock.ShowDialog();
        }
    }
}
