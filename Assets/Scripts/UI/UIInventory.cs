using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public ItemSlot[] slots; // 아이템 슬롯에 대한 기본정보들

    public GameObject inventoryWindow; // 인벤토리 창
    public Transform slotPanel;

    [Header("Select Item")] // 정보세팅해줄 여러가지 텍스트와 정보
    public TextMeshProUGUI selectedItemName;
    public TextMeshProUGUI selectedItemDescription;
    public TextMeshProUGUI selectedStatName;
    public TextMeshProUGUI selectedStatValue;
    public GameObject useButton; // on/off
    public GameObject equipButton; // 장착
    public GameObject unequipeButton; // 장착해제
    public GameObject dropButton; // 버리기

    private PlayerController controller;
    private PlayerCondition condition;

    // Start is called before the first frame update
    void Start()
    {
        controller = CharacterManager.Instance.Player.controller;
        condition = CharacterManager.Instance.Player.condition;

        controller.inventory += Toggle;

        inventoryWindow.SetActive(false);
        slots = new ItemSlot[slotPanel.childCount]; // 슬롯판넬 기준 자식의 개수

        for(int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<ItemSlot>(); // 0~13번째까지
            slots[i].index = i;
            slots[i].inventory = this; // 인벤토리에 인벤토리 자기자신 넣기
        }

        ClearSelectedItemWindow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClearSelectedItemWindow() // 정보가 너무 많아서 함수로 만들기
    {
        selectedItemName.text = string.Empty;
        selectedItemDescription.text = string.Empty;
        selectedStatName.text = string.Empty;
        selectedStatValue.text = string.Empty;

        useButton.SetActive(false); // 버튼들 꺼주기
        equipButton.SetActive(false);
        unequipeButton.SetActive(false);
        dropButton.SetActive(false);
    }

    public void Toggle() // 인벤토리 창 껐다켰다하기
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
