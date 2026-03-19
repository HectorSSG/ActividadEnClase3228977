using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider sliderController;
    public float sliderValue;
    void Start()
    {
        sliderController.value = sliderValue;
    }
}
