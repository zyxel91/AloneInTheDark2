
using UnityEngine;

public class Platform1_3 : MonoBehaviour
{
   
    public Animator _anim;
   
    void Update()
    {
        if (switch1_3._Switch1_3 == 1) {  
            Invoke("PlatformDOWN", 2f);
        }
    }
        void PlatformDOWN(){
_anim.Play("Platform1_3Down");
        }
}
