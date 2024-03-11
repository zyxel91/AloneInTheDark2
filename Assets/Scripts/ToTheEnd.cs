using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheEnd : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player" && FuelBatterCount.Battery >= 3) {
            SceneManager.LoadScene("Credits");
        }
    }
    
}
