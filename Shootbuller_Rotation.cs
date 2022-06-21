using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootbuller_Rotation : MonoBehaviour
{
    //Bullet shoot
    public GameObject bullet;
    public float bulletspeed = 10;

    //Bullet roation
    public Transform firepoint;
    Vector2 lookdirection;
    float lookAngle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bullet rotation
        lookdirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg;

        firepoint.rotation = Quaternion.Euler(0, 0, lookAngle);

        if(Input.GetMouseButton(0))
        {           
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = firepoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = firepoint.right * bulletspeed;
        }
    }
       void OntriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);

    }
}
