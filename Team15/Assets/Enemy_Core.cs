using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Core : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    private float AutoTime = 0f;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        AutoTime += Time.deltaTime;
       /*if (1f < AutoTime)
        {
            AutoTime = 0f;
            float ShotSpeed = 5.5f;//弾速初速
            var pos = this.gameObject.transform.position;
            var t = Instantiate(EnemyBullet_Type_1,this.transform.position,Quaternion.identity) as GameObject;
            Vector2 vec = Player.transform.position - pos;
            vec.Normalize();
            vec *= ShotSpeed;
            t.GetComponent<Rigidbody2D>().velocity = vec;　
        }*/
        if(0.5f < AutoTime)
        {
            for(int i = 0; i < 24; i++)
            {
                AutoTime = 0f;
                float ShotSpeed = 5.5f;
                Vector2 vec = Player.transform.position - transform.position;
                vec.Normalize();
                vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                vec *= ShotSpeed;
                var t = Instantiate(EnemyBullet_Type_1,transform.position, EnemyBullet_Type_1.transform.rotation);
                t.GetComponent<Rigidbody2D>().velocity = vec;
            }
            count++;
        }
    }
}
