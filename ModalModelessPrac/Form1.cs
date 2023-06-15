using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModelessPrac
{
    public partial class Form1 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                this.Text = "제목 글자";
            }
        }


        public Form1()
        {
            InitializeComponent();
            //IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("사용자가 취소하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            //form.MdiParent = this;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}