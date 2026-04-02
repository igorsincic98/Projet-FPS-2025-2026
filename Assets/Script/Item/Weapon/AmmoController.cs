using TMPro;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    [SerializeField] public int maxAmmo;
    [SerializeField] public int currentAmmo;
    [SerializeField] public int ammoInGun;
    [SerializeField] public int ammoSpace;
    [SerializeField] public int handgunCapacity = 6;
    [SerializeField] public GameObject ammoDisplay;
    private TextMeshProUGUI ammoText;
    public float reloadCountDown;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammoText = ammoDisplay.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = ammoInGun + "|" + currentAmmo;
        ammoSpace = handgunCapacity - ammoInGun;
        if (reloadCountDown > 0)
        {
            reloadCountDown -= Time.deltaTime;
        }
    }

    public void AddAmmo()
    {
        currentAmmo += Random.Range(1, 8);
    }

    public void ReloadHandGun()
    {
        if (reloadCountDown <= 0)
        {
            if (currentAmmo >= ammoSpace)
            {
                currentAmmo -= ammoSpace;
                ammoInGun += ammoSpace;
                reloadCountDown = 3f;

            }
            else
            {
                ammoInGun += currentAmmo;
                currentAmmo = 0;
                reloadCountDown = 3f;
            }
        }
    }
}
