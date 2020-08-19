using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileTest : MonoBehaviour
{

    public Tilemap map;

    public GameObject tileNav;

    int actualPlatformIndex = 0;
    bool platformStarted = false;

    GameObject[,] navPoints;
    int ColumnLength, RowLength;

    // Start is called before the first frame update
    void Start()
    {
        BoundsInt bounds = map.cellBounds;
        TileBase[] allTiles = map.GetTilesBlock(bounds);
        GridLayout grid = GetComponent<GridLayout>();
        int count = 0;
        navPoints = new GameObject[bounds.size.x, bounds.size.y];
        RowLength = bounds.size.x - 1;
        ColumnLength = bounds.size.y - 1;

        
        ///Creates navpoints from all empty tiles that are abouve a filled tile
        ///if it on the left = leftEdge, middle = platform, right = right edge, on its own = solo, not a nav poitn = none
        for (int y = 0; y < bounds.size.y; y++)
        {
            platformStarted = false;

            for (int x = 0; x < bounds.size.x; x++)
            {
                TileBase tile = allTiles[x + y * bounds.size.x];

                if (tile == null && y!=0 && x != bounds.size.x - 1)
                {
                    TileBase rightTile = allTiles[(x + 1) + y * bounds.size.x];
                    TileBase underTile = allTiles[x + (y - 1) * bounds.size.x];
                    TileBase rightLower = allTiles[(x + 1) + (y - 1) * bounds.size.x];
                    if (underTile != null)
                    {
                        map.GetTile(new Vector3Int(x, y, 0));
                        GameObject copy = Instantiate(tileNav, grid.CellToLocal(new Vector3Int(x, y, 0)) - new Vector3(10f, 5f, 0), Quaternion.identity);
                        //GameObject copy = Instantiate(tileNav, grid.WorldToCell(cellPos), Quaternion.identity);
                        //copy.transform.position = map.GetCellCenterWorld(new Vector3Int(x,y,0));
                        navPoints[x,y] = copy;
                        count++;
                        navPoint copyNav = copy.GetComponent<navPoint>();
                        copyNav.navCoordinates = copy.transform.position;
                        if(platformStarted == false)
                        {
                            copyNav.navType = navPointType.leftEdge;
                            copyNav.platformIndex = actualPlatformIndex;
                            platformStarted = true;
                            actualPlatformIndex++;
                        }
                        else if(platformStarted)
                        {
                            if(rightLower && rightTile == null && copyNav.navType != navPointType.leftEdge)
                            {
                                copyNav.navType = navPointType.platform;
                                copyNav.platformIndex = actualPlatformIndex;
                            }

                            if(rightLower == null || rightTile != null)
                            {
                                if(copyNav.navType == navPointType.leftEdge)
                                {
                                    copyNav.navType = navPointType.solo;
                                }
                                else
                                {
                                    copyNav.navType = navPointType.rightEdge;
                                }

                                platformStarted = false;
                            }
                        }

                    }

                }

            }
        }

        ///Creates left and right navLinks for walking
        for(int i = 0; i < ColumnLength; i++)
        {
            for(int j = 0; j < RowLength; j++)
            {
                if(navPoints[j,i])
                {
                    
                    if (navPoints[j, i].GetComponent<navPoint>().navType != navPointType.none && j <= 21)
                    {
                        
                        if (j != 0)
                        {
                            //Adds right links to the nav links
                            if (navPoints[j + 1, i] != null && navPoints[j + 1, i].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksRight.Add(navPoints[j + 1, i]);
                                
                            }
                            //Adds the next upward diagoanl right link
                            if (navPoints[j + 1, i + 1] != null && navPoints[j + 1, i + 1].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksRight.Add(navPoints[j + 1, i + 1]);

                            }
                            //Adds the next upward diagoanl right link
                            if (navPoints[j + 1, i + 2] != null && navPoints[j + 1, i + 2].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksRight.Add(navPoints[j + 1, i + 2]);

                            }
                            //Adds the next upward diagoanl right link
                            if (navPoints[j + 1, i - 2] != null && navPoints[j + 1, i - 2].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksRight.Add(navPoints[j + 1, i - 2]);

                            }
                            //Adds the next upward diagoanl right link
                            if (navPoints[j + 1, i - 1] != null && navPoints[j + 1, i - 1].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksRight.Add(navPoints[j + 1, i - 1]);

                            }


                            //Adds left links to the nav links
                            if (navPoints[j - 1, i] != null && navPoints[j - 1, i].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksLeft.Add(navPoints[j - 1, i]);
                            }
                            //Adds the next upward diagoanl left link
                            if (navPoints[j - 1, i + 1] != null && navPoints[j - 1, i + 1].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksLeft.Add(navPoints[j - 1, i + 1]);
                            }
                            //Adds the next upward diagoanl left link
                            if (navPoints[j - 1, i + 2] != null && navPoints[j - 1, i + 2].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksLeft.Add(navPoints[j - 1, i + 2]);
                            }
                            //adds the next downward diagonal left link
                            if (navPoints[j - 1, i - 1] != null && navPoints[j - 1, i - 1].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksLeft.Add(navPoints[j - 1, i - 1]);
                            }
                            //adds the next downward diagonal left link
                            if (navPoints[j - 1, i - 2] != null && navPoints[j - 1, i - 2].GetComponent<navPoint>().navType != navPointType.none)
                            {
                                navPoints[j, i].GetComponent<navPoint>().navLinksLeft.Add(navPoints[j - 1, i - 2]);
                            }
                        }
                    }
                }
            }
        }
    }

}
