using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallfail : MonoBehaviour
{

    private void OnTriggerEnter(Collider player)
    {

        Debug.Log("FFG");
        if (player.gameObject.name == "Player")
        {
            Debug.Log("DD");
            player.transform.position = new Vector3(74, 31, -5);
        }
    }
}