using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] public static GameObject GameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        GameOverMenu = GetComponent<Canvas>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Activate(Boolean active) {
        GameOverMenu.SetActive(active);
    }
}
