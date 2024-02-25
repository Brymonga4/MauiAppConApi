using MauiAppConApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppConApi.Services;

public partial class DummyService
{
    public List<Cosa> GetAllCosas() => [
    new Cosa { Id = 0, Name = "Una cosa" },
        new Cosa { Id = 1, Name = "Otra cosa" },
        new Cosa { Id = 2, Name = "Otra cosa más" },
        new Cosa { Id = 3, Name = "Otra cosa más" },
        new Cosa { Id = 4, Name = "Otra cosa más" },
        new Cosa { Id = 5, Name = "Otra cosa más" },
    ];
}
