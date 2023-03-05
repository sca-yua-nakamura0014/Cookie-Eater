using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count: MonoBehaviour
{
    private int bom = 0;
    private bool bs= true;
    [SerializeField] Text text;
    [SerializeField] GameObject front;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip baku;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Bom")//tag��Bom�Ȃ當����\�����Ȃ�
        {
            text.text = "";
        }

        if(Front.bomsound >0)//tag��BomPanel����̃N�b�L�[�������Ă�Ȃ���ʉ���炷
        {
            //Debug.Log("A");
            if(bs)
            {
                //Debug.Log("B");
                source.PlayOneShot(baku);
                bs = false;
            }
            Front.bomsound = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Bom"))//Bom�����Ă���I�u�W�F�N�g���N�����Ă���Ȃ�
                                               //���h�q���J�E���g����
        {
           bom++;
        }

        if (other.gameObject.CompareTag("FirstBom"))//FirstBom�����Ă���I�u�W�F�N�g���N�����Ă���Ȃ�
                                                    //���h�q�����炷
        {
            bom--;
        }
        hantei();//hantei���\�b�h���Ăяo��

        
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Flag"))//Flag�����Ă���I�u�W�F�N�g���N�����Ă���Ȃ�tag��FlagPanel�ɕύX���A
                                                //��̃N�b�L�[�������Ȃ��悤�ɂ���
        {
            gameObject.tag = "FlagPanel";
            GameObject front = transform.GetChild(1).gameObject;
            front.SetActive(true);
        }

        if (other.gameObject.CompareTag("BomFlag"))//BomFlag�����Ă���I�u�W�F�N�g���N�����Ă���Ȃ�tag��BomFlagPanel�ɕύX���A
                                                   //��̃N�b�L�[�������Ȃ��悤�ɂ���
        {
            gameObject.tag = "BomFlagPanel";
            GameObject front = transform.GetChild(1).gameObject;
            front.SetActive(true);
        }

        if ((other.gameObject.CompareTag("Vanish") || other.gameObject.CompareTag("First")|| other.gameObject.CompareTag("FirstBom"))
            && this.tag != "Bom"&&this.tag != "FlagPanel" && this.tag != "BomFlagPanel")
        {
            
            if (bom > 0)//bom��1�ȏ�Ȃ�tag��Number�ɂ���̃N�b�L�[������
            {
                gameObject.tag = "Number";
                GameObject front = transform.GetChild(1).gameObject;
                front.SetActive(false);
            }

            if (this.tag != "Number")//tag��Number�łȂ��Ȃ��̃N�b�L�[�������Atag��Vanish�ɕύX����
            {
                GameObject front = transform.GetChild(1).gameObject;
                front.SetActive(false);
                gameObject.tag = "Vanish";
            }

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Flag"))//���ꂽtag��Flag�Ȃ�Tag��Question�ɕύX����
        {
            gameObject.tag = "Question";
            Debug.Log("A");
        }
        if (other.gameObject.CompareTag("BomFlag"))//���ꂽtag��BomFlag�Ȃ�Tag��Bom�ɕύX����
        {
            gameObject.tag = "Bom";
            Debug.Log("B");
        }
    }


    public void hantei()
    {
        //�J�E���g���ꂽ���h�q/2�̒l��\������
        if (bom /2== 1)
        {
            text.text = "1";
            
        }
        else if (bom / 2 == 2)
        {
            text.text = "2";
        }
        else if (bom / 2 == 3)
        {
            text.text = "3";
        }
        else if (bom / 2 == 4)
        {
            text.text = "4";
        }
        else if (bom/2 == 5)
        {
            text.text = "5";
        }
        else if (bom/2 == 6)
        {
            text.text = "6";
        }
        else if (bom/2 == 7)
        {
            text.text = "7";
        }
        else if (bom/2 == 8)
        {
            text.text = "8";
        }
        else
        {
            text.text = " ";
        }
    }
}
