using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStack
{
    public partial class Main : Form
    {
        string fullname;
        WeatherData weather;
        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            fullname = Properties.Settings.Default.fullName;
            await Task.Run(() => load_data());
            set_data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Location frm_loation = new FRM_Location();
            frm_loation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void load_data()
        {
            //fullname = Properties.Settings.Default.fullName;
            
            var url = "http://api.weatherstack.com/current?access_key=926829cf20f024ee9cde0af1aef378b3&query=" + fullname;
            HttpHelper helper = new HttpHelper();
            var data = helper.JSON_Convert(url);
            weather = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherData>(data);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void set_data()
        {
            lb_city.Text = weather.request.query;
            lb_description.Text = string.Join("", weather.current.weather_descriptions);
            pictureBox1.ImageLocation = string.Join("", weather.current.weather_icons);
            nb_temperature.Text = weather.current.temperature.ToString();
            nb_wind.Text = weather.current.wind_speed.ToString();
            nb_humidity.Text = weather.current.humidity.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_description_Click(object sender, EventArgs e)
        {

        }

        private void nb_temperature_Click(object sender, EventArgs e)
        {

        }

        private void lb_humidity_Click(object sender, EventArgs e)
        {

        }

        private void nb_wind_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            fullname = Properties.Settings.Default.fullName;
            await Task.Run(() => load_data());
            set_data();
        }
    }
}
