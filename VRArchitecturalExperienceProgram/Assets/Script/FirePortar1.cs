using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePortar1 : MonoBehaviour
{

    public AudioSource  Firesound;
    public AudioSource  FiresGuide;

    private void Start()
    {
        // 게임 시작 시에는 fallSound 오디오 소스를 비활성화합니다.
        Firesound.Stop();
        FiresGuide.Stop();
        Firesound.gameObject.SetActive(false);
        FiresGuide.gameObject.SetActive(false);

    }
    private void OnTriggerEnter(Collider player)
    {

        Debug.Log("FFG");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("DD");
            player.transform.position = new Vector3(53, 5, 38);
            Firesound.gameObject.SetActive(true);
            FiresGuide.gameObject.SetActive(true);
            Firesound.Play();
            FiresGuide.Play();



        }
    }
}
