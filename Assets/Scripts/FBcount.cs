using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FBcount : MonoBehaviour
{
    private Rigidbody2D rb;
    private int bom = 0;
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        hantei();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bom"))//Bom�����Ă���I�u�W�F�N�g���N�����Ă���Ȃ瓂�h�q���J�E���g����
        {
            bom++;
            //Debug.Log("B");
        }
        hantei();
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.CompareTag("Vanish") || other.gameObject.CompareTag("First") || other.gameObject.CompareTag("FirstBom")) && this.tag != "Bom" && this.tag != "FlagPanel" && this.tag != "BomFlagPanel")
        {

            if (bom > 0)//bom��1�ȏ�Ȃ�tag��Number�ɂ���̃N�b�L�[������
            {
                gameObject.tag = "Number";
                GameObject front = transform.GetChild(1).gameObject;
                front.SetActive(false);
            }
            if(this.tag != "Number")//tag��Number�łȂ��Ȃ��̃N�b�L�[�������Atag��Vanish�ɕύX����
            {
                GameObject front = transform.GetChild(1).gameObject;
                front.SetActive(false);
                gameObject.tag = "Vanish";
            }
        }
    }


    public void hantei()
    {
        //�J�E���g���ꂽ���h�q�̒l��\������
        if (bom == 1)
        {
            text.text = "1";

        }
        else if (bom == 2)
        {
            text.text = "2";
        }
        else if (bom  == 3)
        {
            text.text = "3";
        }
        else if (bom  == 4)
        {
            text.text = "4";
        }
        else if (bom  == 5)
        {
            text.text = "5";
        }
        else if (bom == 6)
        {
            text.text = "6";
        }
        else if (bom  == 7)
        {
            text.text = "7";
        }
        else if (bom == 8)
        {
            text.text = "8";
        }
        else
        {
            text.text = " ";
        }
    }
}

