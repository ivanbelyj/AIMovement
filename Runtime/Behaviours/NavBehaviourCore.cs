using Mirror;
using UnityEngine;

public abstract class NavBehaviourCore : MoveBehaviour
{
    protected NavManagerCore navManager;

    public Vector3 CurrentDestination { get; set; }

    protected override void Awake()
    {
        base.Awake();
        navManager = FindAnyObjectByType<NavManagerCore>();
    }

    protected abstract Vector3 GetTargetPosition();

    [Server]
    protected override AISteering GetSteering()
    {
        TargetPosition = GetTargetPosition();

        AISteering steering = new AISteering();
        steering.Linear = TargetPosition - transform.position;
        steering.Linear.Normalize();
        // steering.Linear *= agent.MaxAcceleration;
        return steering;
    }
}
