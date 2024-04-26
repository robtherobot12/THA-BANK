using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface I_Objective
{
    public string objectiveName { get; set; }
    public int completionMax { get; set; }
    public int completionAmount { get; set; }
    public bool completed { get; set; }
    
    public UnityEvent completedEvent { get; set; }
    public void DisableObjective();
    public void EnableObjective();
}

