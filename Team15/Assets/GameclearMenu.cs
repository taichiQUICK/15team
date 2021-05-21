using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIコンポーネントの使用

public class GameclearMenu : MonoBehaviour
{
    Button button1;
    Button button4;

    void Start()
    {
        // ボタンコンポーネントの取得
        button1 = GameObject.Find("Canvas/Button1").GetComponent<Button>();
        button4 = GameObject.Find("Canvas/Button4").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        button1.Select();
    }
}
