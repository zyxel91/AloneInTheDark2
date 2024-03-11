
using UnityEngine;

public class Platform1_5 : MonoBehaviour
{
   
    public Animator _anim;
   
    void Update()
    {
        if (switch1_5._Switch1_5 == 1) {  
            Invoke("PlatformUP", 2f);
        }
    }
        void PlatformUP(){
_anim.Play("PlatformSlideLeft");
        }
}
