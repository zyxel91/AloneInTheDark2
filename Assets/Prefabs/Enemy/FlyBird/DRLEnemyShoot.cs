using UnityEngine;

public class DRLEnemyShoot : MonoBehaviour
{
   public Transform firePointLeft; 
   public Transform firePointRight; 
   public Transform firePointDown; 
    public GameObject bulletPrefableft; 
    public GameObject bulletPrefabright; 
    public GameObject bulletPrefabdown; 
    private float shootingRate = 2f;
    public float shotingSpeed = 2f;
    private float nextShootTime; 
  
    
    public void Shoot()
    {
        
        if (Time.time > nextShootTime)
        {
            nextShootTime = Time.time + shotingSpeed / shootingRate;

            GameObject bulletleft = Instantiate(bulletPrefableft, firePointLeft.position, firePointLeft.rotation);
            GameObject bulletright = Instantiate(bulletPrefabright, firePointRight.position, firePointRight.rotation);
            GameObject bulletdown = Instantiate(bulletPrefabdown, firePointDown.position, firePointDown.rotation);
        }
    }
}
