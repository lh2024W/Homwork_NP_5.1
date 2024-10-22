namespace Homwork_NP_5._1
{
    class Program
    {
        static HttpClient httpClient = new HttpClient();

        static async Task Main()
        {
            // определяем данные запроса
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://www.google.com");

            // получаем ответ
            using HttpResponseMessage response = await httpClient.SendAsync(request);

            // просматриваем данные ответа статус
            Console.WriteLine($"Status: {response.StatusCode}\n");
            //заголовки
            Console.WriteLine("Headers");
            foreach (var header in response.Headers)
            {
                Console.Write($"{header.Key}:");
                foreach (var headerValue in header.Value)
                {
                    Console.WriteLine(headerValue);
                }
            }
            
        }
    }

}
