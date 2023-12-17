using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectPortal2 : MonoBehaviour
{
    public AudioSource Electsound;
    public AudioSource ElectsGuide;

    private void OnTriggerEnter(Collider player)
    {
        Debug.Log("EEG2");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("EE2");
            player.transform.position = new Vector3(-14, 5, -6);
            Electsound.gameObject.SetActive(false);
            ElectsGuide.gameObject.SetActive(false);

        }
    }
}
