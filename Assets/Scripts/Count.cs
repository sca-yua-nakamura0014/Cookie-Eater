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
        if (this.tag == "Bom")//tagがBomなら文字を表示しない
        {
            text.text = "";
        }

        if(Front.bomsound >0)//tagがBomPanelかつ上のクッキーが消えてるなら効果音を鳴らす
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

        if (other.gameObject.CompareTag("Bom"))//Bomがついているオブジェクトが侵入しているなら
                                               //唐辛子をカウントする
        {
           bom++;
        }

        if (other.gameObject.CompareTag("FirstBom"))//FirstBomがついているオブジェクトが侵入しているなら
                                                    //唐辛子を減らす
        {
            bom--;
        }
        hantei();//hanteiメソッドを呼び出す

        
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Flag"))//Flagがついているオブジェクトが侵入しているならtagをFlagPanelに変更し、
                                                //上のクッキーが消えないようにする
        {
            gameObject.tag = "FlagPanel";
            GameObject front = transform.GetChild(1).gameObject;
            front.SetActive(true);
        }

        if (other.gameObject.CompareTag("BomFlag"))//BomFlagがついているオブジェクトが侵入しているならtagをBomFlagPanelに変更し、
                                                   //上のクッキーが消えないようにする
        {
            gameObject.tag = "BomFlagPanel";
            GameObject front = transform.GetChild(1).gameObject;
            front.SetActive(true);
        }

        if ((other.gameObject.CompareTag("Vanish") || other.gameObject.CompareTag("First")|| other.gameObject.CompareTag("FirstBom"))
            && this.tag != "Bom"&&this.tag != "FlagPanel" && this.tag != "BomFlagPanel")
        {
            
            if (bom > 0)//bomが1以上ならtagをNumberにし上のクッキーを消す
            {
                gameObject.tag = "Number";
                GameObject front = transform.GetChild(1).gameObject;
                front.SetActive(false);
            }

            if (this.tag != "Number")//tagがNumberでないなら上のクッキーを消し、tagをVanishに変更する
            {
                GameObject front = transform.GetChild(1).gameObject;
                front.SetActive(false);
                gameObject.tag = "Vanish";
            }

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Flag"))//離れたtagがFlagならTagをQuestionに変更する
        {
            gameObject.tag = "Question";
            Debug.Log("A");
        }
        if (other.gameObject.CompareTag("BomFlag"))//離れたtagがBomFlagならTagをBomに変更する
        {
            gameObject.tag = "Bom";
            Debug.Log("B");
        }
    }


    public void hantei()
    {
        //カウントされた唐辛子/2の値を表示する
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
