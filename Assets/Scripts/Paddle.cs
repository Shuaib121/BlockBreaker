using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float minX = 1.8f;
    [SerializeField] float maxX = 14.2f;
    [SerializeField] float screenWidthInUnits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosX = Mathf.Clamp(Input.mousePosition.x / Screen.width * screenWidthInUnits, minX, maxX);
        Vector2 paddlePos = new Vector2(mousePosX,transform.position.y);
        transform.position = paddlePos;
        
    }
}
