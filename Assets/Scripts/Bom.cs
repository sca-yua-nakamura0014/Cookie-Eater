using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bom : MonoBehaviour
{
    private int rand = 0;
    [SerializeField] private GameObject Baku;
    [SerializeField] private GameObject Front;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 11);
        //Debug.Log(rand);
       // Debug.Log(rand);
        if (rand >= 9)//�����_���Ȓl��9�ȏ�Ȃ�tag��ύX�����h�q��\������
        {
            this.tag = "Bom";
            Baku.SetActive(true);
            Front.tag = "BomPanel";
        }
        else//����ȊO�Ȃ�tag��ύX����
        {
            this.tag = "Question";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("First")|| this.gameObject.CompareTag("FirstBom"))//�ŏ��ɃN���b�N���ꂽ�Ȃ瓂�h�q������
        {
            Baku.SetActive(false);
        }
    }
}