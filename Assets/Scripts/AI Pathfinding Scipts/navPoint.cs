using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum navPointType { none, platform, leftEdge, rightEdge, solo};


public class navPoint : MonoBehaviour
{
    public Vector2 navCoordinates;
    public int platformIndex;
    public navPointType navType = navPointType.none;
    public GameObject[] navWalkLinks = new GameObject[2];
    public List<GameObject> navFallLinks;
    public List<GameObject> navJumpLinks;

    void Awake()
    {
        
    }
}
