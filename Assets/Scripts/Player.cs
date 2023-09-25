using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]private float velocity = 2.4f;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rigidbody.velocity = Vector2.up * velocity;
        }
        //For touch devices can us Input.getTouch

        UIManager.addScore(1);

    }

    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("player onCollisionEnter2D");
        Time.timeScale = 0f;
        GameOver.GameOverMenu.SetActive(true);
    }

    void restart() {
        
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
