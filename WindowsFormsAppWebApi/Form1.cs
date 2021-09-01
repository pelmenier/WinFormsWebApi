using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWebApi
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client;
        private string ACCESS_TOKEN = "27eed51727eed51727eed5172b2797ff67227ee27eed51746c1941a225751a650a6839b";
        private string VERSION = "5.131";
        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string JsonPretty(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }
        async void FetchUserInfo()
        {
            HttpResponseMessage response = await _client.GetAsync($"https://api.vk.com/method/users.get?user_ids={textUserId.Text}&access_token={ACCESS_TOKEN}&v={VERSION}");
            textResponse.Text = JsonPretty(await response.Content.ReadAsStringAsync());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FetchUserInfo();
            textResponse.Text = "Loading...";
        }
    }
}
