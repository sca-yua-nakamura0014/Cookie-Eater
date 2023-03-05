using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour
{
    private Text timerText;
    public static float counttime;
    [SerializeField] private GameObject front;
    void Start()
    {
        counttime = 0.00f;
    }

    void Update()
    {
        if(Front.c != 0 && front.gameObject.activeSelf ==false)//唐辛子やクリーム、上のクッキーが残っているかつ説明画面を表示していないなら
                                                               //タイマーを動かし表示する
        {
            timerText = GetComponent<Text>();
            counttime += Time.deltaTime;
            timerText.text = counttime.ToString("0.00");
        }
       
    }
}
