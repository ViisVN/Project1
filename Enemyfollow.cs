using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : MonoBehaviour
{
    public float speed = 0;
    public Transform Main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = Main.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(Main.position, transform.position) > 1.0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);

        }
        else
        {
            //do whatever the enemy has to do with the player
        }
    }

    void OntriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Bullet"))
        {
            Destroy(hitInfo.gameObject);
        }

    }
}
