using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy2_1 : MonoBehaviour
{
    public string numberScene;
    public GameObject audioS;
    private void Awake() {
        DontDestroyOnLoad(audioS);
    }
    private void Update() {
        numberScene = SceneManager.GetActiveScene().name;
        if (numberScene == "Level2") {
                    Destroy(audioS);
        }
        
    }
}
