using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Nomina.API.Controllers
{
    public class APINomina
    {
        private readonly HttpClient _httpClient; // comunication with external API
        private readonly string _baseUrl; // base URL of the external API
        public APINomina(string baseUrl)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _httpClient = new HttpClient();
           

        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            
            var respuesta = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}"); //arma la URL completa del api
            respuesta.EnsureSuccessStatusCode(); //verifica que la respuesta sea exitosa
            var contenido = await respuesta.Content.ReadAsStringAsync(); //lee el contenido de la respuesta
            return JsonConvert.DeserializeObject<T>(contenido); //serializa el contenido a un objeto del tipo T  

        }


    }
}
