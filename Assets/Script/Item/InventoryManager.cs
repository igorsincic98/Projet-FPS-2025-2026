using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] public List<InteractableData> inventoryItems = new List<InteractableData>();
    [SerializeField] private GameObject itemSlot;
    [SerializeField] private Transform inventoryTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        UpdateSlots();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(InteractableData item)
    {
        inventoryItems.Add(item);
        UpdateSlots();
    }

    public void RemoveItem(InteractableData item)
    {
        inventoryItems.Remove(item);
        UpdateSlots();
    }

    public void UpdateSlots()
    {
        foreach (Transform child in gameObject.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (InteractableData item in inventoryItems)
        {
            GameObject itemDisplayed = Instantiate( itemSlot, inventoryTransform);
            itemDisplayed.GetComponent<Image>().sprite = item.itemIcon;
        }
    }

}
