using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public int num { get; private set; } = 0;
    [SerializeField] private TMP_Text numberText;

    private void Update()
    {
        numberText.text = num.ToString();
    }

    public void upValue()
    {
        if (num < 9) num++;
        else num = 0;
    }

    public void downValue()
    {
        if (num > 0) num--;
        else num = 9;
    }
}
