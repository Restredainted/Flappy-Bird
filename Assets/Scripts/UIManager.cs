using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Tutorial used for score system available at https://levelup.gitconnected.com/ease-of-building-ui-elements-in-unity-4f501c7e7c5e
public class UIManager : MonoBehaviour
{
    
    private static int _score, frame;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0;
        frame = 0;
        Debug.Log("Score start");
    }

    // Update is called once per frame
    void Update()
    {
        //Increases score every 30 seconds 
        frame++;
        
                
        _scoreText.text = "Score: " + _score.ToString();    
        //Debug score output
        //Debug.Log(_score);
        
    }

    [SerializeField]
    private Text _scoreText;

    //unused as generative score system used in Flappy Bird
    public static void addScore(int addedScore) {
        if (frame % 30 == 0) {
            _score += addedScore;
        }
    }

}
