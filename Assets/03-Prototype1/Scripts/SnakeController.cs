using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour { 
    public Transform head;
    public float moveSpeed, rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update() {
        head.position += head.forward * moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            head.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            head.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
