using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    private Text scoreText;
    // Start is called before the first frame update
    void Start()//今回のタイムを表示する
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "0.00";
        scoreText.text =Timecount.counttime.ToString("0.00");
    }
}
