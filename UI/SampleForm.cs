using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_TYPED_DATASET.UI
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private void CardNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CardNoTextBox.Text) == false)
            {
                GetDataButton.Enabled = true;
            }
            else
            {
                GetDataButton.Enabled = false;
            }
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CardNoTextBox.Text) == false)
            {
                long cardNo = 
                    long.Parse(CardNoTextBox.Text);

               var data =
                    Bussiness.DailyDoingsBLL.GetDataByCardNo(cardNo: cardNo);

                if(data != null)
                {
                    if (data.Count > 0)
                    {
                        DailyDoinsDataGridView.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("کاربر گرامی اطلاعاتی برای شماره کارت وارد شده سابقه ندارد");
                    }
                }

            }
        }
    }
}
