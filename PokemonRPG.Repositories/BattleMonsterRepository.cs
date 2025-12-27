using System;
using PokemonRPG.Models.Monsters;

namespace PokemonRPG.Repositories;

public class BattleMonsterRepository : BaseRepository<BattleMonster>
{
    protected override List<BattleMonster> _items { get; } = new List<BattleMonster>()
    {
        new BattleMonster(1, "Bulbasaur", Models.MonsterType.Grass, 45, 49, 49, 45, null),
        new BattleMonster(2, "Charmander", Models.MonsterType.Fire, 39, 52, 43, 65, null),
        new BattleMonster(3, "Squirtle", Models.MonsterType.Water, 44, 48, 65, 43, null),
    };
}
