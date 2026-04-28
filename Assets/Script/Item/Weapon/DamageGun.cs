using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class DamageGun : MonoBehaviour
{
    public float _damage;
    public float _bulletRange;
    [SerializeField] Transform _playerCamera;

    [SerializeField] private GameObject _player;

    [SerializeField] private AmmoController _usableAmmo;

    //[SerializeField]
    //private TrailRenderer BulletTrail;
    private void Start()
    {
        _playerCamera = UnityEngine.Camera.main.transform;
        _usableAmmo = _player.GetComponent<AmmoController>();
    }


    public void Shoot()
    {
        if (_usableAmmo.ammoInGun > 0)
        {
            _usableAmmo.ammoInGun -= 1;
            RaycastHit hitInfo;
            if (Physics.Raycast(_playerCamera.position, _playerCamera.forward, out hitInfo, _bulletRange))
            {

                Debug.Log(hitInfo.collider.name);
                Entity enemy = hitInfo.collider.GetComponent<Entity>();
                if (enemy != null)
                {
                    enemy.TakeDamage(1);
                }
                else
                {
                    Debug.Log("Miss");
                }
            }
        }
    }
}
