using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public GameObject m_Target;
    public GameObject m_Effect;
    public GameObject m_Delete;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == m_Target)
        {
            GameObject effectObj = Instantiate(m_Effect, transform.position, transform.rotation);
            Destroy(effectObj, 2f);
            count++;
            if (count == 1)
            {
                Destroy(m_Delete, 2f);
                count = 0;
            }
        }
    }
}