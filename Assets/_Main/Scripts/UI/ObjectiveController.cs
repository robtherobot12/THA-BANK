using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveController : MonoBehaviour
{
    [SerializeField] private TMP_Text objectiveText;
    private string objName;
    private string current;
    private string max;

    private void Update()
    {
        objectiveText.text = $"{objName} ({current}/{max}) •";
    }

    public void SetObjective(string name, int current, int max)
    {
        this.objName = name;
        this.current = current.ToString();
        this.max = max.ToString();
    }

    public void UpdateObjective(int current)
    {
        this.current = current.ToString();
    }
}
