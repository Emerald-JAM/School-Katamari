using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SceneManagement : MonoBehaviour
{
    //public Score KeepTrackOfPlayer;
    //public float ScoreObjective;
    public Text levelText;
    public int currentLevel = 1;
    //private int totalScore;
    //private int scoreAtLevel;

    private AudioSource sfx;

    public GameObject player;
    public Score script;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "Level: " + currentLevel.ToString();
        sfx = GameObject.Find("goal").GetComponent<AudioSource>();
        script = player.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("player") /*|| Input.GetKey("p")*/)
        {
            nextLevel();
        }
    }
    public void nextLevel()
    {
            sfx.Play();
            GameObject system = GameObject.Find("Level Up Particles");
            system.GetComponent<ParticleSystem>().Play(true);
        //var TempVar = FindObjectsOfType<GameObject>();
        /*
        for (int i = 0; i < TempVar.Length; i++)
        {
            if (TempVar[i].name.Contains("item"))
            {
                Destroy(player.transform.GetChild(i).gameObject);
                //TempVar[i].SetActive(false);
            }
        }
        */
        Destroy(GameObject.Find("item"));

        script.scoreAtLevel = script.totalScore;

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
                SceneManager.LoadScene("Scene6", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene6")
            {
                SceneManager.LoadScene("Scene7", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene7")
            {
                SceneManager.LoadScene("Scene8", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene8")
            {
                SceneManager.LoadScene("Scene9", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene9")
            {
                SceneManager.LoadScene("Scene10", LoadSceneMode.Single);
            }
            else if (SceneManager.GetActiveScene().name == "Scene10")
            {
            SceneManager.LoadScene("Scene11", LoadSceneMode.Single);
            currentLevel -= 10;
            }
            else if (SceneManager.GetActiveScene().name == "Scene11")
            {
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
            }

        player.transform.position = new Vector3(0f, 1f, 0f);
            currentLevel++;
            levelText.text = "Level: " + currentLevel.ToString();
            //Destroy(player.transform.GetChild(0).gameObject);
            //Destroy(player.transform.Find("item").gameObject);
            /*var TempVar = FindObjectsOfType<GameObject>();
            for (int i = 0; i < TempVar.Length; i++)
            {
                if (TempVar[i].name.Contains("item"))
                {
                    Debug.Log("Item found with name: " + TempVar[i].name);
                if (!(TempVar[i].name.Contains(currentLevel.ToString())))
                    {
                        Destroy(TempVar[i].gameObject);
                    }
                }
            }*/
    }

    public void ResetGame()
    {
        Destroy(GameObject.Find("KeepAcrossScenes"));
        Destroy(GameObject.Find("item"));
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }

    public void ResetScene()
    {
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            Destroy(GameObject.Find("KeepAcrossScenes"));
        }
        script.totalScore = script.scoreAtLevel;
        script.scoreText.text = "Score: " + script.totalScore.ToString();
        Destroy(GameObject.Find("item"));
        //Destroy(GameObject.Find("player"));
        //Destroy(GameObject.Find("scoreCounter"));
        //string activeScene = SceneManager.GetActiveScene;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}