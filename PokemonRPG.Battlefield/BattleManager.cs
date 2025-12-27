using PokemonRPG.Models.Players;
using System;
namespace PokemonRPG.Battlefield;

public class BattleManager
{
    public BattleManager()
    {
        
    }
    public void StartBattle(BasePlayer player1, BasePlayer player2)
    {
        System.Console.WriteLine($"Battle started between {player1.Username} and {player2.Username}!"+
        $"\n\t{player1.Username} sent out {player1.ListParty()}!" +
        $"\n\t{player2.Username} sent out {player2.ListParty()}!");
        System.Console.ReadLine();
    }
}
