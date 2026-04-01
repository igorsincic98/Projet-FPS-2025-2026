using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeypadController : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;
    private bool doorOpen = false;
    [SerializeField] private float doorCooldownRate = 1f;
    public float doorCooldown = 0f;
    public bool doorProcessing = false;
    [SerializeField] private GameObject inventory;
    [SerializeField] private List<InteractableData> keyItem;


    private void Start()
    {
        keyItem = inventory.GetComponent<InventoryManager>().inventoryItems;
    }

    public void Interact()
    {
        for (int i = 0; i < keyItem.Count; i++)
        {
            if (keyItem[i].itemName == "Key Card")
            {
                if (!doorOpen && !doorProcessing)
                {
                    doorAnim.Play("Open", 0, 0f);
                    doorOpen = true;
                    StartCoroutine(StartDoorCooldown());
                    break;
                }
                else if (doorOpen && !doorProcessing)
                {
                    doorAnim.Play("Close", 0, 0f);
                    doorOpen = false;
                    StartCoroutine(StartDoorCooldown());
                    break;
                }
            }
        }
    }

    IEnumerator StartDoorCooldown()
    {
        doorCooldown = doorCooldownRate;
        doorProcessing = true;
        yield return new WaitForSeconds(doorCooldown);
        doorProcessing = false;

    }
}

