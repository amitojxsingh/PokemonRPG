namespace PokemonRPG.Models;

public abstract class BaseMonster
{
    /// <summary>
    ///  Pokemon Number
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Pokemon Type
    /// </summary>
    public MonsterType Type { get; set; }

    /// <summary>
    /// Pokemon Name
    /// </summary>
    public required string Name { get; set; }

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
}
