using System.Reflection;
using PokemonRPG.Models.Moves;
using System.Diagnostics.CodeAnalysis;

namespace PokemonRPG.Models.Monsters;

public class BattleMonster : IIdentifiable
{
    /// <summary>
    ///  Pokemon Number
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Experience Level
    /// </summary>
    public int Level { get; set; } = 1;

    /// <summary>
    /// Pokemon Type
    /// </summary>
    public MonsterType Type { get; set; }

    /// <summary>
    /// Pokemon Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Hit Points
    /// </summary>
    public int HP { get; set; }

    /// <summary>
    /// Attack stat ( physical and special )
    /// </summary>
    public int Attack { get; set; }
    /// <summary>
    /// Defense Points ( physical and special )
    /// </summary>
    public int Defense { get; set; }
    /// <summary>
    /// Speed Points
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// Up to four moves a monster can learn
    /// </summary>
    /// -- TODO: Add controls/restrictions for learning new moves
    /// -- NOTE: when learning 5th move, existing move (1 of 4) must be forgotten 
    public virtual IList<BattleMove> MoveList { get; set; }
    
    [SetsRequiredMembers]
    public BattleMonster(int id, string name, MonsterType type, int hp, int attack, int defense, int speed, IList<BattleMove>? moveList)
    {
        Id = id;
        Type = type;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        HP = hp;
        Attack = attack;
        Defense = defense;
        Speed = speed;
        if (moveList == null || moveList.Count == 0)
            moveList = new List<BattleMove> { new Struggle() };
        MoveList = moveList;
    }

}
