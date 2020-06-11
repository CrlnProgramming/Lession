using System;
using System.Globalization;
using System.Net.Http;
using System.Text;


namespace Reminder.Storage.WebApi
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private readonly HttpClient _client;
        private const string EndpointPrefix = "/api/reminder";
        public ReminderItemStorage(string endpoint)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(endpoint)
            };
        }
        public void Add(ReminderItem item)
        {

            //_client.PostAsync(EndpointPrefix,content);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReminderItem Find(Guid id)
        {
            /*_client.GetAsync();Http get
            _client.SendAsync();
            _client.PutAsync();
            _client.DeleteAsync();
            _client.PatchAsync();
           
            */
            HttpResponseMessage response = _client.GetAsync($"{EndpointPrefix}{id:N}").GetAwaiter().GetResult();
            var array = response.Content.ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            string paylod = response.Content.ReadAsStringAsync().Result;

            //var dto =  JsonSerializer.
            
        }

        public ReminderItem[] FindBy(ReminderItemFilter filter)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
