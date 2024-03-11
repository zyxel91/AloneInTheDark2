using UnityEngine;
using UnityEngine.SceneManagement;

public class OneLevelLoad : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "SpaceShip") {
            SceneManager.LoadScene("CutScene1_2");
        }
    }
}
