using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;
    public GameObject miniMap;
    public GameObject charInfo;
    public GameObject characterInfo;

    Inventory inventory;

    InventorySlot[] slots;
    // Use this for initialization
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        miniMap = GameObject.Find("MinimapPanel");
        charInfo = GameObject.Find("CharInfo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            if (!inventoryUI.activeSelf || !characterInfo.activeSelf)
            {
                miniMap.SetActive(true);
                charInfo.SetActive(true);
            }
            else
            {
                miniMap.SetActive(false);
                charInfo.SetActive(false);

            }
        }
    }
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].RemoveItem();
            }
        }
    }
}
