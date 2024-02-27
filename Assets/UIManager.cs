using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    int score;
    public GameObject RGBImage;
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void ScoreUpdate(int value)
    {
        score += value;
        score = Mathf.Clamp(score,0, 999999999);
        if (value == 0)
        {
            score = 0;
        }
        text.GetComponent<TextMeshProUGUI>().text = score.ToString("N0");
    }

    public void ScoreRandom()
    {
        score += Random.Range(0, 999999999);
        score = Mathf.Clamp(score, 0, 999999999);
        text.GetComponent<TextMeshProUGUI>().text = score.ToString("N0");
    }

    public void ColorChange(string color)
    {
        Color currentColor = RGBImage.GetComponent<Image>().color;
        if (color == "red")
        {
            RGBImage.GetComponent<Image>().color = Color.Lerp(currentColor, Color.red, redSlider.value / 100);
        }        
        if (color == "green")
        {
            RGBImage.GetComponent<Image>().color = Color.Lerp(currentColor, Color.green, greenSlider.value / 100);
        }
        if (color == "blue")
        {
            RGBImage.GetComponent<Image>().color = Color.Lerp(currentColor, Color.red, blueSlider.value / 100);
        }


    }
}
