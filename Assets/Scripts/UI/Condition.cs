using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    // ����ǿ� �ʿ��� ����
    public float curValue; // ������� ���¸� ������ �� �ִ� ���簪
    public float startValue; // �����ϴ� ��
    public float maxValue; // ������ �ִ밪
    public float passiveValue; // �ֱ������� ���ϴ� �� (�ð��� ���� �پ��� ȸ���ϴ� ��)
    public Image uiBar;

    void Start()
    {
        curValue = startValue; // ������ �����ϰ� �ٽ� �����Ҷ� �����س��� ��
    }

    void Update() // ui������Ʈ
    {
        uiBar.fillAmount = GetPercentage();
    }

    float GetPercentage()
    {
        return curValue / maxValue;
    }

    public void Add(float value)
    {
        curValue = Mathf.Min(curValue + value, maxValue);
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0);
    }
}
