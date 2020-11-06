using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float MoveSpeed;
    Transform playerPosition;
    float Speed;
    State myState;

    private void Start()
    {
        myState = GetComponent<State>();
        Speed = MoveSpeed;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        SetCurrentSpeed();
        Move();
    }

    void SetCurrentSpeed()
    {
        switch (myState.GetEntetyState())
        {
            case state.IDLE:
                Speed = 0;
                break;
            case state.RUNOVER:
                Speed = MoveSpeed;
                break;
            case state.COMBAT:
                Speed = 0;
                break;
            case state.RUNOFF:
                Speed = -MoveSpeed;
                break;
        }
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, Speed);
    }
}
