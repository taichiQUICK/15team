using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
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

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKey(KeyCode.Joystick1Button11))
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
            if (Input.GetKey(KeyCode.Y) || Input.GetKey(KeyCode.Joystick1Button10))
            {
                Application.Quit();
            }
            if (Input.GetKey(KeyCode.T) || Input.GetKey(KeyCode.Joystick1Button3))
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
