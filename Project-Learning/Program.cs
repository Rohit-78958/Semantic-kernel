using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.ComponentModel;



var builder = Kernel.CreateBuilder();
builder.AddAzureOpenAIChatCompletion(
    "gpt-4o",
    "https://xxx-m40rfif0-eastus2.cognitiveservices.azure.com/",
    "xxxxx",
    "gpt-4o");

//var kernel = builder.Build();

//var result = await kernel.InvokePromptAsync(
//        "Give me a list of breakfast foods with eggs and cheese");
//Console.WriteLine(result);



builder.Plugins.AddFromType<TimeTeller>(); // <------------ Telling kernel about time plugins
builder.Plugins.AddFromType<ElectricCar>(); // <------------ Telling kernel about car plugins
var kernel = builder.Build();

OpenAIPromptExecutionSettings settings = new() { ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions };
while (true)
{
    Console.Write("User > ");
    string userMessage = Console.ReadLine();
    Console.WriteLine(await kernel.InvokePromptAsync(userMessage, new(settings)));
    Console.WriteLine("--------------------------------------------------------------");
}

public class TimeTeller // <------------ Time teller plugin. An expert on time, peak and off-peak periods
{
    [Description("This function retrieves the current time.")]
    [KernelFunction]
    public string GetCurrentTime() => DateTime.Now.ToString("F");

    [Description("This function checks if in off-peak period between 9pm and 7am")]
    [KernelFunction]
    public bool IsOffPeak() => DateTime.Now.Hour < 7 || DateTime.Now.Hour >= 21;
}

public class ElectricCar // <------------ Car plugin. Knows about states and conditions of the electric car.
{
    private bool isCarCharging = false;
    [Description("This function starts charging the electric car.")]
    [KernelFunction]
    public string StartCharging()
    {
        if (isCarCharging)
        {
            return "Car is already charging.";
        }
        isCarCharging = true; // This is where you would call httos://tesla/api/mycar/start. Kidding, you got the idea.
        return "Charging started.";
    }

    [Description("This function stops charging the electric car.")]
    [KernelFunction]
    public string StopCharging()
    {
        if (!isCarCharging)
        {
            return "Car is not charging.";
        }
        isCarCharging = false;
        return "Charging stopped.";
    }
}

























