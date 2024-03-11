using UnityEngine;
using UnityEngine.UI;

public class LiveCount : MonoBehaviour
{
    //public int crystallCount;
    private Text LiveCounter;
    public GameObject _countText;
    // Start is called before the first frame update
    void Start()
    {
        LiveCounter = GetComponent<Text>();
        //crystallCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LiveCounter.text = "X" + PlayerLive._live;
        }
    
}
