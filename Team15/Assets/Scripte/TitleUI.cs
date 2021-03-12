﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y) || Input.GetKeyDown(KeyCode.Joystick1Button6))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene("Game_Scene");
        }
        if (Input.GetKey(KeyCode.X) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            SceneManager.LoadScene("Old_GameScene");
        }
        if (Input.GetKey(KeyCode.T) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            SceneManager.LoadScene("Title_Scene");
        }

    }
}
