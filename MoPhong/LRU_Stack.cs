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
    public partial class LRU_Stack : Form
    {
        int SIZE = 3;

        List<int> lstPage;  // chuỗi trang
        int indexPage;      // trang hiện tại
        int indexSelected;

        Font fontConfig;
        int sizeConfig;

        List<int> counters; //
        List<int> arr;      //


        int pageReplace;    // con trỏ (nhỏ hơn khung trang

        bool isPause = false;
        int numPause;

        bool isAccess = false;


        Timer tm1;
        Timer tm2;
        Timer tm3;
        Timer tm4;
        Timer tm5;
        Timer tm6;

        public LRU_Stack()
        {
            InitializeComponent();
            StartUp();
            ClearData();
            fontConfig = new Font("Arial", 18);
            sizeConfig = 50;

            tm1 = new Timer();
            tm2 = new Timer();
            tm3 = new Timer();
            tm4 = new Timer();
            tm5 = new Timer();
            tm6 = new Timer();
            tm1.Interval = tm2.Interval = tm3.Interval = tm4.Interval = tm5.Interval = 1000;
            tm1.Tick += Tm1_Tick;
            tm2.Tick += Tm2_Tick;
            tm3.Tick += Tm3_Tick;
            tm4.Tick += Tm4_Tick;
            tm5.Tick += Tm5_Tick;
            tm6.Tick += Tm6_Tick;
        }
        private void Tm1_Tick(object sender, EventArgs e)
        {
            numPause = 1;

            // xét có truy xuất trang không
            if (arr.Contains(lstPage[indexPage]))
                isAccess = true;
            else
                isAccess = false;

            // hiển thị trang đang xét
            (flpPageString.Controls[indexPage] as Button).BackColor = Color.Green;

            // tắt trang
            if (indexPage > 0)
                (flpPageString.Controls[indexPage - 1] as Button).BackColor = Color.Orange;



            //in lại arr nguyên vẹn
            for (int i = 0; i < arr.Count; i++)
            {
                flpOld.Controls[i].BackColor = Color.Wheat;
                flpCounter.Controls[i].BackColor = Color.Wheat;
            }



            //xóa hiển thị trang hiện tại (trang bên trái flpOld)
            lblCurentPage.BackColor = Color.Transparent;
            lblCurentPage.Text = "";


            tm1.Stop();
            tm2.Start();
        }

        //thêm trang mới lên đầu counter
        private void Tm2_Tick(object sender, EventArgs e)
        {
            numPause = 2;
            //đặt trang mới trên đầu stack
            lblCurrentPage.Text = "" + lstPage[indexPage];
            lblCurrentPage.BackColor = Color.Green;

            tm2.Stop();
            tm3.Start();
        }

        //hiện màu xanh hoặc đỏ đối với trang bị thay thế
        private void Tm3_Tick(object sender, EventArgs e)
        {
            numPause = 3;
            // tô màu ô bị thay thế hoặc được truy xuất trong counter
            int indexCounter;
            //xóa trang trong counter
            if (isAccess)
            {
                // lấy thằng đó ra
                pageReplace = lstPage[indexPage];
                indexCounter = counters.IndexOf(lstPage[indexPage]);

                //bật xanh counter có
                flpCounter.Controls[counters.Count - 1 - indexCounter].BackColor = Color.Green;
                //lấy nó ra chút bỏ lại
                counters.Remove(lstPage[indexPage]);
            }
            else
            {
                // ô bị thay thế
                if (counters.Count == SIZE)
                {

                    //màu ô sẽ bị xóa
                    flpCounter.Controls[0].BackColor = Color.Red;
                    // lấy giá trị bị xóa
                    pageReplace = counters[counters.Count - 1];

                    //móc cuối ra
                    counters.Remove(pageReplace);
                }
            }
            counters.Insert(0, lstPage[indexPage]);

            tm3.Stop();
            tm4.Start();

        }

        private void Tm4_Tick(object sender, EventArgs e)
        {
            numPause = 4;
            //show ô bị thay thế hoặc ô trùng
            if (isAccess)
            {
                flpOld.Controls[arr.IndexOf(lstPage[indexPage])].BackColor = Color.Green;
            }
            else
            {
                if (arr.Count == SIZE)
                {
                    // lấy index của pageRe
                    int indexReplace = arr.IndexOf(pageReplace);

                    lblCurentPage.Text = "" + lstPage[indexPage];
                    lblCurentPage.Location = new Point(0, sizeConfig * indexReplace);

                    flpOld.Controls[indexReplace].BackColor = Color.Red;

                    //thay thế pageReplace bằng trang hiện tại
                    arr[arr.IndexOf(pageReplace)] = lstPage[indexPage];
                }
                else
                {
                    lblCurentPage.Text = "" + lstPage[indexPage];
                    lblCurentPage.Location = new Point(0, sizeConfig * arr.Count);
                    //thêm vào
                    arr.Add(lstPage[indexPage]);

                }

            }


            tm4.Stop();
            tm5.Start();
        }
        private void Tm5_Tick(object sender, EventArgs e)
        {
            numPause = 5;
            lblCurrentPage.Text = "";
            lblCurrentPage.BackColor = Color.Transparent;
            //xóa ô bên trái arr
            lblCurentPage.Text = "";


            if (isAccess)
            {
                lblCurentPage.Text = "";
                lblCurentPage.BackColor = Color.Transparent;
                lblCurrentPage.Text = "";
                lblCurrentPage.BackColor = Color.Transparent;
                for (int i = 0; i < arr.Count; i++)
                {
                    flpOld.Controls[i].Text = arr[i] + "";
                    //xanh
                }
                for (int i = counters.Count - 1; i >= 0; i--)
                {

                    flpCounter.Controls[counters.Count - 1 - i].Text = counters[i] + "";
                }
            }
            else
            {
                if (flpOld.Controls.Count == SIZE)
                {
                    for (int i = 0; i < arr.Count; i++)
                    {

                        flpOld.Controls[i].Text = arr[i] + "";
                    }
                    for (int i = counters.Count - 1; i >= 0; i--)
                    {

                        flpCounter.Controls[counters.Count - 1 - i].Text = counters[i] + "";
                    }
                }
                else
                {
                    //add
                    flpOld.Controls.Add(new Label()
                    {
                        Text = "" + lstPage[indexPage],
                        Size = new Size(sizeConfig, sizeConfig),
                        Margin = new Padding(0),
                        Font = fontConfig,
                        BackColor = Color.AliceBlue,
                        TextAlign = ContentAlignment.MiddleCenter
                    });
                    //test
                    flpCounter.Controls.Add(new Label()
                    {
                        Text = "" + lstPage[indexPage],
                        Size = new Size(sizeConfig, sizeConfig),
                        Margin = new Padding(0),
                        Font = fontConfig,
                        BackColor = Color.AliceBlue,
                        TextAlign = ContentAlignment.MiddleCenter
                    });
                }

            }
            for (int i = 0; i < counters.Count; i++)
            {
                (flpCounter.Controls[i] as Label).BackColor = Color.Wheat;
            }

            tm5.Stop();
            tm6.Start();
        }

        private void Tm6_Tick(object sender, EventArgs e)
        {
            numPause = 6;
            //thêm vào flpMain
            Label lblCounter = new Label();
            arr.ForEach(x =>
            {
                lblCounter = new Label()
                {
                    Text = x + "",
                    Size = new Size(sizeConfig, sizeConfig),
                    BackColor = Color.Wheat,
                    Font = fontConfig,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                if (x == lstPage[indexPage])
                {
                    lblCounter.BackColor = isAccess ? Color.Green : Color.IndianRed;
                }
                flpMain.Controls.Add(lblCounter);

            });
            flpMain.SetFlowBreak(lblCounter, true);

            indexPage++;


            if (indexPage == lstPage.Count)
            {
                tm6.Stop();

                MessageBox.Show("Hoàn tất thuật toán");
                return;
            }

            tm6.Stop();
            tm1.Start();
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

            indexPage = 0;  // trang hiện tại
            flpPageString.Controls.Clear();
            lstPage = new List<int>() { };
        }

        private void tkbSpeed_ValueChanged(object sender, EventArgs e)
        {
            tm1.Interval = tm2.Interval = tm3.Interval = tm4.Interval = 1000 * 25 / (tkbSpeed.Value);
            tm5.Interval = 2000 * 25 / tkbSpeed.Value;
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

            try
            {
                SIZE = Convert.ToInt16(txtNumPage.Text);
                if (SIZE < 2 || SIZE > (lstPage.Count / 2))
                {
                    MessageBox.Show("Bạn nhập không hợp lệ vui lòng nhập lại", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Khung trang phải là số");
                return;
            }
            pnlCal.Location = new Point(pnlCal.Location.X, flpMain.Location.Y + sizeConfig * (SIZE + 1));

            flpOld.Location = new Point(flpOld.Location.X, flpCounter.Location.Y);
            pnlCurrentPage.Location = new Point(pnlCurrentPage.Location.X, flpCounter.Location.Y);
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
                    case 5: tm5.Start(); break;
                    case 6: tm1.Start(); break;
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
                    case 5: tm6.Stop(); break;
                    case 6: tm1.Stop(); break;
                }
            }
            isPause = !isPause;
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            indexSelected = flpPageString.Controls.IndexOf(sender as Button);
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
            lblCurrentPage.Size = new Size(sizeConfig, sizeConfig);
            lblCurrentPage.Font = fontConfig;
            UpdateFont();
            UpdateSize();
            foreach (Control ctr in flpPageString.Controls)
            {

                ctr.Size = new Size(sizeConfig, sizeConfig);
                ctr.Font = fontConfig;
            }


        }
    }
}
