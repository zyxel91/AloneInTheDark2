using UnityEngine;
using UnityEngine.SceneManagement;

public class TextActivate : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Skip;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 0.01f;
        if (timer > 2) {
            Text1.SetActive(true);
            Skip.SetActive(true);
        }
        if (timer > 4) {
            Text2.SetActive(true);
        }
    }
    public void SkipCutSc1_1(){
        SceneManager.LoadScene("TestScene");
    }
    public void SkipCutSc2_1(){
        SceneManager.LoadScene("Level2");
    }
    public void SkipCutSc3_1(){
        SceneManager.LoadScene("Level3");
    }
}
