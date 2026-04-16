using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static string path = Application.persistentDataPath + "/teamData.json";

    public static void SaveTeam(TeamManager teamManager)
    {
        string json = JsonUtility.ToJson(teamManager, true);
        File.WriteAllText(path, json);
        Debug.Log("Team data saved to: " + path);
    }

    public static void LoadTeam(TeamManager teamManager)
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            JsonUtility.FromJsonOverwrite(json, teamManager);
            Debug.Log("Team data loaded.");
        }
        else
        {
            Debug.Log("No save file found.");
        }
    }
}