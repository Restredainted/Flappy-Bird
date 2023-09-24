using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerControl : MonoBehaviour
{
    float speed = 10f;
    public float maxHealth = 100f; 
    public float health = 100f;
    public Image healthBar;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World laptop test");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position += move * speed * Time.deltaTime;

        if (health <= 0) {
           //SceneManager.LoadScene(scene);
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            TakeDamage(20);
        }
        
        if (Input.GetKeyDown(KeyCode.Tab)) {
            Heal(20);
        }
    }
    
    public void TakeDamage(float damage) {
        health -= damage;
        healthBar.fillAmount = health / 100f;
    }

    public void Heal(float healing) {
        health += healing;
        health = Mathf.Clamp(health,0,100);

        healthBar.fillAmount = health / 100f;
    }




}
