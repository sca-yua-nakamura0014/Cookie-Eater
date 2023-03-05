using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedtime : MonoBehaviour
{
    private float time = 0.0f;
    public static float first;
    public static int count = 0;
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "0.00";
        time = Timecount.counttime;

        if (count == 0)//最初に記録されたなら今回のタイムを最速にする
        {
            first = time;
            count++;
        }
        if (time < first && count >= 1)//最初以降かつ最速より今回のタイムが早いなら最速にするする
        {
            first = time;
        }
        scoreText.text = first.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
