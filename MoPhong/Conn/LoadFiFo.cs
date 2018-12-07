using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhong.Conn
{
    class LoadFiFo
    {
        List<int> lstPage;  // chuỗi trang
        int indexPage;      // trang hiện tại
        int indexSelected;

        Font fontConfig;
        int sizeConfig;

        List<int> counters; //
        List<int> arr;      //


        int indexReplace;

        bool isPause = false;
        int numPause;

        bool isAccess = false;
    }
}
