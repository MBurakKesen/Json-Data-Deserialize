using Json_Data_Deserialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Data_Deserialize.Services
{
    public class JsonUserServices
    {
        List<User> list;

        public List<User> getUsers()
        {
            try
            {
                WebClient client = new WebClient();
                string users = client.DownloadString(@"https://jsonplaceholder.typicode.com/users");
                list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(users);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            return list;
        }
    }
}
