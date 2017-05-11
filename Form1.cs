using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace canlender_debug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label ngay;
        Int32 y = 0;
        Int32 x;
        Int32 nday;
        string ngaytrongtuan, CurrentCulture;
        int CheckDay()
        {
            DateTime time = Convert.ToDateTime(comboBoxMonth.Text + "/01/" + textBoxYear.Text);
            ngaytrongtuan = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString();
            if (ngaytrongtuan == "Sunday")
            {
                x = 0;
            }
            else if (ngaytrongtuan == "Monday")
            {
                x = 0 + 42;
                nday = 1;
            }
            else if (ngaytrongtuan == "Tuesday")
            {
                x = 0 + 84;
                nday = 2;
            }
            else if (ngaytrongtuan == "Wednesday")
            {
                x = 0 + 84 + 42;
                nday = 3;
            }
            else if (ngaytrongtuan == "Thursday")
            {
                x = 0 + 84 + 84;
                nday = 4;
            }
            else if (ngaytrongtuan == "Friday")
            {
                x = 0 + 84 + 84 + 42;
                nday = 5;
            }
            else if (ngaytrongtuan == "Saturday")
            {
                x = 0 + 84 + 84 + 84;
                nday = 6;
            }
            return x;
        }
    }
}
