using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;


namespace Win_to_WebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/EmpApi/");
            HttpResponseMessage respose = client.GetAsync("api/Emp").Result;

            var emp = respose.Content.ReadAsAsync<IEnumerable<Emp>>().Result;
            dataGridView1.DataSource = emp;
        }
    }
}
