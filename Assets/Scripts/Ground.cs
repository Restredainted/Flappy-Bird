using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Ground : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
        
        //Used to find test for correct value for transform, 
        //Debug.Log("Vector3.left.x: " + Vector3.left.x);
        //Debug.Log(transform.position.x);


        if(transform.position.x <= -2) {
            
        }
    }
}
