using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    private Text scoreText;
    // Start is called before the first frame update
    void Start()//ç°âÒÇÃÉ^ÉCÉÄÇï\é¶Ç∑ÇÈ
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "0.00";
        scoreText.text =Timecount.counttime.ToString("0.00");
    }
}
