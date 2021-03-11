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
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        DestroyTime += Time.deltaTime;
        if(DestroyTime > 1.1f)
        {
            Destroy(gameObject);

        }
    }
}
