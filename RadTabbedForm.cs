using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TelerikShowcase
{
    public partial class RadTabbedForm : Telerik.WinControls.UI.RadTabbedForm
    {
        public RadTabbedForm()
        {
            InitializeComponent();

            this.AllowAero = false;
        }

        private void radTabbedFormControl1_SelectedTabChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string StartTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyy");
            string EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MMM yyy");

            textFlightDates.Text = StartTripDate + " - " + EndTripDate;

        }
    }
}
