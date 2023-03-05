using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTextMove : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()//ボタンに触れているならアニメーションを動かす
    {
        anim.SetBool("Startbl",true);
    }

    public void Stop()//ボタンから離れたならアニメーションを止める
    {
        anim.SetBool("Startbl", false);
    }

}
