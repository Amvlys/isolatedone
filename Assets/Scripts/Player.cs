using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public Animator canAnim;

    public GameObject effect;

    public GameObject gameOver;

    public TextMeshProUGUI healthDisplay;

    public GameObject spawner;

    public GameObject ses;
    
    private void Update()
    {
        healthDisplay.GetComponent<TextMeshProUGUI>().text = health.ToString();
        if (health <= 0)
        {
            
            gameOver.SetActive(true);
            Destroy(gameObject);
            Destroy(spawner);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.UpArrow) | Input.GetKeyDown(KeyCode.W)&& transform.position.y < maxHeight)
        {
            Instantiate(ses, transform.position, Quaternion.identity);
            canAnim.SetTrigger("Shake");
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
            Instantiate(effect, transform.position, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) | Input.GetKeyDown(KeyCode.S)&& transform.position.y > minHeight)
        {
            Instantiate(ses, transform.position, Quaternion.identity);
            canAnim.SetTrigger("Shake");
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}
