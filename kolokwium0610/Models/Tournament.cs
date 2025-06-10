using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium0610.Models;

[Table("Tournament")]
public class Tournament
{
    [Key] 
    public int TournamentId { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public ICollection<Match> Matches { get; set; }
}