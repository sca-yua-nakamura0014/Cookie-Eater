using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip door;
    [SerializeField] private GameObject white;
    public static bool fade = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {

        if (Input.GetMouseButtonUp(0))//クリックしたら音を鳴らしゲーム画面へ移動
        {
            fade = true;
            white.gameObject.SetActive(true);
            source.PlayOneShot(door);
            Invoke("gamestart",1.5f);
        }
    }

    void gamestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
