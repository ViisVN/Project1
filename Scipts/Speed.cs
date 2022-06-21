using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed = 1.5f;
    public float duration = 2f;
    public GameObject pickupEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider2D player)
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.speed += speed;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(duration);

        stats.speed -= speed;
        Destroy(gameObject);
    }
}
