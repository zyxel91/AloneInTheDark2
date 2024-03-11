using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMenu : MonoBehaviour
{
  
    public GameObject pauseMenuUI; 
    public GameObject HelpPanelStart;
    //public Text timeText; 
    private bool isPaused = false; 

    private void Awake() {
        Time.timeScale = 0.0f; 
        HelpPanelStart.SetActive(true);
    }

    public void Continue(){
        Time.timeScale = 1.0f; 
        HelpPanelStart.SetActive(false);
    }

    public void HelpMenuActive(){
        HelpPanelStart.SetActive(true);
    }
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            if (isPaused) 
            { 
                Resume(); 
            } 
            else 
            { 
                Pause(); 
            } 
        } 
    } 
     
    public void Resume() 
    { 
        pauseMenuUI.SetActive(false); 
        Time.timeScale = 1.0f; 
        isPaused = false; 
    } 
     
    void Pause() 
    { 
        pauseMenuUI.SetActive(true); 
        Time.timeScale = 0.0f; 
        isPaused = true; 
    } 
     
    public void QuitGame() 
    { 
       Application.Quit();  
    } 


public void PlayPressed() {
        SceneManager.LoadScene(0);
        
    }    


    
}
