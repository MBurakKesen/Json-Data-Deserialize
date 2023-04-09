using Json_Data_Deserialize.Models;
using Json_Data_Deserialize.Services;

namespace Json_Data_Deserialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            JsonUserServices src = new JsonUserServices();
            List<User> list= src.getUsers();
            dataGridView1.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}