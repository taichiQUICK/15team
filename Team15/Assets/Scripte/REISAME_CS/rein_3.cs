using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rein_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        
          transform.Translate(0f, -0.02f, 0f);
    }
}
