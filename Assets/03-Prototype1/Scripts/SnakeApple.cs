using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeApple : MonoBehaviour
{

    public GameObject head;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == head)
        {
            SnakeController snakeController = collider.transform.parent.GetComponent<SnakeController>();
            snakeController.AddBodyPart();
            Destroy(gameObject);
        }
    }
}
