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

    public void Touch()//�{�^���ɐG��Ă���Ȃ�A�j���[�V�����𓮂���
    {
        anim.SetBool("Startbl",true);
    }

    public void Stop()//�{�^�����痣�ꂽ�Ȃ�A�j���[�V�������~�߂�
    {
        anim.SetBool("Startbl", false);
    }

}
