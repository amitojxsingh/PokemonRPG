using System;
using PokemonRPG.Models.Moves;


namespace PokemonRPG.Repositories;

public class BattleMoveRepository : BaseRepository<BattleMove>
{

    protected override List<BattleMove> _items { get; } = new List<BattleMove>
    {
        new Struggle(),
        new BattleMove(2, "Tackle", Models.MonsterType.Normal, 35, 35, "A physical attack in which the user charges and slams into the target with its whole body.", 40, 100),   
        new BattleMove(3, "Ember", Models.MonsterType.Fire, 25, 25, "A weak fire attack that may inflict a burn.", 40, 100),
    };

}
