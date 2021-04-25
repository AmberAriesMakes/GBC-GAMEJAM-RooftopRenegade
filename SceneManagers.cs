using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
   
    public GameObject PauseWindow;
    bool isclicked;

    // Start is called before the first frame update
    void Start()
    {
       
        isclicked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void Unpause()
    {
        PauseWindow.SetActive(false);
        Time.timeScale = 1;
      
    }
   
  
}
