using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Use arrow key to move object
        var movementx = Input.GetAxis("Horizontal");
        var movementy = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementx * Time.deltaTime * speed, movementy * Time.deltaTime * speed, 0) ;

    }
}
