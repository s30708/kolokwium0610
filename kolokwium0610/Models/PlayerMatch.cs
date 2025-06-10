using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium0610.Models;

[PrimaryKey(nameof(MatchId), nameof(PlayerId))]
[Table("Player_Match")]
public class Player_Match
{
    [ForeignKey(nameof(MatchId))]
    public int MatchId { get; set; }
    
    [ForeignKey(nameof(PlayerId))]
    public int PlayerId { get; set; }
    public int MVPs { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(4, 2)]
    public double Rating { get; set; }
    
    
    public Player Player { get; set; }
    public Match Match { get; set; }
    
}