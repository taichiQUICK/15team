using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STOP_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    float Time1 =0f;
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
        v = 0.99f * v;
        if (v.magnitude < 0.01)
        {
            v = v.normalized * 0.01f;
           // transform.Translate(0f, -0.002f, 0f);
          
            

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
