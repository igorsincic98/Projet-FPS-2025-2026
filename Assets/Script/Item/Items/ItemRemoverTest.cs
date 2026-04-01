using System;
using Unity.VisualScripting;
using UnityEngine;

public class ItemRemoverTest : MonoBehaviour
{
    [SerializeField] private InteractableData _itemData;
    [SerializeField] private InventoryManager _inventoryManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            _inventoryManager.RemoveItem(_itemData);
            Destroy(gameObject);
        }
    }
}