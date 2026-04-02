using UnityEngine;

public class AddWeapon : MonoBehaviour
{
    [SerializeField] private GameObject PlayerWeapon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUpWeapon()
    {
        PlayerWeapon.SetActive(true);
    }
}
