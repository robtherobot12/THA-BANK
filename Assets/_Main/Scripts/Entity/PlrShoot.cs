using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrShoot : MonoBehaviour
{
    [SerializeField] private Transform shootTransform;
    [SerializeField] private float damage;
    [SerializeField] private ParticleSystem tracer;
    [SerializeField] private LayerMask layerMask;

    public void Shoot()
    {
        tracer.Play();
        RaycastHit hit;
        if(Physics.Raycast(shootTransform.position, shootTransform.forward, out hit, Mathf.Infinity, layerMask))
        {
            try
            {
                HealthController health;
                health = hit.collider.gameObject.GetComponentInParent<HealthController>();
                health.Damage(damage, shootTransform.forward);
            }
            catch (System.Exception e)
            {

            }
        }
    }
}
