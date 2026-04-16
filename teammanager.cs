using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour
{
    public string teamName = "Wasswa FC";
    public int budget = 100000000; // Starting budget
    public List<Player> squad = new List<Player>();
    public List<Player> startingEleven = new List<Player>();

    void Start()
    {
        InitializeTeam();
    }

    void InitializeTeam()
    {
        squad.Add(new Player("Wasswa Striker", "ST", 92, 90, 95, 85, 93, 40, 88, 50000000, true));
        squad.Add(new Player("Creative Midfielder", "CM", 88, 80, 82, 90, 87, 60, 85, 35000000, true));
        squad.Add(new Player("Solid Defender", "CB", 85, 70, 50, 65, 60, 90, 84, 25000000, false));
        squad.Add(new Player("Fast Winger", "RW", 86, 93, 80, 78, 88, 45, 82, 30000000, false));
        squad.Add(new Player("Reliable Goalkeeper", "GK", 87, 60, 40, 65, 50, 88, 85, 28000000, false));

        SetDefaultLineup();
    }

    void SetDefaultLineup()
    {
        startingEleven.Clear();
        for (int i = 0; i < squad.Count && i < 11; i++)
        {
            startingEleven.Add(squad[i]);
        }
    }
}

