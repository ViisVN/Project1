using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootbullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletVelocity = 5f;
    public GameObject bullet;
    public GameObject bullet1;

    float lookAngle;
    Vector2 lookdirection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookAngle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg;
        lookdirection = Camera.main.WorldToScreenPoint(Input.mousePosition);


        if (Input.GetButtonDown("Fire1"))
            {
                Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 direction = (Vector2)((worldMousePos - transform.position));
                direction.Normalize();
                // Creates the bullet locally
                GameObject bullet = (GameObject)Instantiate(
                                        bullet1,
                                        transform.position + (Vector3)(direction * 0.5f),
                                        Quaternion.identity);
            bullet.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
            // Adds velocity to the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
            }
        }
         void OntriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Enemy"))
        {

            Destroy(gameObject);
        }

    }
    }

