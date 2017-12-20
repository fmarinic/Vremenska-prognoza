using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudF;

namespace Forecast_Weather_Form
{
    //private readonly Form1 FormCityList
    public partial class AddCity_Form : Form
    {
        public AddCity_Form()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City oCity = new City();
            Crud Crud = new Crud();
            oCity.sName = inptCityName.Text;
            oCity.fLat = float.Parse(inptLat.Text);
            oCity.fLng = float.Parse(inptLng.Text);

            Crud.AddCity(oCity);
          //this.Forma1.dataGridViewUsers.DataSource = Crud.GetAllCities();
            this.Hide();
        }
    }
}
