﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Bullet : MonoBehaviour
{
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


        var v = GetComponent<Rigidbody2D>().velocity;
        v = 0.998f * v;
        if (v.magnitude < 1.4f)
        {
            v = v.normalized * 1.4f;

        }
        GetComponent<Rigidbody2D>().velocity = v;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bari")
        {
            Destroy(gameObject);
        }
    }
}
