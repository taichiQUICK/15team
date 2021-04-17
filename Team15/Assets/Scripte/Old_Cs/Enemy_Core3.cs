using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
public class Enemy_Core3 : MonoBehaviour
{
    public static bool baramakikougeki = false;
    public GameObject Player;
    public GameObject EnemyBullet_Type_1;
    public GameObject EnemyBullet_Type_2;

    private float AutoTime = 0f;
    bool Triger = true;
    bool HpSwith900 = true;//ばらまきだん発生条件
    int count = 0;
    //  public Slider HpSlider;
   public float KOKI_HP = 30;
    float shotspeed = 2f;
    float rate = 3.0f;
    float timeA = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector3(-0f, 1.3f, 0f), 5f).SetEase(Ease.Unset);
        // this.transform.DOMove(new Vector3(-6f, 3f, 0f), 5f).SetEase(Ease.OutQuad);
        Player = GameObject.Find("Player");
        //    HpSlider.value = 1080;
        KOKI_HP = 30;
      //  Player_Move.hennkann = false;
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
        if (rate < AutoTime)
        {
            for (int i = 0; i < 24; i++)
            {//表面等角攻撃
                AutoTime = 0f;
                Vector2 vec = Player.transform.position - transform.position;
                vec.Normalize();
                vec = Quaternion.Euler(0, 0, (360 / 24) * i) * vec;
                vec *= shotspeed;
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
        if (Player_Move.hennkann == true)
        {
            shotspeed = 2f;
            rate = 4.0f;

        }
        if (Player_Move.hennkann == false)
        {
            shotspeed = 4f;
            rate = 3.0f;
            timeA += Time.deltaTime;
            if (3f < timeA)
            {
                float ShotSpeed = 3f;//弾速初速
                var pos = this.gameObject.transform.position;
                var t = Instantiate(EnemyBullet_Type_2, this.transform.position, Quaternion.identity) as GameObject;
                Vector2 vec = Player.transform.position - pos;
                vec.Normalize();
                vec *= ShotSpeed;
                t.GetComponent<Rigidbody2D>().velocity = vec;
                timeA = 0f;
            }
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
        if (collision.gameObject.tag == "Bari")
        {
            Destroy(this.gameObject);
        }
    }
}
