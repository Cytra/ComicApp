using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WPFComicApp
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunInformation()
        {
            string url = "http://api.sunrise-sunset.org/json?lat=54.68916&lng=25.2798&date=today";

            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();
                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
