using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrAiming : MonoBehaviour
{
    [SerializeField] private GameObject graphics;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);
        mousePosWorld.y = graphics.transform.position.y;

        graphics.transform.LookAt(mousePosWorld, Vector3.up);
    }
}
