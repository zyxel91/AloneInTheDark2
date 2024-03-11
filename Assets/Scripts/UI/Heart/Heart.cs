
using UnityEngine;

public class Heart : MonoBehaviour
{
   public GameObject _heart;
   public GameObject _halfheart;
    void Update()
    {
        switch(PlayerLive._live){
            case 2:
            _heart.SetActive(false);
            _halfheart.SetActive(true);
                break;
            case 3:
            _heart.SetActive(true);
            break;
            case 1:
            _halfheart.SetActive(false);
            break;
        }
    }
}
