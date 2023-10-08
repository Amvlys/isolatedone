using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int damage = 1;
    public GameObject effect;
    public GameObject patlamasesi;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Instantiate(patlamasesi, transform.position, Quaternion.identity);
                Instantiate(effect, transform.position, Quaternion.identity);
                other.GetComponent<Player>().health -= damage;
                Debug.Log(other.GetComponent<Player>().health);
                Destroy(gameObject);
            }
        }
}
