using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject _fire;
    public GameObject _Rightfire;
    public Transform _PlaceFire;
    public Transform _RightPlaceFire;
    private float myTime;
    private int FireCount;
    public static int FireNum = 1;
    public static float TimeNum = 0.2f;

    private bool CanFire = true;
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.LeftShift) && TakeObjects.pos == Vector2.right && CanFire == true) {
         Instantiate(_fire, _PlaceFire.transform.position, transform.rotation);
         FireCount++;
       }
       if (Input.GetKeyDown(KeyCode.LeftShift)&& TakeObjects.pos == Vector2.left && CanFire == true) {
        Instantiate(_Rightfire, _RightPlaceFire.transform.position, transform.rotation);
        FireCount++;
       }
       Debug.Log(FireCount);
                
                    if (FireCount >= FireNum) {
                        CanFire = false;
                    }
                    if (CanFire == false) {
                        myTime = myTime + Time.deltaTime;
                        Debug.Log(myTime);
                    }
                    if (myTime > TimeNum) {
                        CanFire = true;
                        FireCount = 0;
                        myTime = 0;
                        FireNum = 1;
                        TimeNum = 0.2f;
                    }
                }
    }
