using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaDeliveryManager.Bll;
using PizzaDeliveryManager.Model;

namespace Pizza_Delivery_Manager
{
    public partial class FrmOrderList : Form
    {
        public FrmOrderList()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            InitDgv();
        }

        private void InitDgv()
        {
            List<Order> list = OrderService.GetOrders();
            dgvOrderList.DataSource = list;
            if (list != null && list.Count > 0)
            {
                dgvOrderList.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count <= 0)
            {
                return;
            }

            int orderId = Convert.ToInt32(dgvOrderList.SelectedRows[0].Cells["OrderId"].FormattedValue);
            List<Order> listOrder = OrderService.GetOrders();
            for (int i = listOrder.Count - 1; i >= 0; i--)
            {
                if (listOrder[i].OrderId == orderId)
                {
                    listOrder.RemoveAt(i);
                }
            }
            OrderService.WriteAllOrder(listOrder);

            InitDgv();
        }

        private void dgvOrderList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvOrderList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvOrderList.ClearSelection();
                        dgvOrderList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvOrderList.SelectedRows.Count == 1)
                    {
                        dgvOrderList.CurrentCell = dgvOrderList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}
