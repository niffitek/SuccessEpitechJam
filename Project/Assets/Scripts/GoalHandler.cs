using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalHandler : MonoBehaviour
{
    public CarController player;

    public TMP_Text timeText;

    public float time = 0;

    void Update()
    {
        time += Time.deltaTime;    
        timeText.text = ((int)time).ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerPrefs.SetInt("score", player.count);
            PlayerPrefs.SetInt("time", (int)time);
            SceneManager.LoadScene(2);
        }
    }
}
