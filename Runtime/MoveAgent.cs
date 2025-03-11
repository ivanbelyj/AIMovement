using Mirror;
using UnityEngine;

[RequireComponent(typeof(IMoveControls))]
public class MoveAgent : NetworkBehaviour
{
    protected IMoveControls moveControls;

    [SyncVar]
    private AISteering steering = new AISteering();
    
    protected virtual void Awake() {
        moveControls = GetComponent<IMoveControls>();
    }

    protected virtual void Update() {
        moveControls.Move(steering.Linear.normalized);
    }

    [Server]
    public void SetSteering(AISteering steering) {
        this.steering = steering;
    }
}
