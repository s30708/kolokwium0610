using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium0610.Models;


[Table("Match")]
public class Match
{
    [Key] public int MatchId { get; set; }
    
    [ForeignKey(nameof(Tournament))]
    public int TournamentId { get; set; }
    
    [ForeignKey(nameof(Map))]
    public int MapId { get; set; }

    public DateTime MatchDate { get; set; }
    
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(4, 2)]
    public double? BestRating { get; set; }
    
    
    public ICollection<Player_Match> Player_Matches { get; set; }
    
    public Tournament Tournament { get; set; }
    public Map Map { get; set; }
    
}