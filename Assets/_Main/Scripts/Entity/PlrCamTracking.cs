using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrCamTracking : MonoBehaviour
{
    [SerializeField] private GameObject camObj;
    [SerializeField] private GameObject graphicsObj;
    [SerializeField] private float smoothing;

    // Update is called once per frame
    void Update()
    {
        camObj.transform.position = new Vector3(Mathf.Lerp(camObj.transform.position.x, graphicsObj.transform.position.x, smoothing), camObj.transform.position.y, Mathf.Lerp(camObj.transform.position.z, graphicsObj.transform.position.z, smoothing)) ;
    }
}
