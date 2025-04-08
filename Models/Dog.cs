using System;

namespace DogAPI.Models;

public class Dog
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Breed { get; set; }
    public int Age { get; set; }
}
