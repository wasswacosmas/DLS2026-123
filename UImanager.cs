using UnityEngine;

public class UIManager : MonoBehaviour
{
    public FormationManager formationManager;
    public TeamManager teamManager;

    public void Set433()
    {
        formationManager.SetFormation("4-3-3");
    }

    public void Set442()
    {
        formationManager.SetFormation("4-4-2");
    }

    public void Set4231()
    {
        formationManager.SetFormation("4-2-3-1");
    }

    public void SaveGame()
    {
        SaveSystem.SaveTeam(teamManager);
    }

    public void LoadGame()
    {
        SaveSystem.LoadTeam(teamManager);
    }
}