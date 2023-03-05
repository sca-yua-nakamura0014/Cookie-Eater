using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jugment : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clear;
 
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Boms = GameObject.FindGameObjectsWithTag("Bom");
        GameObject[] Panel = GameObject.FindGameObjectsWithTag("FlagPanel");
        GameObject[] Numbers = GameObject.FindGameObjectsWithTag("Question");
        //Debug.Log(Boms.Length.ToString());
        if(Boms.Length == 0 && Panel.Length == 0 && Numbers.Length == 0)//���h�q�A�N���[���A��̃N�b�L�[���S�Ė����Ȃ�����
                                                                        //1�b��ɃN���A��ʂֈړ�����
        {
            Front.c = 0;
            source.PlayOneShot(clear);
            Invoke("Clear", 2.0f);
        }
    }

    public void Clear()
    {
        SceneManager.LoadScene("Clear");
    }
}
