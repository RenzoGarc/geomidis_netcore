using GeomidisSystem.Models.Pais;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeomidisSystem.Services
{
    public class PaisServices
    {
        public async Task<List<SpgPsPuatpias>> Puatpias()
        {
            string baseUrl = "https://suite.juegodepalabras.com.pe/pruebas/puatpias";
            string respuestaNull = "[]";
            try
            {
                using HttpClient client = new();
                using HttpResponseMessage res = await client.GetAsync(baseUrl);
                //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                using HttpContent content = res.Content;
                //Now assign your content to your data variable, by converting into a string using the await keyword.
                var data = await content.ReadAsStringAsync();
                //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                if (data != null)
                {
                    List<SpgPsPuatpias> spgPsPuatpias = JsonConvert.DeserializeObject<List<SpgPsPuatpias>>(data);
                    return spgPsPuatpias;
                }
                else
                {
                    List<SpgPsPuatpias> spgPsPuatpias = JsonConvert.DeserializeObject<List<SpgPsPuatpias>>(respuestaNull);
                    return spgPsPuatpias;
                }
            }
            catch (Exception exception)
            {
                List<SpgPsPuatpias> spgPsPuatpias = JsonConvert.DeserializeObject<List<SpgPsPuatpias>>(respuestaNull);
                return spgPsPuatpias;
            }
        }
        public string Name { get; private set; }
    }
}
