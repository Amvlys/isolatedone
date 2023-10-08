using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Healin : MonoBehaviour
{
    public float speed;
    public int damage = 1;
    public GameObject can;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(can, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health += damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}
