

using MauiAppConApi.Dtos;

namespace MauiAppConApi.Models;

public static class ModelExtensions
{
    public static CharacterDto AsDto(this Character character)
    {
        return new CharacterDto(
            character.Id,
            character.Name,
            character.Status,
            character.Species,
            character.Type,
            character.Gender,
            character.Origin,
            character.Location,
            character.Image
            
            );
    }


    public static LocationDto AsDto(this LocationComplete location)
    {

        return new LocationDto(
            location.Id,
            location.Name,
            location.Type,
            location.Dimension,
            location.Residents
            );
    }

    public static LocationAndResidentsDto AsDto(this LocationDto location, List<CharacterDto> residents)
    {

        return new LocationAndResidentsDto(
            location.Id,
            location.Name,
            location.Type,
            location.Dimension,
            residents
            );
    }


}
