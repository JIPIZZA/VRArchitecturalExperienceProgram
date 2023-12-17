using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalController : MonoBehaviour
{
    public AudioClip npcVoiceClip;  // NPC ���� ����
    private AudioSource npcAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        npcAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ��Ż�� �÷��̾ �������� �� NPC ���� ��� ���
            npcAudioSource.PlayOneShot(npcVoiceClip);
        }
    }
    // Update is called once per frame

}

