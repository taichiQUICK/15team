using System.Collections;
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
        if (Input.GetKey(KeyCode.Y) || Input.GetKey(KeyCode.Joystick1Button10))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene("Game_Scene");
        }
        if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Joystick1Button2))
        {
            SceneManager.LoadScene("Old_GameScene");
        }
        if (Input.GetKey(KeyCode.T) || Input.GetKey(KeyCode.Joystick1Button3))
        {
            SceneManager.LoadScene("Title_Scene");
        }

    }
}
