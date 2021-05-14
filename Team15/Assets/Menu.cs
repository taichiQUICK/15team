using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用

public class Menu : MonoBehaviour
{
    Button button1;
    Button button2;
    Button button3;
    Button button4;

    void Start()
    {
        // ボタンコンポーネントの取得
        button1 = GameObject.Find("Canvas/Button1").GetComponent<Button>();
        button2 = GameObject.Find("Canvas/Button2").GetComponent<Button>();
        button3 = GameObject.Find("Canvas/Button3").GetComponent<Button>();
        button4 = GameObject.Find("Canvas/Button4").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        button1.Select();
    }
}