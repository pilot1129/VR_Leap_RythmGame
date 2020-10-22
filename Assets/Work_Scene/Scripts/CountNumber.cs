using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountNumber : MonoBehaviour
{ // 메인 카메라에 넣어야 함

    public Text numberText; // 도달할 텍스트(숫자)
    public float animationTime = 1.5f; // 애니메이션 완성시간 1.5초(숫자 다 찰때까지)

    private float desiredNumber;
    private float initialNumber;
    private float currentNumber = 0; // 처음 0으로 초기화해야함

    public void SetNumber(float value) // 숫자를 받아와서 value 값을 넣으면 1.5초에 갱신이 완료됨
    {
        initialNumber = currentNumber;
        desiredNumber = value;

    } // 숫자 세팅


    //디버그용
    public void AddToNumber(float value)
    {
        initialNumber = currentNumber;
        desiredNumber += value;
    }

    public void Update()
    {
        if (currentNumber != desiredNumber)
        {
            if (initialNumber < desiredNumber)
            {
                currentNumber += (animationTime * Time.deltaTime) * (desiredNumber - initialNumber);
                if (currentNumber >= desiredNumber)
                    currentNumber = desiredNumber;
            }
            else
            {
                currentNumber -= (animationTime * Time.deltaTime) * (initialNumber - desiredNumber);
                if (currentNumber <= desiredNumber)
                    currentNumber = desiredNumber;
            }

            numberText.text = currentNumber.ToString("0");
        }
    }
}
