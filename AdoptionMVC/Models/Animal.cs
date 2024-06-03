using System;
using System.Collections.Generic;

namespace AdoptionMVC.Models;

public partial class Animal
{
    public int Id { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Breed { get; set; }

    public int? Age { get; set; }
}
