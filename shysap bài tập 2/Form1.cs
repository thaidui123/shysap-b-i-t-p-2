using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shysap_bài_tập_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tinhdientich(double bk) { return bk*bk*Math.PI; }
        double tinhchuvi(double bk) { return bk*2*Math.PI; }
        private void btndientich_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = bankinh * bankinh * Math.PI;
            lblketqua.Text = " diện tích " + Convert.ToString(dientich);
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double chuvi = bankinh * 2 * Math.PI;
            lblketqua.Text = "chu vi " + Convert.ToString(chuvi);
        }

        private void btntinh1_Click(object sender, EventArgs e)
        {
            if (rdbchuvi.Checked)
            {
                Double r, kq;
                r = Convert.ToDouble(txtbankinh.Text);
                kq = r * 2 * Math.PI;
                txtketqua.Text = kq.ToString(txtketqua.Text);




            }
            if (rdbdientich.Checked)
            {
                    Double r, kq;
                    r = Convert.ToDouble(txtbankinh.Text);
                    kq=r * 2 * Math.PI;
                  txtketqua.Text = kq.ToString(txtketqua.Text);



            }
        }

        private void btntinh2_Click(object sender, EventArgs e)
        {
            double bankinh=Convert.ToDouble(txtbankinh.Text);
            string thongbao = "";
            if (hkbchuvi.Checked) 
            {
                double chuvi = tinhchuvi(bankinh);
                thongbao=thongbao+"chu vi"+Convert.ToString(chuvi)+Environment.NewLine;
            }
            if(hkbdientich.Checked)
            {
                double dientich=tinhdientich(bankinh);
                thongbao=thongbao+"diện tích"+Convert.ToString(dientich)+Environment.NewLine;   

            }    
            if(thongbao.Length > 0)  
            { 
                MessageBox.Show(thongbao,"thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  
            {
                MessageBox.Show("vui lòn nhập chức năng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }       
}
