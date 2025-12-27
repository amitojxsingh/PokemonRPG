using System;
using System.Collections.Generic;
using System.Text;
namespace PokemonRPG.Models.Players;

public abstract class BasePlayer
{
    public string Username { get; set; }

    /// <summary>
    ///  Current party of Pokemons, Max of 6 and needs controls/restrictions
    /// for swapping new with existing ones.
    /// </summary>
    public virtual IList<Monsters.BattleMonster> Party { get; set; }

    public virtual string ListParty()
    {
        if (Party == null)
                return "No monsters!";
        var sb = new StringBuilder();
        foreach(var monster in Party)
        {
            sb.Append($"{monster.Name}");
        }
        return sb.ToString();
    }
        
}
