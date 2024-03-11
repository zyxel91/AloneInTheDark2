using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLive : MonoBehaviour
{
    public static int _live = 3;
    void Update() {
        if(_live == 0) {
            _live = 3;
        }
        //Debug.Log(_live);
    }
}
