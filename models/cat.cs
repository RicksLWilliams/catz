using System;
using System.ComponentModel.DataAnnotations;

namespace catz
{

  public class Cat
  {
    [Required]
    [MinLength(5)]
    public string Name { get; set; }
    [Required]
    [MaxLength(140)]
    public string Owner  { get; set; }
    [Required]
    public string Breed { get; set; }
    public string Id { get; private set; }

    public Cat()
    {
      Id = Guid.NewGuid().ToString();
    }

    public Cat(string name, string owner, string breed)
    {
      Name = name;
      Owner  = owner ;
      Breed = breed;
      Id = Guid.NewGuid().ToString();
    }
  }
}