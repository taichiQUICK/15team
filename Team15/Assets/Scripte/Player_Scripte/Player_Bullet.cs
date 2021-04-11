using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    public float BulletSpeed = 0.1f;//弾の速さ
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
        transform.Translate(0f, BulletSpeed, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "KOKI")
        {
            Destroy(gameObject);
        }
    }
}
