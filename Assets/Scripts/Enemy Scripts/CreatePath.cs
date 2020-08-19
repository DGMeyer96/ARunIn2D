using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour
{
    RaycastHit2D hit;

    [SerializeField]
    Transform targetDest;

    [SerializeField]
    Vector2 nextMoveDest;

    public float distanceToPoint;

    float timerToBegin = 0.05f;
    bool isPathing = false;
    [SerializeField]
    List<Vector2> pathPoints;

    List<Vector2> bestPath;
    public bool isGoingRight = false;

    IDictionary<Vector2, Vector2> nodeParents = new Dictionary<Vector2, Vector2>();

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
                Vector2 goal = FindShortestPathBFS(hit.transform.gameObject, targetDest.position);
                Debug.Log(goal);
                Debug.Log(hit.transform.gameObject.transform.position);
                StartPath(goal);
            }

        }
        else if(isGoingRight == false)
        {
            Vector2 start = new Vector2(transform.position.x - 0.51f, transform.position.y - 0.25f);
            hit = Physics2D.Raycast(start, -Vector2.right, 3f);
            if (hit.transform.gameObject.GetComponent<navPoint>())
            {
                nextMoveDest = hit.transform.gameObject.GetComponent<navPoint>().navCoordinates;
                Vector2 goal = FindShortestPathBFS(hit.transform.gameObject, targetDest.position);
                StartPath(goal);
            }
        }
        isPathing = true;
    }

    void StartPath(Vector2 goal)
    {
        if (goal == (Vector2)hit.transform.gameObject.transform.position)
        {
            Debug.Log("No path found");
            return;
        }

        Vector2 curr = goal;

        
        while (curr != (Vector2)hit.transform.gameObject.transform.localPosition)
        {
            pathPoints.Add(curr);
            curr = nodeParents[curr];
        }
        pathPoints.Reverse();
    }

    Vector2 FindShortestPathBFS(GameObject startPos, Vector2 endPos)
    {
        Queue<GameObject> frontier = new Queue<GameObject>();
        HashSet<GameObject> exploredNodes = new HashSet<GameObject>();
        frontier.Enqueue(startPos);

        while(frontier.Count != 0)
        {
            GameObject currentNode = frontier.Dequeue();
            if(Vector2.Distance(currentNode.GetComponent<navPoint>().navCoordinates, endPos) <= 0.5f)
            {
                Debug.Log("End found");
                return currentNode.GetComponent<navPoint>().navCoordinates;
            }

            if(isGoingRight)
            {
                foreach(GameObject node in currentNode.GetComponent<navPoint>().navLinksRight)
                {
                    if(!exploredNodes.Contains(node))
                    {
                        exploredNodes.Add(node);

                        nodeParents.Add(node.GetComponent<navPoint>().navCoordinates, currentNode.GetComponent<navPoint>().navCoordinates);

                        frontier.Enqueue(node);

                        //Debug.Log("Finding Path Right");
                    }
                }
            }
            else
            {
                foreach (GameObject node in currentNode.GetComponent<navPoint>().navLinksLeft)
                {
                    if (!exploredNodes.Contains(node))
                    {
                        exploredNodes.Add(node);

                        nodeParents.Add(node.GetComponent<navPoint>().navCoordinates, currentNode.GetComponent<navPoint>().navCoordinates);

                        frontier.Enqueue(node);

                        //Debug.Log("Finding Path Left");
                    }
                }
            }
        }

        return startPos.transform.position;
    }

    public List<Vector2> GetPath()
    {
        return pathPoints;
    }
}
