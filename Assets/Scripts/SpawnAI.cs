using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour
{
    public List<GameObject> EnemyList = new List<GameObject>();
    public float period = 1f;

    public float maxX, minX, maxZ, minZ;
    
    // Start is called before the first frame update
    void Start()
    {
        var TempVar = FindObjectsOfType<GameObject>();
        for (int i = 0; i < TempVar.Length; i++)
        {
            if (TempVar[i].name.Contains("enemy"))
            {
                EnemyList.Add(TempVar[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (period > 3)
        {
            for (int i = 0; i < EnemyList.Count; i++)
            {
                if (EnemyList[i].activeSelf == false)
                {
                    EnemyList[i].transform.position = SetRandomLocation(EnemyList[i]);
                    EnemyList[i].SetActive(true);
                    Debug.Log("Respawning enemy");
                }
            }
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
    }

    public Vector3 SetRandomLocation(GameObject enemy)
    {
        float newX = Random.Range(minX, maxX);
        float newZ = Random.Range(minZ, maxZ);
        return new Vector3(newX, 10, newZ);
    }
}
