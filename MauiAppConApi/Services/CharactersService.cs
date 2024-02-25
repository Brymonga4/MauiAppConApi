using MauiAppConApi.Data;
using MauiAppConApi.Dtos;
using MauiAppConApi.Models;
using System.Collections.Generic;

namespace MauiAppConApi.Services;

public partial class CharactersService(RestService restService) : IServices<CharacterDto>
{
    private readonly RestService restService = restService;

    public async Task<List<CharacterDto>> GetAll()
    {
        var characters = await restService.GetCharacters();
        return characters.Select(character => character.AsDto()).ToList();
    }


    public async Task<CharacterDto> GetById(int id)
    {
        var character = await restService.GetCharacterById(id);
        return character.AsDto();
    }

    public async Task<CharacterResults> GetCharactersWithPage(Uri uri)
    {
        var charactersResults = await restService.GetCharactersPage(uri);
        return charactersResults;

    }
}
