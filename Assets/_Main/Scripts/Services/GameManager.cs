using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<I_Objective> objectives = new();
    private int currentObjectiveIndex = -1;

    private void Start()
    {
        foreach(Transform t in transform.GetComponentInChildren<Transform>())
        {
            objectives.Add(t.GetComponent<I_Objective>());
        }

        NextObjective();
        foreach(var objective in objectives)
        {
            objective?.completedEvent.AddListener(NextObjective);
        }
        
    }

    private void Update()
    {
        ServiceLocator.Instance.UIManager.UpdateObjective(objectives[currentObjectiveIndex].completionAmount);
    }

    private void NextObjective()
    {
        if (currentObjectiveIndex >= objectives.Count - 1)
        {
            return;
        }
        currentObjectiveIndex++;
        objectives[currentObjectiveIndex].EnableObjective();
        ServiceLocator.Instance.UIManager.SetObjective(objectives[currentObjectiveIndex]);
    }
}
