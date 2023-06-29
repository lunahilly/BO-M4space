using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Enemy;
    [SerializeField] GameObject door;
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    [SerializeField] float speed = 1f;
    [SerializeField] int enemies;
    void Start()
    {
        Enemy = enemies;
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorOpening.Enemy == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
        }
    }
}
