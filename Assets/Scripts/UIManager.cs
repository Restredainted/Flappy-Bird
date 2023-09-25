using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Tutorial used for score system available at https://levelup.gitconnected.com/ease-of-building-ui-elements-in-unity-4f501c7e7c5e
public class UIManager : MonoBehaviour
{
    private int _score;
    private int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0;
        Debug.Log("o");
    }

    // Update is called once per frame
    void Update()
    {
        //Increases score every 30 seconds 
        frame++;
        if (frame % 30 == 0) {
            _score += 1;
        }
                
        _scoreText.text = "Score: " + _score.ToString();    
        //Debug score output
        //Debug.Log(_score);
        
    }

    [SerializeField]
    private Text _scoreText;

    //unused as generative score system used in Flappy Bird
    void addScore(int addedScore) {
        _score += addedScore;
    }

}
