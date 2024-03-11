
using UnityEngine;
using UnityEngine.SceneManagement;

public class DFireEnemyFlylvl2 : MonoBehaviour
{
   public float speed = 7.0f;

 
    private void Update()
    {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

public void OnCollisionEnter2D(Collision2D collision) {
    if(collision.gameObject.tag == "Player"){
    Destroy(gameObject);
    if (PlayerLive._live == 1) {
        CoinCount.coins = 0;
        KeyCollect._keys = 0;
        FuelBatterCount.Battery = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("Level2");
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
 