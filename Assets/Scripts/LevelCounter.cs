using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    public Text levelText;
    public int currentLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "Level: " + currentLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

    }
}
