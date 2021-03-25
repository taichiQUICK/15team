using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Dimensionmatter : MonoBehaviour
{
    public static bool baramakikougeki = false;
    public GameObject Player;
   // public GameObject EnemyBullet_Type_1;
   // public GameObject EnemyBullet_Type_2;
    private float AutoTime = 0f;
    bool Triger = true;
    bool HpSwith900 = true;//ばらまきだん発生条件
    bool Stels = false; //ステルス状態か否か　falseが非ステ
    int count = 0;
    public Slider HpSlider;
    float GameTime = 0;

    SpriteRenderer Dimensionmatter_sprite;
    public Sprite Red;
    public Sprite Blue;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        HpSlider.value = 1080;
        Player_Move.hennkann = true;
        Player_Move.uragaseikika = false;
        Dimensionmatter_sprite = gameObject.GetComponent<SpriteRenderer>();
        Dimensionmatter_sprite.sprite = Red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player_Move.hennkann == true)
        {
            GameTime += Time.deltaTime;
        }
        else
        {
            // Debug.Log("時間経過を停止");
        }
        //ハダ_Pause用、Time.timeScaleが0のとき返す
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }






            {
                if (Player_Move.hennkann == true && Triger == true)
                {
                    Stels = true;
                    // Debug.Log("裏になった");
                    Triger = false;                  
                    Dimensionmatter_sprite.sprite = Blue;            
                }
            }
            if (Player_Move.hennkann == false && Triger == false)
            {
                Stels = false;
                //  Debug.Log("表になった");
                Triger = true;            
                Dimensionmatter_sprite.sprite = Red;
            }
        //死亡処理
        if (HpSlider.value == 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_Bullet")
        {
            HpSlider.value -= 1f;
        }
        if (collision.gameObject.tag == "URA_Player_Bullet")
        {
            HpSlider.value -= 2f;
        }
    }
}
