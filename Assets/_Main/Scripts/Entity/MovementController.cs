using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float Speed = 250f;
    [SerializeField] private Rigidbody objToMove;

    internal Vector3 MoveVector;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 moveVec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        objToMove.velocity = MoveVector.normalized * Time.deltaTime * Speed;
    }
}
