class Program
{
    static HttpClient httpClient = new HttpClient();

    static async Task Main()
    {
        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://www.google.com");

        using HttpResponseMessage response = await httpClient.SendAsync(request);

        await Console.Out.WriteLineAsync($"Status: {response.StatusCode}");

        await httpClient.SendAsync(request);
    }
}