using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public ItemSlot[] slots; // ������ ���Կ� ���� �⺻������

    public GameObject inventoryWindow; // �κ��丮 â
    public Transform slotPanel;

    [Header("Select Item")] // ������������ �������� �ؽ�Ʈ�� ����
    public TextMeshProUGUI selectedItemName;
    public TextMeshProUGUI selectedItemDescription;
    public TextMeshProUGUI selectedStatName;
    public TextMeshProUGUI selectedStatValue;
    public GameObject useButton; // on/off
    public GameObject equipButton; // ����
    public GameObject unequipeButton; // ��������
    public GameObject dropButton; // ������

    private PlayerController controller;
    private PlayerCondition condition;

    // Start is called before the first frame update
    void Start()
    {
        controller = CharacterManager.Instance.Player.controller;
        condition = CharacterManager.Instance.Player.condition;

        controller.inventory += Toggle;

        inventoryWindow.SetActive(false);
        slots = new ItemSlot[slotPanel.childCount]; // �����ǳ� ���� �ڽ��� ����

        for(int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<ItemSlot>(); // 0~13��°����
            slots[i].index = i;
            slots[i].inventory = this; // �κ��丮�� �κ��丮 �ڱ��ڽ� �ֱ�
        }

        ClearSelectedItemWindow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClearSelectedItemWindow() // ������ �ʹ� ���Ƽ� �Լ��� �����
    {
        selectedItemName.text = string.Empty;
        selectedItemDescription.text = string.Empty;
        selectedStatName.text = string.Empty;
        selectedStatValue.text = string.Empty;

        useButton.SetActive(false); // ��ư�� ���ֱ�
        equipButton.SetActive(false);
        unequipeButton.SetActive(false);
        dropButton.SetActive(false);
    }

    public void Toggle() // �κ��丮 â �����״��ϱ�
    {
        if (IsOpen())
        {
            inventoryWindow.SetActive(false);
        }
        else
        {
            inventoryWindow.SetActive(true);
        }
    }

    public bool IsOpen()
    {
        return inventoryWindow.activeInHierarchy;
    }
}
