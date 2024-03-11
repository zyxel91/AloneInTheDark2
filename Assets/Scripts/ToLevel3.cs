using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" && FuelBatterCount.Battery >= 0) {
            SceneManager.LoadScene("CutScene3_1");
        }
    }
    
}
