using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherUI : Form
    {
        public WeatherUI()
        {
            InitializeComponent();
        }

        private void WeatherUI_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                dateLabel.Text=DateTime.Now.ToString("d/M/yyyy");
                Day day1 = new Day();
                Day day2 = new Day();
                Day day3 = new Day();
                Temp temp1 = new Temp();
                Temp temp2 = new Temp();
                Temp temp3 = new Temp();
                string contents = client.DownloadString(
                        "http://api.openweathermap.org/data/2.5/forecast/daily?q=dhaka%2Cbangladesh&mode=json&units=metric&cnt=3");


                string[] amount = contents.Split(',');
            
                temp1.morn = amount[15];
                 day1.morn= temp1.morn.Split(':');
                int k = day1.morn[1].Length;
                 mornLabel.Text = day1.morn[1].Substring(0,k-1);

                temp1.eve = amount[14];
                day1.eve = temp1.eve.Split(':');
                eveLabel.Text = day1.eve[1];

                temp1.night = amount[13];
                day1.night = temp1.night.Split(':');
                nightLabel.Text = day1.night[1];


                temp2.morn = amount[31];
                day2.morn = temp2.morn.Split(':');
                int i = day2.morn[1].Length;
                day2MornLabel.Text = day2.morn[1].Substring(0,i-1);

                temp2.eve = amount[30];
                day2.eve = temp2.eve.Split(':');
                day2EveLabel.Text = day2.eve[1];

                temp2.night = amount[29];
                day2.night = temp2.night.Split(':');
                day2NightLabel.Text = day2.night[1];

                temp3.morn = amount[45];
                day3.morn = temp3.morn.Split(':');
                day3MormLabel.Text = day3.morn[1];

                temp3.eve = amount[46];
                day3.eve = temp3.eve.Split(':');
                day3EveLabel.Text = day3.eve[1];

                temp3.night = amount[47];
                day3.night = temp3.night.Split(':');
                int j = day3.night[1].Length;
                day3NightLabel.Text = day3.night[1].Substring(0,j-1);

            }
        }
    }
}
