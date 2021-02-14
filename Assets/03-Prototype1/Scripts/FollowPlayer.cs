using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject launchPoint;
    public GameObject playerBall;

    [Header("Set Dynamically")]

    public Vector3 launchPos;
    public Transform launchPointTrans;
    public Transform plyaerPointTrans;

    //Start is called before the first frame update
    void Start()
    {

    }
    void Awake() {
        // S = this; 

        launchPoint.SetActive(false);
    }
    //void OnMouseEnter() {
    //   launchPoint.SetActive(true);
    // }
    // void OnMouseExit() {
    //   launchPoint.SetActive(false);
    // }
    //Update is called once per frame
    void Update() 
    {
        Vector3 playerPos = playerBall.transform.position;
        launchPoint.transform.position = playerPos;
    }
}