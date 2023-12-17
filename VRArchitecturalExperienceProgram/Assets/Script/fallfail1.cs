using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallfail1 : MonoBehaviour
{
    public AudioSource fallSound;
    

    private void Start()
    {
        // 게임 시작 시에는 fallSound 오디오 소스를 비활성화합니다.
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