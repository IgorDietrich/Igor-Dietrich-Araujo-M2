using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    state ActuaState = state.IDLE;

    public void ChangeState(state newState)
    {
        if (newState == ActuaState)
            return;

        ActuaState = newState;
        Debug.Log(ActuaState.ToString());
    }

    public state GetEntetyState() => ActuaState;
}

public enum state { IDLE, COMBAT, RUNOVER, RUNOFF };
