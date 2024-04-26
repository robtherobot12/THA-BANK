using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementController))]
public class NpcContr : MonoBehaviour
{
    [SerializeField] private float wanderSpeed;
    [SerializeField] private float wanderDelay;
    [Space]
    [SerializeField] private float panicSpeed;
    [SerializeField] private float panicDelay;
    [Space]
    [SerializeField] private float randomOffset;

    [SerializeField] private MovementController mController;
    [SerializeField] private LayerMask envMask;
    [SerializeField] private float wallCheckDistance;

    private float currentDelay;
    private float currentSpeed;

    void Awake()
    {
        Wander();
        StartCoroutine(wanderCoroutine());
    }

    public void Wander()
    {
        currentDelay = wanderDelay;
        currentSpeed = wanderSpeed;
    }

    public void Panic()
    {
        currentSpeed = panicSpeed;
        currentDelay = panicDelay;
    }

    Vector3 CheckObstacles()
    {
        Vector3 moveVector;

        while (true)
        {
            moveVector = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
            
            if(!Physics.Raycast(transform.position, moveVector, 5f, envMask))
            {
                break;
            }
        }

        return moveVector;
    }

    IEnumerator wanderCoroutine()
    {
        yield return new WaitForSeconds(Random.Range(0f, 3f));
        mController.Speed = currentSpeed;
        while(true)
        {
            currentDelay += Random.Range(-randomOffset, randomOffset);
            currentSpeed += Random.Range(-randomOffset, randomOffset) * 10;

            
            mController.MoveVector = CheckObstacles();
            yield return new WaitForSeconds(currentDelay);
            mController.MoveVector = Vector3.zero;
            yield return new WaitForSeconds(currentDelay);
        }
    }
}
