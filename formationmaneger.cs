using UnityEngine;

public class FormationManager : MonoBehaviour
{
    public string currentFormation = "4-3-3";

    public void SetFormation(string formation)
    {
        currentFormation = formation;
        Debug.Log("Formation set to: " + currentFormation);
    }

    public int[] GetFormationLayout()
    {
        switch (currentFormation)
        {
            case "4-4-2":
                return new int[] { 4, 4, 2 };
            case "4-2-3-1":
                return new int[] { 4, 2, 3, 1 };
            case "3-5-2":
                return new int[] { 3, 5, 2 };
            case "5-3-2":
                return new int[] { 5, 3, 2 };
            default:
                return new int[] { 4, 3, 3 };
        }
    }
}