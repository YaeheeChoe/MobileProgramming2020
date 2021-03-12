using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject effectOb;
    // Start is called before the first frame update
    public void Boom()
    {
        StartCoroutine(CoBoom());
        StartCoroutine(AutoDeath());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CoBoom()
    {
        GetComponent<SpriteRenderer>().color = Color.clear;
        Instantiate(effectOb,this.transform.position,Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        yield return null;
    }
    IEnumerator AutoDeath()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
        yield return null;
    }
        
}
