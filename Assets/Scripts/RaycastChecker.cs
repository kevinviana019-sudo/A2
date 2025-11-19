using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastChecker : MonoBehaviour
{
    public float distance = 2f;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, distance))
        {
            Debug.Log("Obstacle: " + hit.collider.name);
        }
    }
}
