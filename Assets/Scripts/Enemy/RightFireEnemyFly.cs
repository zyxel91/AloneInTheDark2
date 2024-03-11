
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightFireEnemyFly : MonoBehaviour
{
   public float speed = 7.0f;

 
    private void Update()
    {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

public void OnCollisionEnter2D(Collision2D collision) {
    if(collision.gameObject.tag == "Player"){
    Destroy(gameObject);
    if (PlayerLive._live == 1) {
        CoinCount.coins = 0; 
        SceneManager.LoadScene("TestScene");
    }
    PlayerLive._live--;
}
 if(collision.gameObject.tag == "Tilemap"){
    Destroy(gameObject);
}
if(collision.gameObject.tag == "Fire"){
    Destroy(gameObject);
}
}
}
 