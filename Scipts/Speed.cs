using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed = 1.5f;
    public float duration = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(Pickup(collision));
        }
    }
    IEnumerator Pickup(Collider2D player)
    {
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.speed += speed;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(duration);

        stats.speed -= speed;
        Destroy(gameObject);
    }
}
