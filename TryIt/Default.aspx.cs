using System;
using System.Text;
using System.Web.UI;
using TryIt.WebDownloadService;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InvokeNearestStore_Click(object sender, EventArgs e)
        {
            if (ZipcodeTextBox.Text != "" && StoreNameTextBox.Text != "")
            {
                if (isValidZipcode(ZipcodeTextBox.Text))
                {
                    FindNearestStoreService.Service1Client storeService = new FindNearestStoreService.Service1Client();
                    string result = storeService.findNearestStore(ZipcodeTextBox.Text, StoreNameTextBox.Text);
                    StoreResult.Text = result;
                }
                else StoreResult.Text = "invalid zipcode";
            }
        }

        protected void InvokeWordCount_Click(object sender, EventArgs e)
        {
            WordCountService.Service1Client countService = new WordCountService.Service1Client();

            byte[] bytes = FileUpload1.FileBytes;
            string contents = Encoding.ASCII.GetString(bytes);
            CountResult.Text = countService.wordCount(contents);
        }

        private bool isValidZipcode(string zipcode)
        {
            if (zipcode.Length == 5)
            {
                foreach (char ch in zipcode)
                {
                    if (ch < '0' || ch > '9') return false;
                }
            }
            return true;
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            WebDownloadService.WebDownloadServiceClient downloadService = new WebDownloadService.WebDownloadServiceClient();
            if (txtURL.Text != "")
            {
                txtWebDownloadOutput.Text = downloadService.WebDownload(txtURL.Text);
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            WordFilterService.WordFilterServiceClient wordFilterService = new WordFilterService.WordFilterServiceClient();
            if (txtText.Text != "" && txtStopWords.Text != "")
            {
                var stopWords = txtStopWords.Text.Split(',');
                txtWordFilterOutput.Text = wordFilterService.WordFilter(txtText.Text, stopWords);
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            string uvIndex = "";
            int dayOfYear = int.Parse(TextBox1.Text);
            decimal lat = decimal.Parse(TextBox2.Text);
            decimal lon = decimal.Parse(TextBox3.Text);
            SolarService.Service1Client solarService = new SolarService.Service1Client();
            decimal finalOutput = solarService.SolarIntensity(lat, lon);
            TextBox4.Text = (finalOutput.ToString() + " kWh/m2");
            if (finalOutput <= 40) uvIndex = "LOW";
            else if (finalOutput > 40 && finalOutput <= 100) uvIndex = "MODERATE";
            else if (finalOutput > 100 && finalOutput <= 150) uvIndex = "HIGH";
            else if (finalOutput > 150) uvIndex = "EXTREME";
            TextBox5.Text = uvIndex;
        }

        protected void btnCalculateWind_Click(object sender, EventArgs e)
        {
            WindService.Service1Client windService = new WindService.Service1Client();
            decimal lat = decimal.Parse(txtLat.Text);
            decimal lon = decimal.Parse(txtLong.Text);
            decimal windInt = windService.WindIntensity(lat, lon);
            decimal indexW = windInt / 5;
            txtWindIndex.Text = indexW.ToString();
            decimal conversion = windInt / 144;
            txtWindPressure.Text = conversion.ToString();
        }
    }
}