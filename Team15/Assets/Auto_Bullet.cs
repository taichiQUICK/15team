using System.Collections;
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

        var v = GetComponent<Rigidbody2D>().velocity;
        v = 0.998f * v;
        if (v.magnitude < 0.5f)
        {
            v = v.normalized * 0.5f;
            Debug.Log("最低毒度");

        }
        GetComponent<Rigidbody2D>().velocity = v;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
