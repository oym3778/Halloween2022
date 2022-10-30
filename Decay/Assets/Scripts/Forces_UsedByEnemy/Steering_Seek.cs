using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering_Seek : Agent
{
    Vector3 seekerForce = Vector3.zero;

    public GameObject target;

    protected override void CalcSteeringForces()
    {
        Vector3 targetPos = target.transform.position;
        seekerForce = Seek(targetPos);

        totalSteeringForce += seekerForce;
    }

}
