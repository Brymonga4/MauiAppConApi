
using MauiAppConApi.Models;

namespace MauiAppConApi.Dtos
{
    public record CharacterDto(
        int Id,
        string Name,
        string Status,
        string Species,
        string Type,
        string Gender,
        Origin Origin,
        Models.Location Location,
        string Image
        )
    {
  
    }

    public record LocationDto(
        int Id,
        string Name,
        string Type,
        string Dimension,
        List<string> Residents
        );

    public record LocationAndResidentsDto(
    int Id,
    string Name,
    string Type,
    string Dimension,
    List<CharacterDto> Residents
    );



    public record CharacterAndInfoDto(
    int Id,
    string Name,
    string Status,
    string Species,
    string Type,
    string Gender,
    Origin Origin,
    Models.Location Location,
    string Image,
    Info Info
    );

}
