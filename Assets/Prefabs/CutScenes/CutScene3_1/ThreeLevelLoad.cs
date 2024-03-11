using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeLevelLoad : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "SpaceShip") {
            SceneManager.LoadScene("Level3");
        }
    }
}
