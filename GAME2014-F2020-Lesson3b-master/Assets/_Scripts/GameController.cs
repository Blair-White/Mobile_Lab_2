using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    // Start is called before the first frame update
    public TMP_Text LivesLabel, ScoreLabel;
    private bool hasSafeArea = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hasSafeArea = ((Screen.width == Screen.safeArea.width) && (Screen.height == Screen.safeArea.height)) ? false : true;
        {
            Debug.Log("No Safe Area");
            
        }    
        switch(Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                //SceneLabel.text = "Portrait";
                
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -200.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -200.0f);
                break;
            case ScreenOrientation.LandscapeLeft:
                //SceneLabel.text = "LandScape Left";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(438.0f, -207.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -207.0f);
                break;
            case ScreenOrientation.LandscapeRight:
                //SceneLabel.text = "LandScape Right";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(268.0f, -207.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-493.0f, -207.0f);
                break;
            case ScreenOrientation.Unknown:
                //SceneLabel.text = "Unknown";

                break;

            default:
                //SceneLabel.text = "Some Other Orientation(Default)";
                break;

        }    
    }
}
