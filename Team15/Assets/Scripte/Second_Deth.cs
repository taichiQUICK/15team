using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_Deth : MonoBehaviour
{
    private float DestroyTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        DestroyTime += Time.deltaTime;
        if(DestroyTime > 0.81f)
        {
            Destroy(gameObject);

        }
    }
}
