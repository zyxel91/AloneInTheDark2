
using UnityEngine;
using UnityEngine.UI;
public class KeyCount : MonoBehaviour
{
    private Text KeyCounter;
    public GameObject _KeyText;
    void Start()
    {
       KeyCounter = GetComponent<Text>();
    }
    void Update()
    {
        {
        KeyCounter.text = "X" + KeyCollect._keys;
        }
    }
}
