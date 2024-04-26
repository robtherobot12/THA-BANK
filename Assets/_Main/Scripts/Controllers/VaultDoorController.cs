using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerController))]
public class VaultDoorController : MonoBehaviour
{
    public bool opened { get; private set; } = false;
    [SerializeField] private Transform rotationPoint;
    [SerializeField] private Vector3 openedRotation;

    public void UnlockVault()
    {
        opened = true;
        ServiceLocator.Instance.UIManager.HideView();
        rotationPoint.rotation = Quaternion.Euler(openedRotation);
    }

    public void Enter()
    {
        if (opened) return;
        ServiceLocator.Instance.UIManager.ShowView();
    }

    public void Exit()
    {
        ServiceLocator.Instance.UIManager.HideView();
    }
}
