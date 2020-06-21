using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Reminder.Storage.WebApi.Dto;

namespace Reminder.Storage.WebApi
{
    public class ReminderItemStorage : IReminderItemStorage
    {
        private const string EndpointPrefix = "/api/reminders";
        private readonly HttpClient _client;
        private static readonly JsonSerializerOptions SerializerOptions =
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
        
        private static readonly JsonSerializerOptions DeserializerOptions =
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new JsonStringEnumConverter()
                }
            };

        public ReminderItemStorage(string endpoint) :
            this(new HttpClient { BaseAddress = new Uri(endpoint) })
        {
        }

        public ReminderItemStorage(HttpClient client)
        {
            _client = client;
        }

        public void Add(ReminderItem item)
        {
            var dto = new ReminderItemDto(item);
            var payload = JsonSerializer.Serialize(dto, SerializerOptions);
            var content = new StringContent(payload, Encoding.Default, "application/json");
            var response = _client.PostAsync(EndpointPrefix, content)
                .GetAwaiter()
                .GetResult();

            switch (response.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    throw new ArgumentException("Data was invalid");
                case HttpStatusCode.Conflict:
                    throw new ArgumentException("Reminder item with same id exists");
            }
        }

        public ReminderItem Find(Guid id)
        {
            var response = _client.GetAsync($"{EndpointPrefix}/{id:N}")
                .GetAwaiter()
                .GetResult();

            // JSON
            var payload = response.Content.ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            var dto = JsonSerializer.Deserialize<ReminderItemDto>(payload, DeserializerOptions);

            return new ReminderItem(
                Guid.Parse(dto.Id),
                dto.Title,
                dto.Message,
                DateTimeOffset.Parse(dto.DateTimeUtc),
                new User(dto.UserLogin, dto.UserChatId), dto.Status);
                
        }

        public ReminderItem[] FindBy(DateTimeOffset filter)
        {
            throw new NotImplementedException();
        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}