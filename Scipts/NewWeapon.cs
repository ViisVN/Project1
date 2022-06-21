using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeapon : MonoBehaviour
{


    public GameObject pickupEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }
    void Pickup(Collider2D player)
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);


        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

        Destroy(gameObject);
    }
}
