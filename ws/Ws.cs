//-----------------------------------------------------------------------
// <copyright file="Ws.cs" company="Studio A&T s.r.l.">
//     Copyright (c) Studio A&T s.r.l. All rights reserved.
// </copyright>
// <author>Nicogis</author>
//-----------------------------------------------------------------------
namespace FatturazioneElettronica.IPA
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Net.Http;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Linq;
    public abstract class Ws<T> where T : WsJson
    {      
        private const string baseUrl = "https://www.indicepa.gov.it:443/ws/";

        private readonly IList<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();

        static Ws()
        {
            ValidateSchema = false;
        }

        protected Ws(string authId)
        {
            this.AuthId = authId;
            this.AddParameters(new KeyValuePair<string, string>("AUTH_ID", this.AuthId));
        }

        protected bool AddParameters(KeyValuePair<string, string> kv)
        {
            List<string> keys = (from kvp in this.parameters select kvp.Key).ToList();

            bool result = keys.Contains(kv.Key);
            if (result)
            {
                this.parameters.Remove(this.parameters.First(item => item.Key == kv.Key));
            }

            if (!string.IsNullOrWhiteSpace(kv.Value))
            {
                this.parameters.Add(kv);
            }

            return !result;
        }

        protected async Task<string> SendRequestAsync(FormUrlEncodedContent requestParameters)
        {
            this.Endpoint = $"{this.GetType().Name.ToUpperInvariant().Replace("_", string.Empty)}Services/api/{this.GetType().Name.ToUpperInvariant()}";

            using (var httpClient = new HttpClient() { BaseAddress = new Uri(Ws<T>.baseUrl) })
            using (var httpResponse = await httpClient.PostAsync(this.Endpoint, requestParameters))
            {
                if (!httpResponse.IsSuccessStatusCode)
                {
                    return null;
                }

                return await httpResponse.Content.ReadAsStringAsync();
            }

        }

        public static bool ValidateSchema { get; set; }

        public string AuthId { get; set; }
        protected string Endpoint { get; set; }

        public static T FromJson(string json) => JsonConvert.DeserializeObject<T>(json, Converter.Settings);
        
        protected T Request()
        {
            try
            {
                FormUrlEncodedContent requestParameters = new FormUrlEncodedContent(this.parameters);

                string json = this.SendRequestAsync(requestParameters).Result;

                if (string.IsNullOrWhiteSpace(json))
                {
                    throw new Exception("Il ws ha restituito una risposta vuota: probabilmente i parametri passati hanno caratteri non consentiti o altri problemi (es. apici da raddoppiare, parametro non formalmente corretto ecc.)");
                }
                
                ValidateJsonSchema(json);

                return Ws<T>.FromJson(json);
                
            }
            catch
            {
                throw;
            }
        }

        protected async System.Threading.Tasks.Task<T> RequestAsync()
        {
            try
            {
                FormUrlEncodedContent requestParameters = new FormUrlEncodedContent(this.parameters);

                string json = await this.SendRequestAsync(requestParameters);

                if (string.IsNullOrWhiteSpace(json))
                {
                    throw new Exception("Il ws ha restituito una risposta vuota: probabilmente i parametri passati hanno caratteri non consentiti o altri problemi (es. apici da raddoppiare ecc.)");
                }

                ValidateJsonSchema(json);

                return Ws<T>.FromJson(json);

            }
            catch
            {
                throw;
            }
        }

        protected virtual void ValidateJsonSchema(string json)
        {
            if (!Ws<T>.ValidateSchema) 
                return;
            JObject ws = JObject.Parse(json);
            string result = null;
            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream($"{this.GetType().Namespace}.JsonSchema.{this.GetType().Name.ToUpperInvariant()}_SCHEMA.{Enum.GetName(typeof(EstensioniFile), EstensioniFile.json)}")))
            {
                result = reader.ReadToEnd();
            }

            JSchema schema = JSchema.Parse(result);

            if (!ws.IsValid(schema, out IList<string> errors))
            {
                var e = string.Join(Environment.NewLine, errors);

                throw new Exception($"Json non valido con lo schema indicato da IPA:{Environment.NewLine}{e}");
            }
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };

    }
}

