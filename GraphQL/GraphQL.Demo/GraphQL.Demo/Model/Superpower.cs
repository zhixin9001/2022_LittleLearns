using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.Demo.Model;

public class Superpower
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "The superpower is required")]
    public string SuperPower { get; set; }
    public string Description { get; set; }

    [ForeignKey("SuperheroId")]
    public Guid SuperheroId { get; seaaaaaaaaaaaaaaaaaaa
        t; }
    public Superhero Superhero { get; set; }
}