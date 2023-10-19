using System.Text.Json.Serialization;

class Program
{
    static HttpClient httpClient = new HttpClient();

    static async Task Main()
    {
        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://www.google.com");

        using HttpResponseMessage response = await httpClient.SendAsync(request);

        Console.WriteLine($"Status: {response.StatusCode}");

        Console.WriteLine("Headers");
        foreach( var header in response.Headers)
        {
            Console.WriteLine($"{header.Key}");
            foreach(var headerValue in header.Value)
            {
                Console.WriteLine(headerValue);
            }
        }

        Console.WriteLine("\nContent");
        string content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);

        //await httpClient.SendAsync(request);
    }
}