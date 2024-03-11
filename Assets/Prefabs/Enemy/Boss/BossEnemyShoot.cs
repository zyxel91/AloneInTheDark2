using UnityEngine;

public class BossEnemyShoot : MonoBehaviour
{
   public Transform firePos1; 
   public Transform firePos2;
   public Transform firePos3;
   public Transform firePos4;
   public Transform firePos5;
    public GameObject leftbulletPrefab; 
    public GameObject rightbulletPrefab; 
    public GameObject upbulletPrefab; 
    private float shootingRate = 2f;
    public float shotingSpeed = 2f;
    private float nextShootTime; 
  
    
    public void Shoot()
    {
        
        if (Time.time > nextShootTime)
        {
            nextShootTime = Time.time + shotingSpeed / shootingRate;

            GameObject bullet = Instantiate(leftbulletPrefab, firePos1.position, firePos1.rotation);
            GameObject bullet1 = Instantiate(rightbulletPrefab, firePos2.position, firePos2.rotation);
            GameObject bullet2 = Instantiate(upbulletPrefab, firePos3.position, firePos3.rotation);
            GameObject bullet3 = Instantiate(leftbulletPrefab, firePos4.position, firePos4.rotation);
            GameObject bullet4 = Instantiate(rightbulletPrefab, firePos5.position, firePos5.rotation);
        }
    }
}
