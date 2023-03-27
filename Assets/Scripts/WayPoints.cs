using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform GetWaypoint(int waypointIndex)
    {
        return transform.GetChild(waypointIndex);
    }

    // Update is called once per frame
    public int GetNextWaypointIndex(int currentWaypointIndex)
    {
        int nextWaypointIndex = currentWaypointIndex + 1;

        if (nextWaypointIndex == transform.childCount)
        {
            nextWaypointIndex = 0;
        }

        return nextWaypointIndex;
    }


}
