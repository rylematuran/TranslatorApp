using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace TranslatorApp
{
    public partial class Form1 : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;
        private Dictionary<string, string> languageCodes;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            InitializeLanguageCodes();
        }

        private void InitializeLanguageCodes()
        {
            languageCodes = new Dictionary<string, string>
            {
                { "English", "en" },
                { "Arabic", "ar" },
                { "Chinese", "zh" },
                { "Spanish", "es" },
                { "French", "fr" },
                { "Greek", "el" },
                { "Tagalog", "tl" },
                { "Indonesian", "id" },
                { "Irish", "ga" },
                { "Italian", "it" },
                { "Japanese", "ja" },
                { "Korean", "ko" },
                { "Latin", "la" },
                { "Mongolian", "mn" },
                { "Polish", "pl" },
                { "Portuguese", "pt" },
                { "Russian", "ru" },
                { "Romanian", "ro" },
                { "Swedish", "sv" },
                { "Thai", "th" },
                { "Turkish", "tr" },
                { "Vietnamese", "vi" },
                { "German", "de" }
            };
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string sourceCode = languageCodes[sourceLang];
            string targetCode = languageCodes[targetLang];

            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceCode}|{targetCode}";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textInput.BorderRadius = 20;
            textOutput.BorderRadius = 20;

            SourceLanguage.BorderRadius = 20;
            TargetLanguage.BorderRadius = 20;

            SourceLanguage.Items.AddRange(languageCodes.Keys.ToArray());
            TargetLanguage.Items.AddRange(languageCodes.Keys.ToArray());
            SourceLanguage.SelectedIndex = 0;
            TargetLanguage.SelectedIndex = 1;
        }

        private async void buttonTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(textInput.Text, SourceLanguage.SelectedItem.ToString(),
                    TargetLanguage.SelectedItem.ToString());
                textOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation Failed. Try again. Error: \r\n" + ex.Message);
            }
        }

        private void SourceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }

        public string TranslatedText => ResponseData?.TranslatedText;
    }

    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
    }
}
