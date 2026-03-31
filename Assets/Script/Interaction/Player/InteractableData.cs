using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item")]
public class InteractableData : ScriptableObject

{
    [SerializeField] public string itemName;
    [SerializeField] public string itemDescription;
    [SerializeField] public Sprite itemIcon;
}
