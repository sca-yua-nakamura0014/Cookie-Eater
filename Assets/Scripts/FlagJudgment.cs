using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagJudgment : MonoBehaviour
{
    [SerializeField] private GameObject Flag;
    [SerializeField] private GameObject Number;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bom"))//Bom�����Ă���I�u�W�F�N�g���N�����Ă���Ȃ�tag��BomFlag�ɕύX����
        {
            gameObject.tag = "BomFlag";

        }
    }

    public void OnClick()
    {
        if (Input.GetMouseButtonUp(1))//���N���b�N������N���[��������
        {
            Flag.SetActive(false);
        }
    }
}
