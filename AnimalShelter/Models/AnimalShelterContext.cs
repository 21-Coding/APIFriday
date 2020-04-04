using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Bird> Birds { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Bird>()
      .HasData(
        new Bird { BirdId = 1,  Name = "Bert", Breed = "Eagle", Age = 2, Gender = "Male" },
        new Bird { BirdId = 2,  Name = "Ernie", Breed = "Woodpecker", Age = 6, Gender = "Female" },
        new Bird { BirdId = 3,  Name = "Elmo", Breed = "Hawk", Age = 1, Gender = "Male" },
        new Bird { BirdId = 4,  Name = "Mator", Breed = "Red Robin", Age = 5, Gender = "Female" },
        new Bird { BirdId = 5,  Name = "Goofy", Breed = "Hummingbird", Age = 3, Gender = "Female" }
        );

      builder.Entity<Dog>()
      .HasData(
        new Dog { DogId = 1,  Name = "Nate", Breed = "Poodle", Age = 2, Gender = "Female" },
        new Dog { DogId = 2,  Name = "Chuck", Breed = "Bulldog", Age = 4, Gender = "Male" },
        new Dog { DogId = 3,  Name = "Vest", Breed = "Terrier", Age = 7, Gender = "Female" },
        new Dog { DogId = 4,  Name = "Nick", Breed = "Weiner", Age = 2, Gender = "Male" },
        new Dog { DogId = 5,  Name = "Larry", Breed = "Beagle", Age = 2, Gender = "Female" }
        );
      }
    }
  }
