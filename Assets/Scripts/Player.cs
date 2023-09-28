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
    public SC_Game_Manager gameManager;
    public bool isDead = false;
    private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rbody.velocity = Vector2.up * velocity;
        }
        //For touch devices can us Input.getTouch


        UIManager.addScore(1);

    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("player onCollisionEnter2D");
        isDead = true;
        gameManager.gameOver();
    }

    
}
