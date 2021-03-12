 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerYH : MonoBehaviour
{
    public GameObject Egg;
    public float SpawnTerm;
    public float SpawnWidth;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoSpawnRandom());
    }
    IEnumerator CoSpawnRandom()
    {
        while(true)
        {
            Instantiate(Egg, this.transform.position + Vector3.right * Random.Range(-1f *SpawnWidth,SpawnWidth), Quaternion.identity);
            yield return new WaitForSeconds(SpawnTerm);
        }
        
    }
}
