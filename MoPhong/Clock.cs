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
    public partial class Clock : Form
    {
        List<int> counters;
        List<int> arrOld;


        List<int> lstPage;  // chuỗi trang
        List<int> arr;      //
        List<int> lstStatus;

        int SIZE = 4;

        int indexSelected;

        int indexPage;  // trang hiện tại
        int pointer;    // con trỏ (nhỏ hơn khung trang

        bool isPause = false;

        Timer tmColum;
        Timer tmFindStatus;
        public Clock()
        {
            InitializeComponent();
            StartUp();
            ClearData();

            tmColum = new Timer();
            tmColum.Tick += TmColum_Tick; ;
            tmColum.Interval = 2000;

            tmFindStatus = new Timer();
            tmFindStatus.Interval = 2000;
            tmFindStatus.Tick += TmFindStatus_Tick;
        }
        private void TmColum_Tick(object sender, EventArgs e)
        {
            bool isAccess = false;
            int pageNow;
            arrOld = new List<int>();
            arr.ForEach(x =>
            {
                arrOld.Add(x);
            });
            if (arr.Contains(lstPage[indexPage]))
            {

                lstStatus[arr.IndexOf(lstPage[indexPage])] = 1;
                isAccess = true;
                pageNow = lstPage[indexPage];
                IncreasePointer();
            }
            else
            {
                if (lstStatus[pointer] == 1)
                {
                    tmColum.Stop();
                    tmFindStatus.Start();
                    return;
                }

                //for (int i = 0; i < 3; i++)
                //{

                //}

                if (arr.Count < SIZE)
                {
                    arr.Insert(pointer, lstPage[indexPage]);
                }
                else
                {
                    arr[pointer] = lstPage[indexPage];
                }
                pageNow = arr[pointer];
                IncreasePointer();
            }
            Label lblPage = new Label();
            foreach (int i in arr)
            {
                lblPage = new Label()
                {
                    Text = i + "",
                    Size = new Size(50, 50),
                    BackColor = Color.Red,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20)
                };
                if (i == pageNow)
                {
                    lblPage.BackColor = isAccess ? Color.Aqua : Color.Purple;
                    lblCurrentPage.Text = pageNow + "";

                }
                flpMain.Controls.Add(lblPage);

            }
            flpMain.SetFlowBreak(lblPage, true);


            indexPage++;
            if (indexPage == lstPage.Count)
            {
                tmColum.Stop();
            }
            flpStatus.Controls.Clear();
            flpOld.Controls.Clear();
            for (int i = 0; i < arr.Count; i++)
            {
                Label lblStatus = new Label()
                {
                    Text = lstStatus[i] + "",
                    Size = new Size(50, 50),
                    BackColor = Color.Orange,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20)
                };

                Label lblOld = new Label()
                {
                    Text = arrOld.Count > i ? arrOld[i] + "" : "",
                    Size = new Size(50, 50),
                    BackColor = Color.Orange,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20)
                };
                if (i == arr.IndexOf(pageNow))
                {
                    lblOld.BackColor = Color.Green;
                    lblStatus.BackColor = Color.Blue;
                    lblCurrentPage.Location = new Point(0, 50 * i);
                }
                flpOld.Controls.Add(lblOld);
                flpStatus.Controls.Add(lblStatus);
            }

        }

        private void TmFindStatus_Tick(object sender, EventArgs e)
        {


            //show status
            flpStatus.Controls.Clear();
            for (int i = 0; i < SIZE; i++)
            {
                Label lblStatus = new Label()
                {
                    Text = lstStatus[i] + "",
                    Size = new Size(50, 50),
                    BackColor = i == pointer ? Color.Blue : Color.Orange,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20)
                };

                flpStatus.Controls.Add(lblStatus);
            }
            //end show status
            lstStatus[pointer] = 0;
            IncreasePointer();


            if (lstStatus[pointer] == 0)
            {
                tmFindStatus.Stop();
                tmColum.Start();
            }




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtInput.Text);
                lstPage.Add(a);
                Button btnNew = new Button()
                {
                    Text = a + "",
                    BackColor = Color.Red,
                    Size = new Size(50, 50),
                    Margin = new Padding(0),
                    FlatStyle = FlatStyle.Popup,
                    Font = new Font("Arial", 20)

                };
                btnNew.Click += BtnNew_Click;
                flpPageString.Controls.Add(btnNew);
                txtInput.Text = "";
                txtInput.Select();
            }
            catch
            {
                MessageBox.Show("Mời nhập số nguyên!");
            }
        }
        void IncreasePointer()
        {
            pointer = (pointer < SIZE - 1) ? pointer + 1 : 0;
        }
        int DecreasePointer()
        {
            return (pointer > 1) ? pointer - 1 : SIZE - 1;
        }
        void StartUp()
        {
            counters = new List<int>();
            arr = new List<int>();
            flpCounter.Controls.Clear();
            flpMain.Controls.Clear();
        }
        void ClearData()
        {
            indexPage = 0;  // trang hiện tại
            pointer = 0;
            flpPageString.Controls.Clear();
            lstStatus = new List<int>();
            for (int i = 0; i < SIZE; i++)
            {
                lstStatus.Add(0);
            }

            lstPage = new List<int>() { };
        }


        private void BtnNew_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            indexSelected = flpPageString.Controls.IndexOf(sender as Button);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstPage.RemoveAt(indexSelected);
            flpPageString.Controls.RemoveAt(indexSelected);
            indexSelected = new int();
            btnDelete.Visible = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            StartUp();
            tmColum.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                tmColum.Start();
            }
            else
            {
                tmColum.Stop();
            }
            isPause = !isPause;
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
