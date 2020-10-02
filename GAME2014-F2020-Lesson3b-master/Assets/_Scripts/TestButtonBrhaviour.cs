using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBrhaviour : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel, ScoreLabel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("Test Button Pressed");
        LivesLabel.rectTransform.anchoredPosition = new Vector2(438.0f, -207.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -207.0f);
    }

}
