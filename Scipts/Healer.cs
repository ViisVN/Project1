using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    public float plus = 30f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject player = other.gameObject;
            PlayerStats stats = player.GetComponent<PlayerStats>();
            if (stats.health < stats.maxHealth)
            {
                stats.health += plus;
                Destroy(gameObject);
            }
            if (stats.health >= stats.maxHealth)
            {
                stats.health = stats.maxHealth;
                Destroy(gameObject);
            }

        }
    }

}

