using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Retry : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip door;
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

        if (Input.GetMouseButtonUp(0))//‰¹‚ğ–Â‚ç‚µƒQ[ƒ€‰æ–Ê‚ÖˆÚ“®
        {
            source.PlayOneShot(door);
            Invoke("gamestart", 1.0f);
        }
    }

    void gamestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
