using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderPercentage : MonoBehaviour
{
    public Slider slider;
    public TMP_Text percentageText;

    private void Start()
    {
        UpdatePercentage(slider.value);
    }

    public void UpdatePercentage(float value)
    {
        percentageText.text = Mathf.RoundToInt(value) + "%";
    }
}
