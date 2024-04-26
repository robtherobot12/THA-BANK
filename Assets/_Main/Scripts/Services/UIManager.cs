using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject minigameView;
    [SerializeField] private ObjectiveController objectiveController;

    public void ShowView()
    {
        minigameView.SetActive(true);
    }

    public void HideView()
    {
        minigameView.SetActive(false);
    }
    public void SetObjective(I_Objective obj)
    {
        objectiveController.SetObjective(obj.objectiveName, obj.completionAmount, obj.completionMax);
    }

    public void UpdateObjective(int amount)
    {
        objectiveController.UpdateObjective(amount);
    }
}
