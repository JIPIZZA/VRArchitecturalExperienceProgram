using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePortar2 : MonoBehaviour
{
    public AudioSource Firesound;
    public AudioSource FiresGuide;

    private void OnTriggerEnter(Collider player)
    {

        Debug.Log("FFG2");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("DD2");
            player.transform.position = new Vector3(-11, 5, 14);
           

            Firesound.Stop();
            FiresGuide.Stop();
            Firesound.gameObject.SetActive(false);
            FiresGuide.gameObject.SetActive(false);
        }
    }
}

