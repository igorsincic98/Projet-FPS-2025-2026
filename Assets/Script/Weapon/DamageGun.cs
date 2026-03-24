using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;
    //[SerializeField]
    //private TrailRenderer BulletTrail;
    private void Start()
    {
        PlayerCamera = UnityEngine.Camera.main.transform;
    }


    public void Shoot()
    {
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        if (Physics.Raycast(gunRay, out RaycastHit hitInfo, BulletRange))
        {
            //TrailRenderer trail = Instantiate(BulletTrail, PlayerCamera.position, Quaternion.identity);
            if (hitInfo.collider.gameObject.TryGetComponent(out Entity enemy))
            {
                Debug.Log("Hit");
                enemy.TakeDamage(Damage);
                enemy.Health -= Damage;
            }
            else
            {
                Debug.Log("Miss");
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            }
        }

    }
}
