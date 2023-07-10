using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeConverter
{
    public partial class TimeUI : Form
    {
        public TimeUI()
        {
            InitializeComponent();
        }

        private void TimeUI_Load(object sender, EventArgs e)
        {
            LoadZones();
        }



        private void LoadZones()
        {
            timeList.Items.Clear();

            DateTime selectedDate = datePicker.Value.Date;
            TimeSpan selectedTime = timePicker.Value.TimeOfDay;

            ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();

            // Create a dictionary to store merged time zones
            Dictionary<TimeSpan, TimeZoneInfo> mergedTimeZones = new Dictionary<TimeSpan, TimeZoneInfo>();

            // Iterate over the time zones and merge based on UTC offset
            foreach (TimeZoneInfo timeZone in timeZones)
            {
                TimeSpan offset = timeZone.BaseUtcOffset;

                if (!mergedTimeZones.ContainsKey(offset))
                {
                    mergedTimeZones.Add(offset, timeZone);
                }
            }

            foreach (TimeZoneInfo timeZone in mergedTimeZones.Values)
            {
                // Combine the selected date and time into a single DateTime object
                DateTime selectedDateTime = selectedDate + selectedTime;

                DateTime convertedDateTime = TimeZoneInfo.ConvertTime(selectedDateTime, timeZone);

                // Get the local time based on the time zone
                DateTime localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(convertedDateTime, TimeZoneInfo.Local.Id);

                string formattedLocalTime = $"{localTime:yyyy-MM-dd HH:mm:ss}";

                ListViewItem item = new ListViewItem(timeZone.DisplayName);
                item.SubItems.Add(formattedLocalTime); // Use the formatted local time without offset
                timeList.Items.Add(item);
            }

            mergedTimeZones.Clear();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

            Console.WriteLine("datePicker_ValueChanged");
            LoadZones();
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("timePicker_ValueChanged");
            LoadZones();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            TimeUI_Load(sender, e);
        }
    }
}
