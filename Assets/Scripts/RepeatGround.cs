using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class RepeatGround : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 startPos;
    private float width;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        width =  GetComponent<SpriteRenderer>().size.x;
        Debug.Log("GetComponent<SpriteRenderer>().size.x " + GetComponent<SpriteRenderer>().size.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
        
        //Used to find test for correct value for transform, 
        //Debug.Log("Vector3.left.x: " + Vector3.left.x);
        //Debug.Log(transform.position.x);


        if(transform.position.x <= startPos.x - width)  {
            transform.position = startPos;
        }

        
    }
}
