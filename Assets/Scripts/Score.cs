using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int totalScore;
    private AudioSource sfx;

    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
        scoreText.text = "Score: " + totalScore.ToString();
        sfx = GameObject.Find("player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("enemy"))
        {
            totalScore = totalScore + 1;
            scoreText.text = "Score: " + totalScore.ToString();
            sfx.Play();
            collision.gameObject.SetActive(false);
        }
    }
}
