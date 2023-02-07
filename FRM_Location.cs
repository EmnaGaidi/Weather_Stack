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
    public partial class FRM_Location : Form
    {
        Country country;
        // GET DATA
        string country_name;
        string city_name;
        string full_name;
        List<string> ListOfCountry = new List<string>();
        public FRM_Location()
        {
            InitializeComponent();
        }

        private async void FRM_Location_Load(object sender, EventArgs e)
        {
            await Task.Run(() => load_data());
            await Task.Run(() => set_data());
            comboBox1.DataSource = ListOfCountry;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void load_data()
        {
            country = new Country();
            HttpHelper helper = new HttpHelper();
            var data = helper.JSON_Convert("https://countriesnow.space/api/v0.1/countries");
            country = Newtonsoft.Json.JsonConvert.DeserializeObject<Country>(data);

        }
        private void set_data()
        {
            for(int i=0; i < country.data.Length;i++)
            {
                country_name = country.data[i].country;
                for(int j = 0; j < country.data[i].cities.Length;j++)
                {
                    city_name = country.data[i].cities[j];
                    full_name = city_name + "," + country_name;
                    ListOfCountry.Add(full_name);

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.fullName = comboBox1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Location Saved");
            this.Close();
        }
    }
}
