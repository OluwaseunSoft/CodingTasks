using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CodingTasks.JsonCleansing
{
    internal class JsonCleansing
    {
        public static string CleansedJson()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://coderbyte.com/api/challenges/json/json-cleaning");
            var response = client.Send(request);
            response.EnsureSuccessStatusCode();
            var results = JsonConvert.DeserializeObject<RootObject>(response.Content.ReadAsStringAsync().Result);

            string na = "N/A", dash = "-", null1 = "";

            var newResult = new JsonObject();
            newResult["name"] = new JsonObject();
           // newResult["hobbies"] = new JsonArray()[3];
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

            string[] test1 = new string[results.hobbies.Length];
            for (int i = 0; i < results.hobbies.Length; i++)
            {

                if (results.hobbies[i].ToString() != na && results.hobbies[i].ToString() != dash && results.hobbies[i].ToString() != null1)
                {
                    int num = 1;
                    test1[i] = results.hobbies[i].ToString();
                    newResult["hobbies"] = results.hobbies[i].ToString();
                    //newResult["hobbies"][num] = results.hobbies[i].ToString();
                    num++;
                }
            }


            var forecastObject = new JsonObject
            {
                ["Date"] = new DateTime(2019, 8, 1),
                ["Temperature"] = 25,
                ["Summary"] = "Hot",
                ["DatesAvailable"] = new JsonArray(
            new DateTime(2019, 8, 1), new DateTime(2019, 8, 2)),
                ["TemperatureRanges"] = new JsonObject
                {
                    ["Cold"] = new JsonObject
                    {
                        ["High"] = 20,
                        ["Low"] = -10
                    }
                },
                ["SummaryWords"] = new JsonArray("Cool", "Windy", "Humid")
            };
            // Add an object.
            forecastObject!["TemperatureRanges"]!["Hot"] =
                new JsonObject { ["High"] = 60, ["Low"] = 20 };

            // Remove a property.
            forecastObject.Remove("SummaryWords");

            // Change the value of a property.
            forecastObject["Date"] = new DateTime(2019, 8, 3);

            var options = new JsonSerializerOptions { WriteIndented = true };
            Console.WriteLine(newResult.ToJsonString(options));
            return "";
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
