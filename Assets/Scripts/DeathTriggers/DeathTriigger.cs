
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTriigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player") {
            CoinCount.coins = 0;
        KeyCollect._keys = 0;
        FuelBatterCount.Battery = 0;
        SceneManager.LoadScene("Level3");
        }
    }
}
