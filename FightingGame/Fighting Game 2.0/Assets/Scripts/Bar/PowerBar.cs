using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetPower(int power)
    {
        slider.value = power;
        fill.color=gradient.Evaluate(slider.normalizedValue);
    }
}
