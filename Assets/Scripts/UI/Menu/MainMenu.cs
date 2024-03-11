using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Settings;
    public static bool onePlayer;
    public static bool twoPlayer;
    
        public void PlayPressed(){
            onePlayer = true;
        Invoke("StartGame", 1f);
    }
    public void PlayPressed1(){
        twoPlayer = true;
        Invoke("StartGame", 1f);
    }
    public void PlayPressed2(){
        Invoke("StartGame", 1f);
    }
    public void StartGame(){
        SceneManager.LoadScene("CutScene1_1");
    }
    
        public void ExitPressed()
    {
        Invoke("ExitGame", 1f);
    }
    public void ExitGame(){
        Application.Quit();
    }
    public void SettingsMenu() {
        Settings.SetActive(true);
    }
}
