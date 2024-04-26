using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjClearFoyer : MonoBehaviour, I_Objective
{
    public string objectiveName { get; set; } = "Clear the foyer of enemies.";
    public int completionMax { get; set; } = 3;
    public int completionAmount { get; set; } = 0;
    public bool completed { get; set; } = false;
    public UnityEvent completedEvent { get ; set ; }

    [SerializeField] private EnemyStatusController enemyStatusController;

    private void Start()
    {
        completedEvent = new();
        DisableObjective();
    }

    private void Update()
    {
        int deadEnemies = enemyStatusController.DeadEnemies;
        completionAmount = deadEnemies;
        if(deadEnemies >= completionMax)
        {
            completedEvent?.Invoke();
            return;
        }
        
    }

    public void DisableObjective()
    {
        enemyStatusController.enabled = false;
    }
    public void EnableObjective()
    {
        enemyStatusController.enabled = true;
    }
}
