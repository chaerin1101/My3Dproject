using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    // 컨디션에 필요한 값들
    public float curValue; // 현재바의 상태를 정해줄 수 있는 현재값
    public float startValue; // 시작하는 값
    public float maxValue; // 상태의 최대값
    public float passiveValue; // 주기적으로 변하는 값 (시간에 따라 줄어들고 회복하는 값)
    public Image uiBar;

    void Start()
    {
        curValue = startValue; // 게임을 저장하고 다시 시작할때 저장해놓은 값
    }

    void Update() // ui업데이트
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
