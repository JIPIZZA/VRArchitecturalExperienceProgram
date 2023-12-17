using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectPortal1 : MonoBehaviour
{

    public AudioSource Electsound;
    public AudioSource ElectsGuide;

   
    private void Start()
    {
        // ���� ���� �ÿ��� fallSound ����� �ҽ��� ��Ȱ��ȭ�մϴ�.
        Electsound.Stop();
        ElectsGuide.Stop();
        Electsound.gameObject.SetActive(false);
        ElectsGuide.gameObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider player)
    {

        Debug.Log("EEG");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("EE");
            player.transform.position = new Vector3(53, 5, 12);
            Electsound.gameObject.SetActive(true);
            ElectsGuide.gameObject.SetActive(true);
            Electsound.Play();
            ElectsGuide.Play();
        }
    }
}

