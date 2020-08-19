using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum navPointType { none, platform, leftEdge, rightEdge, solo};


public class navPoint : MonoBehaviour
{
    public Vector2 navCoordinates;
    public int platformIndex;
    public navPointType navType = navPointType.none;


    public List<GameObject> navLinksLeft;
    public List<GameObject> navLinksRight;

}
