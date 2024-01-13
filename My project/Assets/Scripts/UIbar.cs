using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    private Slider slider;

    public void ChangeBarMax(float maximo)
    {
        slider.maxValue = maximo;
    }

    public void ChangeBarCurrent(float currento)
    {
        slider.value = currento;
    }

    public void sumBar(float valor)
    {
        ChangeBarCurrent(slider.value + valor);
    }

    public void BarInitialize(float valor)
    {
        slider = GetComponent<Slider>();
        ChangeBarMax(valor);
        ChangeBarCurrent(valor);
    }
}
