using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setumei : MonoBehaviour
{
    [SerializeField] private GameObject front;
    private int count; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//Enterを押せば説明画面を表示するもう１回押すと消える
        {
            count++;
            if(count %2 == 1)
            {
                front.gameObject.SetActive(false);
                
            }
            else
            {
                front.gameObject.SetActive(true);
            }
            
        }
    }
}
