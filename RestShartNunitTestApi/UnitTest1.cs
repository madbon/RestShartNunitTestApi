using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json;

namespace RestShartNunitTestApi
{
    public class Tests
    {


        private RestClient _client;
        string base_url = "https://automationexercise.com/api/brandsList";

        [SetUp]
        public void Setup()
        {
            
            _client = new RestClient("https://automationexercise.com/api/");
        }

        public class SearchResponse
        {
            public int responseCode { get; set; }
            //public List<Product> products { get; set; }
        }

        [Test, Order(0)]
        public void TestGet()
        {
            Console.WriteLine(GetApi());
        }

        [Test, Order(1)]
        public void SearchProductTest()
        {
            Console.WriteLine(PostApi("tshirt"));
        }

        public Object PostApi(string product_name)
        {
            var request = new RestRequest("searchProduct", Method.Post);
            request.AddParameter("search_product", product_name);

            var response = _client.Execute(request);
            var deserialize = JsonConvert.DeserializeObject<dynamic>(response.Content);

            JObject json_result = new JObject(
                     new JProperty("json_obj", deserialize),
                     new JProperty("response", response.Content)
                    );

            return json_result;
        }



        public Object GetApi()
        {
            RestClient client = new RestClient(base_url);
            RestRequest request = new RestRequest();
            var response = client.Get(request);
            var json_obj = JsonConvert.DeserializeObject<dynamic>(response.Content);

            JObject json_result = new JObject(
                     new JProperty("json_obj", json_obj),
                     new JProperty("response", response.Content)
                    );

            return json_result;
        }
    }
}