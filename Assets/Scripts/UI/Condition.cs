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

    void Update()
    {
        // ui������Ʈ
    }


}
