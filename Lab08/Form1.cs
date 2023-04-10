using Newtonsoft.Json.Linq;
using System.Net;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Lab08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string convertExchange(string from, string to, string amount)
        {
            string date = dtpDateEx.Value.ToString("yyyy-MM-dd");
            string api = string.Format("https://api.exchangerate.host/convert?from={0}&to={1}&amount={2}&date={3}", from, to, amount, date);
            string r = Load_Get(api);
            JObject obj = JObject.Parse(r);
            string result = obj.GetValue("result").ToString();
            return result;
        }

        private string Load_Get(string api) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api);
            request.AutomaticDecompression= DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            { 
                return reader.ReadToEnd();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbResult.ReadOnly = true;
            List<ExchangeRate> exchangeRates= new List<ExchangeRate>();
            string api = "https://api.exchangerate.host/latest";
            string r = Load_Get(api);
            JObject obj = JObject.Parse(r);
            JObject rates = (JObject)obj.GetValue("rates");
            rates.Properties().ToList().ForEach(x =>
            {
                ExchangeRate rate = new ExchangeRate(x.Name, double.Parse(x.Value.ToString()));
                exchangeRates.Add(rate);
            });

            dgvRateData.DataSource = exchangeRates;
            dtpDate.Value = DateTime.Parse(obj.GetValue("date").ToString());
            List<string> listSymbols = rates.Properties().Select(x => x.Name).ToList();
            cbSymbol.DataSource = listSymbols;
            cbFrom.DataSource = new List<string>(listSymbols);
            cbTo.DataSource = new List<string>(listSymbols);
            cbSym.DataSource = new List<string>(listSymbols);
            cbSym.Text = "";
            cbSymbol.SelectedItem = obj.GetValue("base").ToString();
            cbFrom.SelectedIndex = 0;
            cbTo.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txbResult.Text = convertExchange(cbFrom.Text, cbTo.Text, txbAmout.Text);
        }

        private void btnLoadEx_Click(object sender, EventArgs e)
        {
            List<ExchangeRate> exchangeRates = new List<ExchangeRate>();
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string symbols = cbSym.Text;
            string based = cbSymbol.Text;
            string api;
            
            if (symbols == "")
            {
                api = string.Format("https://api.exchangerate.host/{0}?base={1}", date, based);
            }
            else {
                api = string.Format("https://api.exchangerate.host/{0}?base={1}&symbols={2}", date, based, symbols);

            }
            string r = Load_Get(api);
            JObject obj = JObject.Parse(r);
            JObject rates = (JObject)obj.GetValue("rates");
            rates.Properties().ToList().ForEach(x =>
            {
                ExchangeRate rate = new ExchangeRate(x.Name, double.Parse(x.Value.ToString()));
                exchangeRates.Add(rate);
            });

            dgvRateData.DataSource = exchangeRates;
        }
    }
}