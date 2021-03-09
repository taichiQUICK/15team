using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Back_GroundFade : MonoBehaviour
{
    public GameObject me;
    private float fadeSpeed = 3f;
    private float time;
    private float a_Color = 255;
    private Color alpha = new Color(0, 0, 0, 0.003f);
    bool fadestop = true;
    private float ChangeTime = 0f;
    bool Frontandback = true;
    bool FadeTriger = true;
    bool ContolorlStop = true;
    private float stoptime = 0;
    bool timer = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && FadeTriger == true && ContolorlStop == true)
        {
            Frontandback = false;
          //  Debug.Log("裏面判定");

        }
        if (Input.GetKeyDown(KeyCode.X) && Frontandback == false && FadeTriger == false && ContolorlStop == true)
        {
            Frontandback = true;
          //  Debug.Log("表面判定");
        }

        if (Frontandback == false && fadestop == true)
        {
            me.GetComponent<Renderer>().material.color -= alpha;
            ChangeTime += Time.deltaTime;
            if (ChangeTime > 1f)
            {
                ChangeTime = 0f;
                timer = true;
                FadeTriger = false;
                fadestop = false;
                
              //  Debug.Log("透明化");
            }
        }
        if (Frontandback == true && fadestop == false)
        {
            me.GetComponent<Renderer>().material.color += alpha;
            ChangeTime += Time.deltaTime;
            if (ChangeTime > 1f)
            {
                ChangeTime = 0f;
                timer = true;
                FadeTriger = true;
                fadestop = true;             
               // Debug.Log("現物化");
            }
        }
        if (timer == true)
        {
            stoptime += Time.deltaTime;
            ContolorlStop = false;
            if (stoptime > 1f)
            {
                timer = false;
                ContolorlStop = true;
                stoptime = 0f;
                Debug.Log("再度Xボタンの使用可");
            }
        }


    }
}


