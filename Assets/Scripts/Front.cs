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

    public void OnClick()//�N���b�N������
    {
        if (Input.GetMouseButtonUp(1))//�E�N���b�N��������N���[����ݒu���A����炷
        {
            Instantiate(Flag, new Vector3(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            source.PlayOneShot(hata);
        }

        if (Input.GetMouseButtonUp(0))//���N���b�N���������̃N�b�L�[������
        {
            c++;
            gameObject.SetActive(false);
            
            if (c == 1)//�����ŏ��ɃN���b�N������
            {
                if (Number.CompareTag("Bom"))//�I�u�W�F�N�g�����h�q�Ȃ瓂�h�q���N�b�L�[�ɕύX����
                {
                    Instantiate(FirstBom, new Vector3(Number.transform.position.x, Number.transform.position.y), Quaternion.identity);
                    Debug.Log(Number.transform.position);
                    Number.SetActive(false);
                }

                else//���h�q�łȂ��Ȃ�Tag��ύX����
                {
                    Number.tag = "First";
                }

            }
            else
            {
                if (Number.CompareTag("Question"))//1��ڈȍ~�ŃN�b�L�[�Ȃ�Tag��ύX����
                {
                    Number.tag = "Vanish";
                    //Debug.Log("S");
                }

                if (Number.CompareTag("Bom"))//1��ڈȍ~�œ��h�q�Ȃ玞�Ԃ��~�߁A�񐔂����Z�b�g��3�b��ɃQ�[���I�[�o�[�V�[���ֈڍs����
                {
                    bomsound++;
                    //Debug.Log("gameover");
                    c = 0;
                    Invoke("gameover", 1.0f);
                }
            }

        }
    }

    public void gameover()//scene���ړ����^�C����0�ɂ���
    {
        SceneManager.LoadScene("GameOver");
        //Jugment.clear = 0;
        Timecount.counttime = 0.00f;
    }
}
