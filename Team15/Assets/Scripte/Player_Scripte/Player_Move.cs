﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move : MonoBehaviour
{
    public static bool hennkann = false;//世界の表がfalse 裏がtrue
    public static bool uragaseikika = true;
    bool PlayerX_ButtonStop = true; //プレイヤーのXボタンの操作の停止
    bool PlayerMoveStop = true;//プレイヤーを一時的に止める
    bool SlowMode = false;//低速モードの有無
    bool FrontandBack = true;//表裏モードの確認
    bool FadeStop = true;private float ChangeTime = 0;bool FadeTriger = true; 
    bool ScreenLimiteR = true; bool ScreenLimiteL = true; bool ScreenLimiteU = true; bool ScreenLimiteD = true;//画面限界値
    public float PlayerMove_Plus = 1;//仮では0.025　通常移動速度
    public float PlayerMove_Minus = -1;//仮では-0.025 通常移動速度
    public float PlayerSlowMove_Plus = 0.25f;//0.008 低速時の移動速度
    public float PlayerSlowMove_Minus = -0.25f;//-0.08 低速時の移動速度
    private float PlayerShotTime = 0f;//プレイヤーショットインターバル初期化
    private float PlayerMoveStopTime = 0f;//プレイヤーが操作不能になる時間
    private Color alpha = new Color(0, 0, 0, 0.01f);
    public float StopCoolTime = 0.5f;//表裏移動時　行動不能クールタイム　仮設定 標準0.5
    public GameObject Back_Ground; bool fadeM = true; bool fadeU = true;
    public GameObject Tile;
    //クールタイム表示用
    public Text JigennidouUI;
    private float totalTime;
    int seconds;
    //スプライト表示切替用
    SpriteRenderer MainSpriteRenderer;
    public Sprite spriteBack;
    public Sprite spriteRight;
    public Sprite spriteLeft;
    private bool move;

    bool ZIKITriger = true;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = 5.3f;
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        move = false;
        hennkann = false;
     //  Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //スプライト表示切替用
        if (move == false)
        {
            MainSpriteRenderer.sprite = spriteBack;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.RightArrow))
        {
            move = false;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
        //    GameObject BuleSpell = (GameObject)Resources.Load("BladeStorm");
        //    Instantiate(BuleSpell, this.transform.position, Quaternion.identity);
        }
        //各移動処理

        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("button0");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("button1");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button2");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("button3");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("button7");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
        }
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        if ((hori < 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
            transform.Translate(PlayerMove_Minus, 0f, 0f);
            MainSpriteRenderer.sprite = spriteLeft;
            move = true;
        }
        if ((hori > 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
            transform.Translate(PlayerMove_Plus, 0f, 0f);
            MainSpriteRenderer.sprite = spriteRight;
            move = true;
        }
        if ((vert < 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
            transform.Translate(0f, PlayerMove_Plus, 0f);
            MainSpriteRenderer.sprite = spriteBack;
            move = true;
        }
        if ((vert > 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
            transform.Translate(0f, PlayerMove_Minus, 0f);
            MainSpriteRenderer.sprite = spriteBack;
            move = true;
        }
        if(hori==0||vert==0)
        {
            move = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {//低速モード有効
            SlowMode = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {//低速モード無効
            SlowMode = false;
        }
        if (Input.GetKey(KeyCode.UpArrow) && SlowMode == true && ScreenLimiteU == true && PlayerMoveStop == true)
        {
            transform.Translate(0f, PlayerSlowMove_Plus, 0f);
            MainSpriteRenderer.sprite = spriteBack;
            move = true;
        }
        if (Input.GetKey(KeyCode.DownArrow) && SlowMode == true && ScreenLimiteD == true && PlayerMoveStop == true)
        {
            transform.Translate(0f, PlayerSlowMove_Minus, 0f);
            MainSpriteRenderer.sprite = spriteBack;
            move = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && SlowMode == true && ScreenLimiteL == true && PlayerMoveStop == true)
        {
            transform.Translate(PlayerSlowMove_Minus, 0f, 0f);
            MainSpriteRenderer.sprite = spriteLeft;
            move = true;
        }
        if (Input.GetKey(KeyCode.RightArrow) && SlowMode == true && ScreenLimiteR == true && PlayerMoveStop == true)
        {
            transform.Translate(PlayerSlowMove_Plus, 0f, 0f);
            MainSpriteRenderer.sprite = spriteRight;
            move = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) && SlowMode == false && ScreenLimiteU == true && PlayerMoveStop == true)
        {
            transform.Translate(0f, PlayerMove_Plus, 0f);
            MainSpriteRenderer.sprite = spriteBack;
            move = true;
        }
        if (Input.GetKey(KeyCode.DownArrow) && SlowMode == false && ScreenLimiteD == true && PlayerMoveStop == true)
        {
            transform.Translate(0f, PlayerMove_Minus, 0f);
            MainSpriteRenderer.sprite = spriteBack;
            move = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && SlowMode == false && ScreenLimiteL == true && PlayerMoveStop == true)
        {
            transform.Translate(PlayerMove_Minus, 0f, 0f);
            MainSpriteRenderer.sprite = spriteLeft;
            move = true;
        }
        if (Input.GetKey(KeyCode.RightArrow) && SlowMode == false && ScreenLimiteR == true && PlayerMoveStop == true)
        {
            transform.Translate(PlayerMove_Plus, 0f, 0f);
            MainSpriteRenderer.sprite = spriteRight;
            move = true;
        }

        if (transform.position.x <= -7.85)
        {
            ScreenLimiteL = false;
        }
        else
        {
            ScreenLimiteL = true;
        }
        if (transform.position.x >= 2.3)
        {
            ScreenLimiteR = false;
        }
        else
        {
            ScreenLimiteR = true;
        }
        if (transform.position.y >= 4.4)
        {
            ScreenLimiteU = false;
        }
        else
        {
            ScreenLimiteU = true;
        }
        if (transform.position.y <= -4.3)
        {
            ScreenLimiteD = false;
        }
        else
        {
            ScreenLimiteD = true;
        }

        //移動処理はここの間まで
        if ((Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Joystick1Button2)) && PlayerMoveStop == true && hennkann == false)
        {//プレイヤーショット関連
            PlayerShotTime += Time.deltaTime;
            if (0.10f < PlayerShotTime)//0.10の弾幕インターバル
            {
                PlayerShotTime = 0f;
                GameObject Player_Bullet = (GameObject)Resources.Load("Player_Bullet");
                Instantiate(Player_Bullet, this.transform.position, Quaternion.identity);
             //   Debug.Log("弾生成");
            }
        }
       
        if ((Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Joystick1Button2)) && PlayerMoveStop == true && hennkann == true)
        {//プレイヤーショット関連
            PlayerShotTime += Time.deltaTime;
            if (0.10f < PlayerShotTime)//0.10の弾幕インターバル
            {
                PlayerShotTime = 0f;
                GameObject URA_Player_Bullet = (GameObject)Resources.Load("URA_Player_Bullet");
                Instantiate(URA_Player_Bullet, this.transform.position, Quaternion.identity);
                //   Debug.Log("弾生成");
            }
        }
        //プレイヤーショット関連はこの間
        //プレイヤーがボタン操作できるギミック等
        if ((Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Joystick1Button0)) && FrontandBack == true && PlayerX_ButtonStop == true)
        {
            GameObject BuleSpell = (GameObject)Resources.Load("RedSpell");
            Instantiate(BuleSpell, this.transform.position, Quaternion.identity);
         //   Back_Ground.GetComponent<Renderer>().material.color = Color.red;
            FrontandBack = false;//フェードやXボタンでの処理の主なbool
            PlayerMoveStop = false;
            PlayerX_ButtonStop = false;
            // Debug.Log("裏");
            GameObject bari = (GameObject)Resources.Load("baria");
            Instantiate(bari, this.transform.position, Quaternion.identity);
            hennkann = true; //裏表信号
            uragaseikika = false;
        }
        if ((Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Joystick1Button0)) && FrontandBack == false && PlayerX_ButtonStop == true)
        {

            GameObject BuleSpell = (GameObject)Resources.Load("BlueSpell");
            Instantiate(BuleSpell, this.transform.position, Quaternion.identity);
           // Back_Ground.GetComponent<Renderer>().material.color = Color.white;
            PlayerMoveStop = false;
            PlayerX_ButtonStop = false;
            FrontandBack = true;
            GameObject bari = (GameObject)Resources.Load("baria");
            Instantiate(bari, this.transform.position, Quaternion.identity);
            // Debug.Log("表");         

            hennkann = false; // 裏表信号
            uragaseikika = true;
        }
        if (PlayerMoveStop == false)
        {
            PlayerMoveStopTime += Time.deltaTime;
            if (PlayerMoveStopTime > 0.5f)
            {
                PlayerMoveStop = true;
                PlayerMoveStopTime = 0;
            }
        }
        if (PlayerX_ButtonStop == false)
        {
            Tile.SetActive(false);
            // Tile.GetComponent<SpriteRenderer>().material.color = Color.white;
            PlayerMoveStopTime += Time.deltaTime;
            //クールタイム表示
            totalTime -= Time.deltaTime;
            //seconds = (int)totalTime;
            JigennidouUI.text = "" + totalTime.ToString("f2");

            if (PlayerMoveStopTime > 5f)
            {
                Tile.SetActive(true);
               // Tile.GetComponent<SpriteRenderer>().material.color = Color.red;
                PlayerX_ButtonStop = true;
                PlayerMoveStopTime = 0;
                //Debug.Log("切り替えできる");
                JigennidouUI.text = "次元移動可能";
                totalTime = 5.3f;

            }

        }
        //下切り替え常時発動条件付きのboolのやつ
        if (FrontandBack == false && FadeStop == true)
        {
            Back_Ground.GetComponent<SpriteRenderer>().material.color -= alpha;
            ChangeTime += Time.deltaTime;
            if(ChangeTime > 1f)
            {
                
                ChangeTime = 0f;
                FadeTriger = false;
                FadeStop = false;
            }
        }
        if(FrontandBack == true && FadeStop == false)
        {
            Back_Ground.GetComponent<SpriteRenderer>().material.color += alpha;
            ChangeTime += Time.deltaTime;
            if(ChangeTime > 1f)
            {
               
                ChangeTime = 0f;
                FadeTriger = true;
                FadeStop = true;
            }
        }

    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "KOKI" || collision.gameObject.tag == "Enemy" && ZIKITriger == true)
        {
            GameObject BuleSpell = (GameObject)Resources.Load("BladeStorm");
            Instantiate(BuleSpell, this.transform.position, Quaternion.identity);
            GameObject zikibari = (GameObject)Resources.Load("ZIKI_BARI");
            Instantiate(zikibari, this.transform.position, Quaternion.identity);
            GameObject.Find("PlayerHP").GetComponent<PlayerHP>().AddScore();
            ZIKITriger = false;
            Invoke("ZIKIKAIHUKU", 2);
        }
    }
    void ZIKIKAIHUKU()
    {
        ZIKITriger = true;
    }

}
