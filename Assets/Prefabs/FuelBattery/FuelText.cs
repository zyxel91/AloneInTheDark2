using UnityEngine;
using UnityEngine.UI;
public class FuelText : MonoBehaviour
{
   private Text Fuelounter;
    //public GameObject FuelcText;
    void Start()
    {
       Fuelounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        {
        Fuelounter.text = "X" + FuelBatterCount.Battery;
        }
    }
}
