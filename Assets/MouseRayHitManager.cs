using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayHitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            hit = Physics2D.GetRayIntersection(ray, 10000f);
            if (hit.collider != null)
            {
                Debug.Log("hit");
                hit.collider.gameObject.GetComponent<Asteroid>().Boom();
            }
            
        }
    }
}
