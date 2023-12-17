using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalController : MonoBehaviour
{
    public AudioClip npcVoiceClip;  // NPC 음성 파일
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
            // 포탈에 플레이어가 접촉했을 때 NPC 음성 대사 재생
            npcAudioSource.PlayOneShot(npcVoiceClip);
        }
    }
    // Update is called once per frame

}

