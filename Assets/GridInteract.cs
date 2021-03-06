using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(ItemGrid))]
public class GridInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    InventoryController inventoryController;
    ItemGrid itemGrid;
    private void Awake() {
        /*Find function isnt very efficient maybe use somethign else ?*/
        inventoryController = FindObjectOfType(typeof(InventoryController)) as InventoryController;
        itemGrid = GetComponent<ItemGrid>();
    }

    public void OnPointerEnter(PointerEventData eventData) {
        inventoryController.selectedItemGrid = itemGrid;
    }

    public void OnPointerExit(PointerEventData eventData) {
        inventoryController.selectedItemGrid = null;
    }
}
