using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    [SerializeField] Transform PlayerCamera;

    [SerializeField] private GameObject player;

    [SerializeField] private AmmoController usableAmmo;

    //[SerializeField]
    //private TrailRenderer BulletTrail;
    private void Start()
    {
        PlayerCamera = UnityEngine.Camera.main.transform;
        usableAmmo = player.GetComponent<AmmoController>();
    }


    public void Shoot()
    {
        if (usableAmmo.ammoInGun > 0)
        {
            usableAmmo.ammoInGun -= 1;
            RaycastHit hitInfo;
            Physics.Raycast(PlayerCamera.position, PlayerCamera.forward, out hitInfo);
            Debug.Log(hitInfo.collider.name);
            Entity enemy = hitInfo.collider.GetComponent<Entity>();
            if (enemy != null)
            {
                Debug.Log("Hit " + enemy.name);
            }
            else
            {
                Debug.Log("Miss");
            }
        }
    }
}
