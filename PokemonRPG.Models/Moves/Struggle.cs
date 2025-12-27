using System;

namespace PokemonRPG.Models.Moves;

public class Struggle : BattleMove   
{
    public Struggle() : base(
        id: 1,
        name: "Struggle",
        type: MonsterType.Normal,
        maxPP: -1,
        currentPP: -1,
        description: "A desperate attack that can be used only if the user has no PP left for any move. It also hurts the user a little.",
        power: 10,
        accuracy: 100)
    {
    }
}
