using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthAPI;

namespace TubesKPL
{
    class LoginHelper
    {
        public static async Task<string> SendLoginRequest(LoginReq loginReq, string loginAs)
        {
            var httpClient = new HttpClient();

            var json = JsonSerializer.Serialize(loginReq);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response;

            try
            {
                if (loginAs == "admin")
                {
                    response = await httpClient.PostAsync("http://localhost:5101/api/admin/login", content);
                }
                else
                {
                    response = await httpClient.PostAsync("http://localhost:5101/api/pelajar/login", content);
                }

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                else
                {
                    string errorBody = await response.Content.ReadAsStringAsync();
                    return errorBody;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error: {ex.Message}");
                return ex.Message;
            }
        }
    }
}
