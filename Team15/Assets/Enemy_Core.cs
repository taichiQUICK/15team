using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy_Core : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    private float AutoTime = 0f;
    bool Triger = true;
    int count = 0;
    public Slider HpSlider;
    
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
        if (0.5f < AutoTime)
        {
            for (int i = 0; i < 24; i++)
            {
                AutoTime = 0f;
                float ShotSpeed = 5.5f;
                Vector2 vec = Player.transform.position - transform.position;
                vec.Normalize();
                vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                vec *= ShotSpeed;
                var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                t.GetComponent<Rigidbody2D>().velocity = vec;
            }
            count++;
        }

        {
          //  if (Input.GetKeyDown(KeyCode.G))
            {
                if (Player_Move.hennkann == true && Triger == true)
                {
                    Debug.Log("裏になった");
                    Triger = false;
                    GetComponent<CircleCollider2D>().enabled = false;
                    gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 100);
                }
            }
        }
      //  if (Input.GetKeyDown(KeyCode.H))
        {

            if (Player_Move.hennkann == false && Triger == false)
            {
                 Debug.Log("表になった");
                Triger = true;
                GetComponent<CircleCollider2D>().enabled = true;
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
            }
        }
    }
}
