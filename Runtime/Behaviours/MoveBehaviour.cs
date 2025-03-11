using Mirror;
using UnityEngine;

[RequireComponent(typeof(MoveAgent))]
public class MoveBehaviour : NetworkBehaviour
{
    [SerializeField]
    private Vector3 targetPosition;
    protected MoveAgent agent;
    
    public Vector3 TargetPosition
    {
        get => targetPosition;
        set => targetPosition = value;
    }

    protected virtual void Awake() {
        agent = GetComponent<MoveAgent>();
    }

    protected virtual void Update() {
        if (isServer) {
            agent.SetSteering(GetSteering());
        }
    }

    [Server]
    protected virtual AISteering GetSteering() {
        return new AISteering();
    }
}
