using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SceneManagement : MonoBehaviour
{
    //public Score KeepTrackOfPlayer;
    //public float ScoreObjective;
    public Text levelText;
    public int currentLevel = 1;

    public GameObject player;
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
        if (collision.gameObject.name.Contains("player"))
        {
            var TempVar = FindObjectsOfType<GameObject>();
            for (int i = 0; i < TempVar.Length; i++)
            {
                if (TempVar[i].name.Contains("item"))
                {
                    TempVar[i].SetActive(false);
                }
            }
            if (SceneManager.GetActiveScene().name == "Scene1")
            {
                SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
                    
            }
            else if (SceneManager.GetActiveScene().name == "Scene2")
            {
                SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene3")
            {
                SceneManager.LoadScene("Scene4", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene4")
            {
                SceneManager.LoadScene("Scene5", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene5")
            {
                SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
            }
            player.transform.position = new Vector3(0f, 1f, 0f);
            currentLevel++;
            levelText.text = "Level: " + currentLevel.ToString();
            Destroy(player.transform.GetChild(0).gameObject);
        }
    }
}