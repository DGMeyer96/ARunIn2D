using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour
{
    RaycastHit2D hit;

    [SerializeField]
    Vector2 targetDest;

    [SerializeField]
    Vector2 nextMoveDest;

    public float distanceToPoint;

    float timerToBegin = 1f;
    bool isPathing = false;
    [SerializeField]
    List<Vector2> pathPoints;
    public bool isGoingRight = false;

    // Update is called once per frame
    void Update()
    {
        timerToBegin -= Time.deltaTime;
        if (timerToBegin >= 0f && isPathing == false)
        {
            GetFirstPoint();
        }
    }


    void GetFirstPoint()
    {
        if (isGoingRight == true)
        {
            Vector2 start = new Vector2(transform.position.x + 0.51f, transform.position.y - 0.25f);
            hit = Physics2D.Raycast(start, -Vector2.right, 3f);
            if (hit.transform.gameObject.GetComponent<navPoint>())
            {
                nextMoveDest = hit.transform.gameObject.GetComponent<navPoint>().navCoordinates;
                StartPath(hit.transform.gameObject);
            }

        }
        else
        {
            Vector2 start = new Vector2(transform.position.x - 0.51f, transform.position.y - 0.25f);
            hit = Physics2D.Raycast(start, -Vector2.right, 3f);
            if (hit.transform.gameObject.GetComponent<navPoint>())
            {
                nextMoveDest = hit.transform.gameObject.GetComponent<navPoint>().navCoordinates;
                StartPath(hit.transform.gameObject);
            }
        }
    }

    void StartPath(GameObject thisPosition)
    {
        if(isGoingRight == false)
        {
            GameObject nextPoint = thisPosition.GetComponent<navPoint>().navWalkLinks[0];
            if (nextPoint.GetComponent<navPoint>())
                pathPoints.Add(nextPoint.GetComponent<navPoint>().navCoordinates);
            if(Vector2.Distance(nextPoint.GetComponent<navPoint>().navCoordinates, targetDest) <= 0.25f)
            {
                return;
            }
            else
            {
                StartPath(thisPosition.GetComponent<navPoint>().navWalkLinks[0]);
            }
        }
        else
        {
            GameObject nextPoint = thisPosition.GetComponent<navPoint>().navWalkLinks[1];
            if (nextPoint.GetComponent<navPoint>())
                pathPoints.Add(nextPoint.GetComponent<navPoint>().navCoordinates);
            if (Vector2.Distance(nextPoint.GetComponent<navPoint>().navCoordinates, targetDest) <= 0.25f)
            {
                return;
            }
            else
            {
                StartPath(thisPosition.GetComponent<navPoint>().navWalkLinks[1]);
            }
        }
    }

    public List<Vector2> GetPath()
    {
        return pathPoints;
    }
}
