using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ElectEffect : MonoBehaviour
{
    public GameObject m_Target;
    public GameObject m_Delete1;
    public GameObject m_Delete2;
    public GameObject m_Delete3;
    public AudioSource audioSource;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Electric"))
        {
            audioSource.Play(); //음원을 실행하는 부분
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == m_Target)
        {

            count++;
            if (count == 1)
            {
                Destroy(m_Delete1, 1f);
                Destroy(m_Delete2, 1f);
                Destroy(m_Delete3, 1f);
                count = 0;
            }
        }
    }
}