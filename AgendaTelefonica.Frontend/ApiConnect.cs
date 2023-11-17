using Newtonsoft.Json;
using System.Text;

namespace AgendaTelefonica.Frontend
{
    internal class ApiConnect
    {
        private readonly string apiAdress = "https://localhost:7000";

        public enum CallType : byte
        {
            Get = 1,
            Post = 2,
            Put = 3,
            Delete = 4,
        }

        public T? CallApi<T>(CallType callType, string command, object? obj = null)
        {
            T? result = default;
            var address = $"{apiAdress}/{command}";

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = new HttpResponseMessage();

                switch (callType)
                {
                    case CallType.Get:
                        response = httpClient.GetAsync(address).Result;
                        break;

                    case CallType.Post:
                        var contentPost = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                        response = httpClient.PostAsync(address, contentPost).Result;
                        break;

                    case CallType.Put:
                        var contentPut = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                        response = httpClient.PutAsync(address, contentPut).Result;
                        break;
                    case CallType.Delete:
                        response = httpClient.DeleteAsync(address).Result;
                        break;
                }

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<T>(responseBody);
                }
                else
                {
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show(responseBody, "Erro de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }


    }
}
