using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool Gameispaused = false;    
    public GameObject pauseMenuUI;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
       pauseMenuUI.SetActive(true);
       Time.timeScale =0f;
       Gameispaused = true;
    }
    public void Resume()
    {
       pauseMenuUI.SetActive(false);
       Time.timeScale =1f;
       Gameispaused = false;
    }
    public void backtomenu()
    {     
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
