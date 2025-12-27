using PokemonRPG.Models.Players;
using PokemonRPG.Repositories;

namespace PokemonRPG;
public class Program
{
    public static void Main(string[] args)
    {
        var battleManager = new Battlefield.BattleManager();

        var player1 = new COMPlayer("AI Player 1");
        var player2 = new COMPlayer("AI Player 2");

        var monsterRepo = new BattleMonsterRepository();
        var moveRepository = new BattleMoveRepository();

        var tackle = moveRepository.Get(2);
        var ember = moveRepository.Get(3);

        var bulbasaur = monsterRepo.Get(1);
        bulbasaur?.MoveList.Add(tackle);
        bulbasaur?.MoveList.Add(ember);

        var charmander = monsterRepo.Get(2);
        charmander?.MoveList.Add(ember);
        charmander?.MoveList.Add(tackle);

        player1.Party = new List<Models.Monsters.BattleMonster>
        {
            // add bulbasaur
            bulbasaur
        };

        player2.Party = new List<Models.Monsters.BattleMonster>
        {
            // add charmander
            charmander
        };

        battleManager.StartBattle(player1, player2);
    }
}

        
