using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public float damage = 5f;
    [SerializeField]
    public float speed = 1.5f;
    [SerializeField]
    public float hp = 10;
    [SerializeField]
    private GameObject player;
    public SpriteRenderer sprite;

    //Change color
    public IEnumerator Flashred()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerStats>().health -= damage;
            Destroy(gameObject);
        }
    }

    //Tru hp
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            hp -= 2;
            StartCoroutine(Flashred());
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        Enemyfollowing();
    }
    public void Enemyfollowing()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

}
