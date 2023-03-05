
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeMove : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update

    void Start()
    {
        
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Game.fade)//クリックされたらフェードを動かす
        {
            
            anim.SetBool("Fadebl", true);
        }
        else
        {
            anim.SetBool("Fadebl", false);
        }
    }

    
}
