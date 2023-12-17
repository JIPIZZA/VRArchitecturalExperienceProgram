using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 1
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    // 2
    public void Quit()
    {
        Application.Quit();
    }
}
