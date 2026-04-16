using System.Collections.Generic;
using UnityEngine;

public class TransferMarket : MonoBehaviour
{
    public TeamManager teamManager;
    public List<Player> availablePlayers = new List<Player>();

    void Start()
    {
        GenerateMarketPlayers();
    }

    void GenerateMarketPlayers()
    {
        availablePlayers.Add(new Player("Elite Forward", "ST", 91, 92, 94, 80, 90, 45, 86, 60000000, true));
        availablePlayers.Add(new Player("Wing Wizard", "LW", 87, 93, 85, 82, 88, 50, 83, 30000000, false));
        availablePlayers.Add(new Player("Defensive Rock", "CB", 89, 72, 55, 70, 65, 92, 88, 40000000, true));
        availablePlayers.Add(new Player("Playmaker", "CAM", 90, 85, 88, 92, 91, 55, 84, 45000000, true));
    }

    public bool BuyPlayer(Player player)
    {
        if (teamManager.budget >= player.value)
        {
            teamManager.budget -= player.value;
            teamManager.squad.Add(player);
            availablePlayers.Remove(player);
            Debug.Log("Bought: " + player.playerName);
            return true;
        }
        else
        {
            Debug.Log("Not enough budget!");
            return false;
        }
    }

    public void SellPlayer(Player player)
    {
        if (teamManager.squad.Contains(player))
        {
            teamManager.budget += player.value;
            teamManager.squad.Remove(player);
            availablePlayers.Add(player);
            Debug.Log("Sold: " + player.playerName);
        }
    }
}