using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour
{
    public int damage = 10;

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
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.damage += damage;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

        Destroy(gameObject);
    }
}
