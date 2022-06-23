using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Update()
    {
        var movementx = Input.GetAxis("Horizontal");
        var movementy = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementx * Time.deltaTime * GetComponent<PlayerStats>().speed, movementy * Time.deltaTime * GetComponent<PlayerStats>().speed, 0);
    }
}
