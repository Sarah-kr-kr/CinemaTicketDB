using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CinemaTicketApp.Models;
using Newtonsoft.Json;

public static class ApiMessageDAL
{
    private static readonly string apiUrl = "https://dev2.alashiq.com/message.php?systemId=2651412887162";

    public static async Task<List<ApiMessage>> GetAllMessagesAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(json);

                    return apiResponse?.data?.messages ?? new List<ApiMessage>();
                }
                else
                {
                    return new List<ApiMessage>();
                }
            }
            catch
            {
                return new List<ApiMessage>();
            }
        }
    }
}