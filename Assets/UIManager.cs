using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    int score;
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

    public void ScoreUpdate(string output)
    {
        if (output == "down")
        {
            score -= 1;
            Debug.Log("Score Down");
        }

        if (output == "up")
        {
            score += 1;
            Debug.Log("Score Up");
        }

        if (output == "reset")
        {
            score = 0;
            Debug.Log("Score Reset");
        }
        text.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
