using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
   public Transform firePoint; 
    public GameObject bulletPrefab; 
    private float shootingRate = 2f;
    public float shotingSpeed = 2f;
    private float nextShootTime; 
  
    
    public void Shoot()
    {
        
        if (Time.time > nextShootTime)
        {
            nextShootTime = Time.time + shotingSpeed / shootingRate;

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
