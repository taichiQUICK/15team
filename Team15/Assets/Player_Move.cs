using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    bool SlowMode = false;//低速モードの有無
    public float PlayerMove_Plus = 0.01f;//仮では0.025　通常移動速度
    public float PlayerMove_Minus = -0.01f;//仮では-0.025 通常移動速度
    public float PlayerSlowMove_Plus = -0.0025f;//0.008 低速時の移動速度
    public float PlayerSlowMove_Minus = -0.0025f;//-0.08 低速時の移動速度

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SlowMode = true;
            Debug.Log("低速モードを有効");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            SlowMode = false;
            Debug.Log("低速モードを無効");
        }
        if (Input.GetKey(KeyCode.UpArrow) && SlowMode == true)
        {
            transform.Translate(0f, PlayerSlowMove_Plus, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow) && SlowMode == true)
        {
            transform.Translate(0f, PlayerSlowMove_Minus, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && SlowMode == true)
        {
            transform.Translate(PlayerSlowMove_Minus, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) && SlowMode == true)
        {
            transform.Translate(PlayerSlowMove_Plus, 0f, 0f);
        }    
        if (Input.GetKey(KeyCode.UpArrow) && SlowMode == false)
        {
            transform.Translate(0f, PlayerMove_Plus, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow) && SlowMode == false)
        {
            transform.Translate(0f, PlayerMove_Minus, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && SlowMode == false)
        {
            transform.Translate(PlayerMove_Minus, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) && SlowMode == false)
        {
            transform.Translate(PlayerMove_Plus, 0f, 0f);
        }
    }
}
