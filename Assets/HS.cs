using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HS : MonoBehaviour
{
    public TextMeshProUGUI highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("highScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
