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
        if (rand >= 9)//ランダムな値が9以上ならtagを変更し唐辛子を表示する
        {
            this.tag = "Bom";
            Baku.SetActive(true);
            Front.tag = "BomPanel";
        }
        else//それ以外ならtagを変更する
        {
            this.tag = "Question";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("First")|| this.gameObject.CompareTag("FirstBom"))//最初にクリックされたなら唐辛子を消す
        {
            Baku.SetActive(false);
        }
    }
}