using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjLeave : MonoBehaviour, I_Objective
{
    public string objectiveName { get; set; } = "Open the vault.";
    public int completionMax { get; set; } = 1;
    public int completionAmount { get; set; } = 0;
    public bool completed { get; set; } = false;
    public UnityEvent completedEvent { get; set; }

    [SerializeField] private TriggerController triggerController;

    private void Start()
    {
        completedEvent = new();
        DisableObjective();
    }

    private void Update()
    {
        
    }

    public void DisableObjective()
    {
        triggerController.enabled = false;
    }
    public void EnableObjective()
    {
        triggerController.enabled = true;
    }
}
