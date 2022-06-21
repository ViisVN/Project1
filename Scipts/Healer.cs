using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    public float plus = 30f;
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
        if (stats.health + plus > stats.maxHealth)
        {
            stats.health = stats.maxHealth;
        }
        else
        {
            stats.health += plus;
        }
        Destroy(gameObject);
    }
}

