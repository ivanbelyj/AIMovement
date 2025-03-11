using UnityEngine;

public abstract class NavManagerCore : MonoBehaviour
{
    protected GridGraph graph;

    public GridGraph Graph {
        get {
            if (graph == null) {
                Debug.LogError($"{nameof(Graph)} was not initialized in {nameof(NavManagerCore)} ");
            }
            return graph;
        }
        protected set {
            graph = value;
        }
    }
}
