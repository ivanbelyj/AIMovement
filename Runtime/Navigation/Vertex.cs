using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vertex : MonoBehaviour // Todo: don't use monobehaviour ?
{
    public int Id { get; set; }
    public List<Edge> Neighbours { get; set; }
    public Vertex Prev { get; set; }
}
