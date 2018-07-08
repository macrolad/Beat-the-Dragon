using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightStates : StateMachineBehaviour
{
    public virtual void ExitState(Knight knight, KnightStates state)
    {
        knight.KnightState = state;
    }

    //public delegate void OnStateEnter();
    //public delegate void OnStateStay();
    //public delegate void OnStateExit();
    public delegate void OnHit();
    public delegate void OnGetHit(/*DragonState*/);
    public delegate void OnDeath(/*DragonState*/);
}
