using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace web_service_testing {
    class Program {
        const string BASE_URL = "https://localhost:44357/api/";

        static void Main(string[] args) {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri(BASE_URL);

                var resp = client.GetAsync("Test");
                resp.Wait();
                var result = resp.Result;

                if(result.IsSuccessStatusCode) {
                    var strResult = result.Content.ReadAsStringAsync();
                    strResult.Wait();
                    Console.WriteLine(strResult.Result);
                }
                
                Console.ReadLine();
            }
            
        }
    }
}
