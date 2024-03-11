using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" && FuelBatterCount.Battery >= 3) {
            SceneManager.LoadScene("CutScene2_1");
        }
    }
    
}
