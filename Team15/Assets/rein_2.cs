using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rein_2 : MonoBehaviour
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

        var v = GetComponent<Rigidbody2D>().velocity;
        v = 0.998f * v;
        if (v.magnitude < 0.5f)
        {
            v = v.normalized * 0.5f;

        }
        GetComponent<Rigidbody2D>().velocity = v;
        //  transform.Translate(0f, -0.05f, 0f);
    }
}
