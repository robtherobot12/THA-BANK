using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjOpenVault : MonoBehaviour, I_Objective
{
    public string objectiveName { get; set; } = "Open the vault.";
    public int completionMax { get; set; } = 1;
    public int completionAmount { get; set; } = 0;
    public bool completed { get; set; } = false;
    public UnityEvent completedEvent { get; set; }

    [SerializeField] private MinigameController minigame;
    [SerializeField] private VaultDoorController vaultDoorController;

    private void Start()
    {
        completedEvent = new();
        DisableObjective();
    }

    private void Update()
    {
        if(minigame.Unlocked)
        {
            completionAmount = 1;
            vaultDoorController.UnlockVault();
            completedEvent.Invoke();
            return;
        }
    }

    public void DisableObjective()
    {
        vaultDoorController.enabled = false;
    }
    public void EnableObjective()
    {
        vaultDoorController.enabled = true;
    }
}
