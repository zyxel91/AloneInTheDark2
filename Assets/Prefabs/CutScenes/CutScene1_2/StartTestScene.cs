using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTestScene : MonoBehaviour
{
    void Update()
    {
        Invoke("LoadScene", 5f);
    }

    public void LoadScene (){
        SceneManager.LoadScene("TestScene");
    }
}
