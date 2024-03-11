using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy3_1 : MonoBehaviour
{
    public string numberScene;
    public GameObject audioS;
    private void Awake() {
        DontDestroyOnLoad(audioS);
    }
    private void Update() {
        numberScene = SceneManager.GetActiveScene().name;
        if (numberScene == "Level3") {
                    Destroy(audioS);
        }
        
    }
}
