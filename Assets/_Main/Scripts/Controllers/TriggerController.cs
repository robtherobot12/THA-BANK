using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerController : MonoBehaviour
{
    [SerializeField] private UnityEvent triggerEnter;
    [SerializeField] private UnityEvent triggerExit;
    [SerializeField] private string triggerTag;

    void OnTriggerEnter(Collider other)
    {
        if (!CheckIfValid(other)) return;
        triggerEnter?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!CheckIfValid(other)) return;
        triggerExit?.Invoke();
    }

    private bool CheckIfValid(Collider collider)
    {
        var rb = collider.GetComponent<Rigidbody>();
        if (rb)
        {
            var plrTransform = rb.gameObject.GetComponentInParent<Transform>().parent;
            if (plrTransform.tag == triggerTag)
            {
                return true;
            }
        }

        return false;
    }
}
