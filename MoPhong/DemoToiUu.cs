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
    public partial class DemoToiUu : Form
    {
        int SIZE = 3;

        List<int> lstPage;  // chuỗi trang
        int indexPage;      // trang hiện tại
        int indexSelected;

        List<int> counters; //
        List<int> arr;      //

        Font fontConfig;
        int sizeConfig;
        bool isPause = false;
        int numPause = 1;

        bool isAccess = false;

        Timer tm1;
        Timer tm2;
        Timer tm3;
        Timer tm4;
        Timer tm5;

        public DemoToiUu()
        {
            InitializeComponent();
            fontConfig = new Font("Arial", 18);
            sizeConfig = 50;
            StartUp();
            ClearData();
        }
        //reset lại vòng mới
        private void Tm1_Tick(object sender, EventArgs e)
        {
            numPause = 1;
            //xóa hết counter và arr
            for (int i = 0; i < arr.Count; i++)
            {
                (flpCounter.Controls[i] as Label).BackColor = Color.Wheat;
            }

            //xóa màu ô vừa đi qua
            if (indexPage >= 0)
                (flpPageString.Controls[indexPage] as Button).BackColor = Color.Orange;

            indexPage++;

            if (indexPage == lstPage.Count)
            {
                tm1.Stop();
                MessageBox.Show("Hoàn tất mô phỏng");
                return;
            }

            //bật màu ô hiện tại
            (flpPageString.Controls[indexPage] as Button).BackColor = Color.Blue;
            tm1.Stop();
            tm2.Start();
        }


        private void Tm2_Tick(object sender, EventArgs e)
        {
            numPause = 2;

            // xác định có trang truy xuất không
            // in ra page thêm/thay thế
            if (arr.Contains(lstPage[indexPage]))
            {
                isAccess = true;
                lblCurentPage.Location = new Point(0, arr.IndexOf(lstPage[indexPage]) * sizeConfig);
                lblCurentPage.BackColor = Color.Green;

            }
            else
            {
                isAccess = false;

                int indexReplace = arr.Count == SIZE ? indexReplace = counters.IndexOf(counters.Max()) : indexReplace = arr.Count;

                lblCurentPage.Location = new Point(0, indexReplace * sizeConfig);
                lblCurentPage.BackColor = Color.Red;

            }

            lblCurentPage.Text = "" + lstPage[indexPage];


            tm2.Stop();
            tm3.Start();

        }


        private void Tm3_Tick(object sender, EventArgs e)
        {
            numPause = 3;


            //xóa màu của thằng bị thay thế
            if (!isAccess && counters.Count == SIZE && counters[counters.IndexOf(counters.Max())] != lstPage.Count)
                (flpPageString.Controls[counters.Max()] as Button).BackColor = Color.Orange;
            // tô đỏ ô tiếp theo của page hiện tại
            if (FindNext() != lstPage.Count)
                (flpPageString.Controls[FindNext()] as Button).BackColor = Color.IndianRed;


            tm3.Stop();
            tm4.Start();

        }



        private void Tm4_Tick(object sender, EventArgs e)
        {
            numPause = 4;

            lblCurentPage.BackColor = Color.Transparent;
            lblCurentPage.Text = "";
            if (isAccess)//truy xuất được
            {
                counters[arr.IndexOf(lstPage[indexPage])] = FindNext();

                (flpCounter.Controls[arr.IndexOf(lstPage[indexPage])] as Label).Text = (FindNext() + 1) + "";
                (flpCounter.Controls[arr.IndexOf(lstPage[indexPage])] as Label).BackColor = Color.Green;
                (flpOld.Controls[arr.IndexOf(lstPage[indexPage])] as Label).BackColor = Color.Green;
            }
            else
            {
                if (arr.Count < SIZE)
                {
                    //thêm vào

                    flpCounter.Controls.Add(new Label()
                    {
                        Text = (FindNext() + 1) + "",
                        Size = new Size(sizeConfig, sizeConfig),
                        Margin = new Padding(0),
                        Font = fontConfig,
                        BackColor = Color.LightGreen,
                        TextAlign = ContentAlignment.MiddleCenter
                    });


                    flpOld.Controls.Add(new Label()
                    {
                        Text = lstPage[indexPage] + "",
                        Size = new Size(sizeConfig, sizeConfig),
                        Margin = new Padding(0),
                        Font = fontConfig,
                        BackColor = Color.LightGreen,
                        TextAlign = ContentAlignment.MiddleCenter
                    });

                    arr.Add(lstPage[indexPage]);
                    counters.Add(FindNext());
                }
                else
                {
                    //thay thế
                    //lấy index thằng max
                    int indexReplace = counters.IndexOf(counters.Max());



                    //tìm thằng tiếp theo cho thay thế
                    counters[indexReplace] = FindNext();
                    //thay thế
                    arr[indexReplace] = lstPage[indexPage];
                    //show
                    (flpCounter.Controls[indexReplace] as Label).Text = (FindNext() + 1) + "";
                    (flpCounter.Controls[indexReplace] as Label).BackColor = Color.Red;
                    (flpOld.Controls[indexReplace] as Label).Text = lstPage[indexPage] + "";
                    (flpOld.Controls[indexReplace] as Label).BackColor = Color.Red;
                }
            }


            tm4.Stop();
            tm5.Start();

        }
        private void Tm5_Tick(object sender, EventArgs e)
        {
            numPause = 5;

            //cập nhật trên bảng chính
            Label lblPage = new Label();
            for (int i = 0; i < arr.Count; i++)
            {
                lblPage = new Label()
                {
                    Text = arr[i] + "",
                    BackColor = Color.Wheat,
                    Size = new Size(sizeConfig, sizeConfig),
                    Font = fontConfig,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                if (arr[i] == lstPage[indexPage])
                {
                    lblPage.BackColor = isAccess ? Color.Green : Color.IndianRed;
                }
                flpMain.Controls.Add(lblPage);
            }
            flpMain.SetFlowBreak(lblPage, true);

            tm5.Stop();
            tm1.Start();
        }

        private int FindNext()
        {
            for (int i = indexPage + 1; i < lstPage.Count; i++)
                if (lstPage[i] == lstPage[indexPage])
                    return i;
            return lstPage.Count;
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
                    Size = new Size(sizeConfig, sizeConfig),
                    Margin = new Padding(0),
                    FlatStyle = FlatStyle.Popup,
                    Font = fontConfig

                };
                Label lblNew = new Label()
                {
                    Text = "(" + lstPage.Count + ")",
                    Size = new Size(sizeConfig, sizeConfig),
                    Margin = new Padding(0),
                    Font = new Font("Arial", 16),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                btnNew.Click += BtnNew_Click;
                flpPageString.Controls.Add(btnNew);
                flpIndex.Controls.Add(lblNew);
                txtInput.Text = "";
                txtInput.Select();
                if (lstPage.Count > 18)
                    UpdateListPageSize();
            }
            catch
            {
                MessageBox.Show("Mời nhập số nguyên!");
            }
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
            tm1 = new Timer();
            tm2 = new Timer();
            tm3 = new Timer();
            tm4 = new Timer();
            tm5 = new Timer();

            tkbSpeed_ValueChanged(tkbSpeed, null);
            tm1.Tick += Tm1_Tick;
            tm2.Tick += Tm2_Tick;
            tm3.Tick += Tm3_Tick;
            tm4.Tick += Tm4_Tick;
            tm5.Tick += Tm5_Tick;

            indexPage = -1;  // trang hiện tại
            flpPageString.Controls.Clear();
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
            flpIndex.Controls.RemoveAt(flpIndex.Controls.Count - 1);
            indexSelected = new int();
            btnDelete.Visible = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            StartUp();

            try
            {
                SIZE = Convert.ToInt16(txtNumPage.Text);
                if (SIZE < 2 || SIZE > (lstPage.Count / 2))
                    MessageBox.Show("Bạn nhập không hợp lệ vui lòng nhập lại", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            catch
            {
                MessageBox.Show("Khung trang phải là số");
                return;
            }
            pnlCal.Location = new Point(pnlCal.Location.X, pnlCal.Location.Y + 50 * (SIZE - 3));

            pnlHeader.Enabled = false;
            flpPageString.Enabled = false;
            btnRun.Enabled = false;

            tm1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                btnPause.Text = "Tạm ngưng";
                switch (numPause)
                {
                    case 1: tm2.Start(); break;
                    case 2: tm3.Start(); break;
                    case 3: tm4.Start(); break;
                    case 4: tm5.Start(); break;
                    case 5: tm1.Start(); break;
                }
            }
            else
            {
                btnPause.Text = "Tiếp tục";
                switch (numPause)
                {
                    case 1: tm2.Stop(); break;
                    case 2: tm3.Stop(); break;
                    case 3: tm4.Stop(); break;
                    case 4: tm5.Stop(); break;
                    case 5: tm1.Stop(); break;
                }
            }
            isPause = !isPause;
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }

        private void tkbSpeed_ValueChanged(object sender, EventArgs e)
        {
            tm1.Interval = tm2.Interval = tm3.Interval = tm4.Interval = 1000 * 25 / (tkbSpeed.Value);
            tm5.Interval = 2000 * 25 / tkbSpeed.Value;
        }
        private void UpdateSize()
        {
            if (lstPage.Count > 18)
            {
                sizeConfig = 900 / lstPage.Count;
            }
            else
                sizeConfig = 50;
        }
        private void UpdateFont()
        {
            if (lstPage.Count > 18)
            {
                int fontSize = 18 - (lstPage.Count - 18) / 2;
                fontConfig = new Font("Arial", fontSize);
            }
            else
                fontConfig = new Font("Arial", 18);
        }
        private void UpdateListPageSize()
        {
            lblCurentPage.Size = new Size(sizeConfig, sizeConfig);
            lblCurentPage.Font = fontConfig;
            UpdateFont();
            UpdateSize();
            foreach (Control ctr in flpPageString.Controls)
            {

                ctr.Size = new Size(sizeConfig, sizeConfig);
                ctr.Font = fontConfig;
            }
            foreach (Control ctr in flpIndex.Controls)
            {
                ctr.Size = new Size(sizeConfig, sizeConfig);
                ctr.Font = new Font("Arial", sizeConfig / 3 - 1); ;
            }

        }
    }
}
