using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Lever_Down : MonoBehaviour
{
    GameObject player;
    Animator anim;
    bool isPlayerEnter; // Player�� ���� �ȿ� �Դ����� �Ǻ��� bool Ÿ�� ����
    //public XRController controller = null;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("P");
        //anim = GetComponentInChildren<Animator>();
        anim = GetComponent<Animator>();
        isPlayerEnter = false;
    }

    void Update()
    {
        // �÷��̾ ���� �ȿ� �ְ� B��ư�� �����ٸ�
        if (isPlayerEnter)
        {
            // bool -> true
            anim.SetBool ("Down", true);
        }

    }
    // �ݶ��̴��� ���� ��ü�� (Ʈ���ſɼ��� üũ��)�ݶ��̴� ���� ������ ���԰� �װ� �÷��̾��� 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerEnter = true;
            Debug.Log("�÷��̾�� �浹");
        }
    }
    // �ݶ��̴��� ���� ��ü�� �ݶ��̴� ���� ������ ������ �� ��ü�� �÷��̾���
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerEnter = false;
        }
    }
}
