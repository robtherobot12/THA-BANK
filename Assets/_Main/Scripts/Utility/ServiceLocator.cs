using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : MonoBehaviour
{
    public static ServiceLocator Instance { get; private set; }

    public GameManager GameManager { get; private set; }
    public UIManager UIManager { get; private set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

        GameManager = GetComponentInChildren<GameManager>();
        UIManager = GetComponentInChildren<UIManager>();
    }
}
