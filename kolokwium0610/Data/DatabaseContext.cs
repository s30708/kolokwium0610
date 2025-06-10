using kolokwium0610.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium0610.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Map> Maps { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Tournament> Tournament { get; set; }
    public DbSet<Player_Match> PlayerMatches { get; set; }

    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Map>().HasData(new List<Map>()
        {
            new Map() { MapId = 1, Name = "Map 1", Type = "stadion" },
            new Map() { MapId = 2, Name = "Map 2", Type = "boisko" },
            new Map() { MapId = 3, Name = "Map 3", Type = "stadion" },
        });
        modelBuilder.Entity<Match>().HasData(new List<Match>()
        {
            new Match()
            {
                MatchId = 1, TournamentId = 1, MapId = 1, MatchDate = DateTime.Now, Team1Score = 1, Team2Score = 2,
                BestRating = 2.4
            },
            new Match()
            {
                MatchId = 2, TournamentId = 2, MapId = 1, MatchDate = DateTime.Now, Team1Score = 2, Team2Score = 2,
                BestRating = 1.4
            },
            new Match()
            {
                MatchId = 3, TournamentId = 2, MapId = 3, MatchDate = DateTime.Now, Team1Score = 3, Team2Score = 4,
                BestRating = 2.8
            },

        });
        modelBuilder.Entity<Player>().HasData(new List<Player>()
        {
            new Player() { PlayerId = 1, FirstName = "jan", LastName = "kwoal", BirthDate = DateTime.Now },
            new Player() { PlayerId = 2, FirstName = "jasdfan", LastName = "kgdfwoal", BirthDate = DateTime.Now },
            new Player() { PlayerId = 3, FirstName = "sdf", LastName = "asd", BirthDate = DateTime.Now },

        });
        modelBuilder.Entity<Tournament>().HasData(new List<Tournament>()
        {
            new Tournament()
                { TournamentId = 1, Name = "mistrzostwa1", StartDate = DateTime.Now, EndDate = DateTime.Now },
            new Tournament()
                { TournamentId = 2, Name = "mistrzostwa2", StartDate = DateTime.Now, EndDate = DateTime.Now },
            new Tournament()
                { TournamentId = 3, Name = "mistrzostwa3", StartDate = DateTime.Now, EndDate = DateTime.Now },

        });

        modelBuilder.Entity<Player_Match>().HasData(new List<Player_Match>()
        {
            new Player_Match() { MatchId = 1, PlayerId = 1, MVPs = 8, Rating = 2.8 },
            new Player_Match() { MatchId = 2, PlayerId = 2, MVPs = 4, Rating = 3.8 },
            new Player_Match() { MatchId = 3, PlayerId = 3, MVPs = 32, Rating = 5.8 },


        });
    }
}


