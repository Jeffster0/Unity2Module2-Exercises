using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDestroy : MonoBehaviour
{
    //create variables below 
    public GameObject prefab;
    public float delayDestroy = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //WRITE CODE HERE
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab);
        }
        //END OF CODE
        Destroy(prefab,delayDestroy);
    }
}
