using UnityEngine;

public class CoinsCreditMenu : MonoBehaviour
{
    public GameObject coinsToCreate;
    public Transform [] createPos;

    public float time = 0f;
    void Update()
    {
        time = time + 0.1f;
        if (time > 5.0f) {
            CreateCoins();
            time = 0f;
        }
    }

    public void CreateCoins() {
        Instantiate(coinsToCreate,createPos[RandomCoin()].position, createPos[RandomCoin()].rotation);
    }
    
    private int RandomCoin(){
       return
       Random.Range(0, createPos.Length);
        
    }
}
