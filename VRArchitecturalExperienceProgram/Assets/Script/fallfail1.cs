using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallfail1 : MonoBehaviour
{
    public AudioSource fallSound;
    

    private void Start()
    {
        // ���� ���� �ÿ��� fallSound ����� �ҽ��� ��Ȱ��ȭ�մϴ�.
        fallSound.Stop();
        fallSound.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.name == "Player")
        {
            
           

            fallSound.gameObject.SetActive(true);
            fallSound.Play();

            player.transform.position = new Vector3(75, 30, -5);
        }
    }
}