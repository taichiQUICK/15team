using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_CS_2 : MonoBehaviour
{
    // Start is called before the first frame update
    //　ポーズした時に表示するUIのプレハブ
    public GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }

        //ポーズ中処理
        if (Time.timeScale == 0)
        {
            if (Input.GetKey(KeyCode.Y) || Input.GetKey(KeyCode.Joystick1Button6))
            {
                Application.Quit();
            }
            if (Input.GetKey(KeyCode.T) || Input.GetKey(KeyCode.Joystick1Button1))
            {
                SceneManager.LoadScene("TItle_Scene");
            }
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Time.timeScale = 1f;
    }
}
