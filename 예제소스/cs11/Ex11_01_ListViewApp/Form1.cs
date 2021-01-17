using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11_01_ListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                // 각 항목에 대한 부항목을 얻기 위해 SubItems 프로퍼티를 사용
                label1.Text = subItem[0].Text + "의 국가번호는 " +
                              subItem[1].Text + "입니다.";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                // 리스트 뷰의 항목을 큰 아이콘 형태로 보여준다.
                listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                // 리스트 뷰의 항목을 작은 아이콘 형태로 보여준다.
                listView1.View = View.SmallIcon;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                // 리스트 뷰의 항목을 간단한 리스트 형태로 보여준다.
                listView1.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                // 리스트 뷰의 항목을 자세한 리스트 형태로 보여준다.
                listView1.View = View.Details;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                // 리스트 뷰의 항목을 타일 형태로 보여준다.
                listView1.View = View.Tile;
        }
    }
}
