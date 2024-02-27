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
    public Slider alphaSlider;
    public GameObject toggleImage;
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

    public void ColorChange()
    {

            RGBImage.GetComponent<Image>().color = new Color(redSlider.value, greenSlider.value, blueSlider.value, alphaSlider.value);


    }

    public void OnOff()
    {
        if(toggleImage.activeSelf == false)
        {
            toggleImage.SetActive(true);
        }
        else if(toggleImage.activeSelf == true)
        {
            toggleImage.SetActive(false);
        }
    }
}
