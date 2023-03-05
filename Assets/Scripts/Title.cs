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

        if (Input.GetMouseButtonUp(0))//‰¹‚ð–Â‚ç‚µƒ^ƒCƒgƒ‹‰æ–Ê‚ÖˆÚ“®‚·‚é
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
