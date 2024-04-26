using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private MovementController mController;

    private Vector3 direction;
    public float health;

    private void Update()
    {
        if(health <= 0)
        {
            mController.enabled = false;
            
            rb.velocity = Vector3.zero;
            rb.constraints = RigidbodyConstraints.None;
            direction.y -= 0.5f;
            rb.AddForce(direction * 0.2f, ForceMode.Impulse);
            return;
        }
    }

    public void Damage(float amount, Vector3 direction)
    {
        health -= amount;
        this.direction = direction;
    }
}
