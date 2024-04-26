using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameController : MonoBehaviour
{
    public bool Unlocked = false;
    [SerializeField] private NumberController[] numberControllers;
    [SerializeField] private string password;
    [SerializeField] private Image lockImage;
    [SerializeField] private Color unlockedColor;

    private void Update()
    {
        string pass = string.Empty;
        foreach (var controller in numberControllers)
        {
            pass += controller.num.ToString();
        }
        if (pass == password)
        {
            Unlocked = true;
            lockImage.color = unlockedColor;
        }
    }
}
