
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform[] SpawnPos;
    private int randomSpot;
    private float waitTime;
    private float StartwaitTime;
    public float speed;
    void Start()
    {
        waitTime = StartwaitTime;
        randomSpot = Random.Range(0, SpawnPos.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, SpawnPos[randomSpot].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, SpawnPos[randomSpot].position) < 0.2f) {
            if (waitTime <= 0) {
                waitTime = StartwaitTime;
                randomSpot = Random.Range(0, SpawnPos.Length);
            } else {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
