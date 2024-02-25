﻿

using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using System.Text.Json;

namespace MauiAppConApi.Data;

public class RestService
{
    public List<Character> ?Items { get; set; }
    public List<LocationComplete> ?LocationItems { get; set; }
    public List<CharacterResults> ?CharResultsItems { get; set; }

    public Character ?Item { get; set; }
    public LocationComplete ?ItemLocatationComplete { get; set; }

    private HttpClient client;
    private HttpRequestMessage request;
    private HttpResponseMessage response;
    private JsonSerializerOptions serializerOptions;
    public RestService() 
    {
        serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

    }

    public async Task <Character> GetCharacterRandom()
    {
        var rand = new Random();
        int randId = rand.Next(1, 827);

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage 
            { 
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rickandmortyapi.com/api/character/2"),
            };
            using(response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                Item = JsonSerializer.Deserialize<Character>(body, serializerOptions);
                return Item;

            }
        }
    }
    public async Task<Character> GetCharacterById(int id)
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rickandmortyapi.com/api/character/{id}"),
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                Item = JsonSerializer.Deserialize<Character>(body, serializerOptions);
                return Item;

            }
        }
    }
    public async Task<List<Character>> GetCharacters()
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rickandmortyapi.com/api/character/?page=1"),
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var characterResults = JsonSerializer.Deserialize<CharacterResults>(body, serializerOptions);

                Items = characterResults.Results;

                return Items;

            }
        }
    }

    public async Task<CharacterResults> GetCharactersAndInfo()
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rickandmortyapi.com/api/character/?page=1"),
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var characterResults = JsonSerializer.Deserialize<CharacterResults>(body, serializerOptions);

                return characterResults;

            }
        }
    }

    public async Task<List<LocationComplete>> GetLocations()
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rickandmortyapi.com/api/location/?page=1"),
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var locationResults = JsonSerializer.Deserialize<LocationResults>(body, serializerOptions);

                LocationItems = locationResults.Results;

                return LocationItems;

            }
        }
    }

    public async Task<LocationComplete> GetLocationById(int id)
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rickandmortyapi.com/api/location/{id}"),
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                ItemLocatationComplete = JsonSerializer.Deserialize<LocationComplete>(body, serializerOptions);
                return ItemLocatationComplete;

            }
        }
    }

    public async Task<List<LocationComplete>> GoToLocationPage(Uri uri)
    {
        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var locationResults = JsonSerializer.Deserialize<LocationResults>(body, serializerOptions);

                LocationItems = locationResults.Results;

                return LocationItems;

            }
        }
    }



    public async Task<CharacterResults> GetCharactersPage(Uri uri)
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var characterResults = JsonSerializer.Deserialize<CharacterResults>(body, serializerOptions);

                return characterResults;
            }
        }
    }

    public async Task<LocationResults> GetLocationsPage(Uri uri)
    {

        using (client = new HttpClient())
        {
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
            };
            using (response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var locationResults = JsonSerializer.Deserialize<LocationResults>(body, serializerOptions);

                return locationResults;
            }
        }
    }


}