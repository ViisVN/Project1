using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Player Controller


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * GetComponent<PlayerStats>().speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * GetComponent<PlayerStats>().speed;
        transform.Translate(x, y, 0);


    }
}
