using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Front : MonoBehaviour
{
    public static int c = 0;
    public static int bomsound;
    [SerializeField] private GameObject Number;
    [SerializeField] private GameObject FirstBom;
    [SerializeField] private GameObject Flag;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip hata;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()//クリックしたら
    {
        if (Input.GetMouseButtonUp(1))//右クリックをしたらクリームを設置し、音を鳴らす
        {
            Instantiate(Flag, new Vector3(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            source.PlayOneShot(hata);
        }

        if (Input.GetMouseButtonUp(0))//左クリックをしたら上のクッキーを消す
        {
            c++;
            gameObject.SetActive(false);
            
            if (c == 1)//もし最初にクリックしたら
            {
                if (Number.CompareTag("Bom"))//オブジェクトが唐辛子なら唐辛子をクッキーに変更する
                {
                    Instantiate(FirstBom, new Vector3(Number.transform.position.x, Number.transform.position.y), Quaternion.identity);
                    Debug.Log(Number.transform.position);
                    Number.SetActive(false);
                }

                else//唐辛子でないならTagを変更する
                {
                    Number.tag = "First";
                }

            }
            else
            {
                if (Number.CompareTag("Question"))//1回目以降でクッキーならTagを変更する
                {
                    Number.tag = "Vanish";
                    //Debug.Log("S");
                }

                if (Number.CompareTag("Bom"))//1回目以降で唐辛子なら時間を止め、回数をリセットし3秒後にゲームオーバーシーンへ移行する
                {
                    bomsound++;
                    //Debug.Log("gameover");
                    c = 0;
                    Invoke("gameover", 1.0f);
                }
            }

        }
    }

    public void gameover()//sceneを移動しタイムを0にする
    {
        SceneManager.LoadScene("GameOver");
        //Jugment.clear = 0;
        Timecount.counttime = 0.00f;
    }
}
