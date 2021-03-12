using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByNum : MonoBehaviour
{
    public GameObject Egg;
    private float SpawnTerm =1f;
    public float SpawnWidth;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        StartCoroutine(CoSpawnRandom());
    }
    public void AddEgg(string n)
    {
        count = count + Int32.Parse(n);
    }
    IEnumerator CoSpawnRandom()
    {
        while (true)
        {
            if (count > 0)
            {
                count--;
                Instantiate(Egg, this.transform.position + Vector3.right * UnityEngine.Random.Range(-1f * SpawnWidth, SpawnWidth), Quaternion.identity);
                
            }
            yield return new WaitForSeconds(SpawnTerm);
        }
    }
}
