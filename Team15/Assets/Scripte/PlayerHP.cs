using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    int hp = 30;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Text").GetComponent<Text>();
        this.textComponent.text = "× " + hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //死亡処理
        if (hp == 0)
        {
            SceneManager.LoadScene("Gameover");
        }

    }

    public void AddScore()
    {
        this.hp -= 1;
        this.textComponent.text = "× " + hp.ToString();
    }
}