using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item")]
public class InteractableData : ScriptableObject

{
    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    [SerializeField] private Sprite itemIcon;
}
