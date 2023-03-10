using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip close;
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

        if (Input.GetMouseButtonUp(0))//音を鳴らしタイトル画面へ移動する
        {
            source.PlayOneShot(close);
            Invoke("gameend", 1.0f);
        }
    }

    void gameend()
    {
        SceneManager.LoadScene("Title");
    }
}
