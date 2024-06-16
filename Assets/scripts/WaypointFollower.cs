using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypoint = 0;

    [SerializeField] private float speed = 3f;
    
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 0.1f)
        {
            currentWaypoint++;
            if (currentWaypoint >= waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, speed * Time.deltaTime);
    }
}
