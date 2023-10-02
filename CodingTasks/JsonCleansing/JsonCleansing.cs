using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CodingTasks.JsonCleansing
{
    internal class JsonCleansing
    {
        public static void CleansedJson()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "https://coderbyte.com/api/challenges/json/json-cleaning");
                var response = client.Send(request);
                response.EnsureSuccessStatusCode();
                var results = JsonConvert.DeserializeObject<RootObject>(response.Content.ReadAsStringAsync().Result);

                string na = "N/A", dash = "-", null1 = "";

                var newResult = new JsonObject();

                newResult["name"] = new JsonObject();

                if (results.name.first != na && results.name.first != dash && results.name.first != null1)
                {
                    newResult["name"]!["first"] = results.name.first;
                }
                if (results.name.middle != na && results.name.middle != dash && results.name.middle != null1)
                {
                    newResult["name"]!["middle"] = results.name.middle;
                }
                if (results.name.last != na && results.name.last != dash && results.name.last != null1)
                {
                    newResult["name"]!["last"] = results.name.last;
                }

                if (results.age.ToString() != na && results.age.ToString() != dash && results.age.ToString() != null1)
                {
                    newResult["age"] = results.age;
                }

                if (results.DOB.ToString() != na && results.DOB.ToString() != dash && results.DOB.ToString() != null1)
                {
                    newResult["DOB"] = results.DOB;
                }
                
                newResult["hobbies"] = new JsonArray();
                for (int i = 0; i < results.hobbies.Length; i++)
                {
                    if (results.hobbies[i].ToString() != na && results.hobbies[i].ToString() != dash && results.hobbies[i].ToString() != null1)
                    {
                        newResult["hobbies"]?.AsArray().Add<string>(results.hobbies[i].ToString());
                    }
                }

                newResult["education"] = new JsonObject();
                if (results.education.highschool != na && results.education.highschool != dash && results.education.highschool != null1)
                {
                    newResult["education"]!["highschool"] = results.education.highschool;
                }
                if (results.education.college != na && results.education.college != dash && results.education.college != null1)
                {
                    newResult["education"]!["college"] = results.education.college;
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                Console.WriteLine("Cleansed Json Task From https://coderbyte.com/api/challenges/json/json-cleaning : {0}", newResult.ToJsonString(options));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    public class RootObject
    {
        public NameObject name { get; set; }
        public int age { get; set; }
        public string DOB { get; set; }
        public string[] hobbies { get; set; }
        public EduObject education { get; set; }
    }


    public class EduObject
    {
        public string highschool { get; set; }
        public string college { get; set; }
    }


    public class NameObject
    {
        public string first { get; set; }
        public string middle { get; set; }
        public string last { get; set; }
    }
}
