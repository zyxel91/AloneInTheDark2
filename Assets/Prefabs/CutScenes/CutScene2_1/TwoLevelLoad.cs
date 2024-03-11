using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoLevelLoad : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "SpaceShip") {
            SceneManager.LoadScene("Level2");
        }
    }
}
