using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public Slider slider;
    public Gradient Gradient;
    public Image Fill;

    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;

        Fill.color = Gradient.Evaluate(slider.normalizedValue);
    }

    public void SetHealth(int health) {
        slider.value = health;

        Fill.color = Gradient.Evaluate(slider.normalizedValue);
    }
}
