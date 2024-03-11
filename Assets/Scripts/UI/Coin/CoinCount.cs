
using UnityEngine;
using UnityEngine.UI;
public class CoinCount : MonoBehaviour
{
   public static int coins;
   private Text CoinCounter;
    public GameObject _countText;
    void Start()
    {
       CoinCounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        {
        CoinCounter.text = "X" + coins;
        }
    }
}
