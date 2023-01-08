using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICAL_SYSTEM
{
    public partial class Calendar : Form
    {
        int month, year;

        public static int static_month, static_year;
        public Calendar()
        {
            InitializeComponent();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text =MonthName+ " " +year;

            static_month = month;
            static_year = year;

            // Get the first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // convert the startofMonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            // clear container
            daycontainer.Controls.Clear();

            // decrement month to go to previous month
            month--;
            static_month = month;
            static_year = year;

            String MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = MonthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // convert the startofMonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            // clear container
            daycontainer.Controls.Clear();

            // increment month to go to next month
            month++;
            static_month = month;
            static_year = year;

            String MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = MonthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // convert the startofMonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displaDays();

        }

    }
}
