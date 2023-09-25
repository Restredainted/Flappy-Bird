using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private int _score;
    private int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        if (frame % 30 == 0) {
            _score += 1;
        }
                
        _scoreText.text = "Score: " + _score.ToString();    
        Debug.Log(_score);
        
    }

    [SerializeField]
    private Text _scoreText;

    void addScore(int addedScore) {
        _score += addedScore;
    }

}
