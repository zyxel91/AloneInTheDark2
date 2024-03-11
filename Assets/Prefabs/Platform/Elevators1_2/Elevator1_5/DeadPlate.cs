
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPlate : MonoBehaviour
{
    private float TimeCount = 0f;
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            TimeCount = TimeCount + 0.08f;
            Debug.Log(TimeCount);
        }

    }
private void Update() {
    if (TimeCount > 2.0f) {
                KillingPlayer();
            }
              if (PlayerLive._live == 0) {
            CoinCount.coins = 0;
        SceneManager.LoadScene("TestScene");
    }
            //PlayerLive._live--;
}
    void KillingPlayer(){
        PlayerLive._live--;
        TimeCount = 0;
    }
}
