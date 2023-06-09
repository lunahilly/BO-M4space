 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAI : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    [SerializeField] float speed = 1f;
    [SerializeField] Animator animator;

    void Update()
    {
        moving();
    }
    // Update is called once per frame
    public void moving()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.2f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        if (currentWaypointIndex == 0) 
        {
            animator.SetTrigger("left");
        }
        if (currentWaypointIndex == 1)
        {
            animator.SetTrigger("right");
        }


        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
