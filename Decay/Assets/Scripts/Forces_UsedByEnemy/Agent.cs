using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsObject))]
public abstract class Agent : MonoBehaviour
{
    [SerializeField] private PhysicsObject physObj;

    protected Vector3 totalSteeringForce;

    [SerializeField] float maxSpeed = 1f;
    [SerializeField] float maxForce = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        physObj = GetComponent<PhysicsObject>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        CalcSteeringForces();

        totalSteeringForce = Vector3.ClampMagnitude(totalSteeringForce, maxForce);

        physObj.ApplyForce(totalSteeringForce);

        totalSteeringForce = Vector3.zero;
    }

    protected abstract void CalcSteeringForces();

    protected Vector3 Seek(Vector3 targetPos)
    {
        Vector3 desiredVelocity = targetPos - physObj.Position;
        desiredVelocity = desiredVelocity.normalized * maxSpeed;
        Vector3 seekForce =  desiredVelocity - physObj.Velocity;

        return seekForce;
    }
    protected Vector3 Flee(Vector3 targetPos)
    {
        Vector3 desiredVelocity = physObj.Position - targetPos;
        desiredVelocity = desiredVelocity.normalized * maxSpeed;
        Vector3 fleeForce = desiredVelocity - physObj.Velocity;

        return fleeForce;
    }
}
