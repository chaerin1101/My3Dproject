using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt(); // 화면에 띄워줄 프롬프트에 관련된 함수
    public void OnInteract(); // 인터렉트 됐을 때 어떤 효과를 발생시키게 할건지
}

public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data; // 상호작용 할때 필요한 기능을 넣어줄 것입니다.

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        CharacterManager.Instance.Player.itemData = data;
        CharacterManager.Instance.Player.addItem?.Invoke();
        Destroy(gameObject);
    }
}
