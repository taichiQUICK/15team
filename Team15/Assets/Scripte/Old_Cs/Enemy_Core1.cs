using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
public class Enemy_Core1 : MonoBehaviour
{
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    public  GameObject EnemyBullet_Type_2;
    private float AutoTime = 0f;
    bool Triger = true;
    bool HpSwith900 = true;//ばらまきだん発生条件
    int count = 0;
    //  public Slider HpSlider;
   public float KOKI_HP = 30;



    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector3(-6f, 3f, 0f), 5f).SetEase(Ease.OutQuad);
        Player = GameObject.Find("Player");
        //    HpSlider.value = 1080;
        KOKI_HP = 30;
        Player_Move.hennkann = false;
        //  GetComponent<CircleCollider2D>().enabled = true;//当たり判定
    

    }

    // Update is called once per frame
    void Update()
    {
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        AutoTime += Time.deltaTime;
        if (2.0f < AutoTime)
        {
            for (int i = 0; i < 24; i++)
            {//表面等角攻撃
                AutoTime = 0f;
                float ShotSpeed = 4f;
                Vector2 vec = Player.transform.position - transform.position;
                vec.Normalize();
                vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                vec *= ShotSpeed;
                var t = Instantiate(EnemyBullet_Type_1, transform.position, EnemyBullet_Type_1.transform.rotation);
                t.GetComponent<Rigidbody2D>().velocity = vec;
            }
            count++;
        }
        //死亡処理
        if (0 >= KOKI_HP)
        {
            //  SceneManager.LoadScene("Gameover");
            Destroy(this.gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Bullet")
        {
            KOKI_HP -= 1;
        }
        if (collision.gameObject.tag == "URA_Player_Bullet")
        {
           KOKI_HP-= 2;
        }
    }
}
