using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SemanticKernel;


namespace Project_Learning
{
    internal class mistral
    {
        string apiKey = "xxxxxxxx";
        string modelID = "mistral-small-latest";  // Updated model ID

        // Create kernel
        //var builder = Kernel.CreateBuilder();
        //builder.AddMistralChatCompletion(apiKey, modelID);
        //var kernel = builder.Build();

        //try
        //{
        //    // Prompt for model
        //    string prompt = "hi greet me.";
        //var result = await kernel.InvokePromptAsync(prompt, templateFormat: null);

        //// Output result
        //Console.WriteLine(result);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Error: {ex.Message}");
        ////}



        //class Program
        //{
        //    static async Task Main(string[] args)
        //    {
        //        string apiUrl = "https://api.mistral.ai/v1/chat/completions";
        //        string apiKey = "dbAQrSw4M7l3bZcXtoZABwQIvjxZ1Ee1"; // Replace with your API key

        //        var httpClient = new HttpClient();
        //        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        //        var payload = new
        //        {
        //            model = "mistral-small-latest",
        //            temperature = 1.0,
        //            top_p = 1,
        //            max_tokens = 100,
        //            stream = false,
        //            messages = new[]
        //            {
        //                new { role = "user", content = "Who is the best French painter? Answer in one short sentence." }
        //            },
        //            response_format = new { type = "text" },
        //            presence_penalty = 0,
        //            frequency_penalty = 0,
        //            n = 1
        //        };

        //        var content = new StringContent(
        //            Newtonsoft.Json.JsonConvert.SerializeObject(payload),
        //            Encoding.UTF8,
        //            "application/json");

        //        var response = await httpClient.PostAsync(apiUrl, content);
        //        var result = await response.Content.ReadAsStringAsync();

        //        System.Console.WriteLine(result);
        //    }
        //}

    }
}
