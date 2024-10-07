using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace ChatGPT_Mirror
{
    public partial class ChatGPT : Form
    {
        private const string apiKey = "sk-2KHCoDcaOzL7rQPULXCZ77k2wTQZydf0HSzrLZ7FKVof5ltc";  // 替换为你的API Key
        private const string apiUrl = "https://api.chatanywhere.tech/v1/chat/completions";

        public ChatGPT()
        {
            InitializeComponent();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            string question = MessagetoChatGPT.Text;  // 从TextBox获取用户输入的问题
            if (!string.IsNullOrEmpty(question))
            {
                string response = await CallChatGPTApi(question);
                ResponseMessage.Text = ExtractContentFromResponse(response);  // 只显示content部分
            }
            else
            {
                MessageBox.Show("请在文本框中输入问题。");
            }
        }

        private async Task<string> CallChatGPTApi(string question)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // 添加 API Key 到请求头
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                    // 创建请求内容
                    var jsonContent = $"{{\"model\":\"gpt-3.5-turbo\",\"messages\":[{{\"role\":\"user\",\"content\":\"{question}\"}}]}}";
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    // 发送POST请求
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    response.EnsureSuccessStatusCode();

                    // 获取响应内容
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException httpEx)
                {
                    return $"网络请求失败: {httpEx.Message}";
                }
                catch (Exception ex)
                {
                    return $"请求失败: {ex.Message}";
                }
            }
        }

        private string ExtractContentFromResponse(string jsonResponse)
        {
            try
            {
                // 解析JSON并提取 "content" 字段
                var jsonObj = JObject.Parse(jsonResponse);
                var content = jsonObj["choices"]?[0]?["message"]?["content"]?.ToString();
                return content ?? "无法提取content";
            }
            catch (Exception ex)
            {
                return $"解析错误: {ex.Message}";
            }
        }
    }
}
