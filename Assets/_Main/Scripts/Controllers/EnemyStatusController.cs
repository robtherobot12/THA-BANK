using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusController : MonoBehaviour
{
    public int DeadEnemies;
    [SerializeField] private HealthController[] enemyHealthControllers;

    // Update is called once per frame
    void Update()
    {
        int deadEnemyCounter = 0;
        foreach (HealthController controller in enemyHealthControllers)
        {
            if (controller.health <= 0) deadEnemyCounter++;
        }
        DeadEnemies = deadEnemyCounter;
    }
}
