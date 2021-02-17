using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
    static private FollowPlayer S;
    // fields set in the Unity Inspector pane
    [Header("Set in Inspector")]
    public GameObject launchPoint;
    public GameObject playerBall;
    public GameObject prefabApple;
    public float velocityMult = 8f;

    // fields set dynamically
    [Header("Set Dynamically")]
    public Vector3 launchPos;
    public GameObject apple;
    public Transform launchPointTrans;
    public Transform playerPointTrans;
    public bool aimingMode;
    private Rigidbody playerRigidbody;

    private Rigidbody appleRigidbody;

    static public Vector3 LAUNCH_POS
    {
        get
        {
            if (S == null) return Vector3.zero;
            return S.launchPos;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        // S = this;
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }

    void OnMouseEnter()
    {
        print("FollowPlayer:OnMouseEnter()");
        launchPoint.SetActive(true);
    }

    void OnMouseExit()
    {
        print("FollowPlayer:OnMouseExit()");
        launchPoint.SetActive(false);
    }

    void OnMouseDown()
    {
        // The player has pressed the mouse button while over Slingshot
        aimingMode = true;
        print("aiming mode true!");
        //Start it at the launchPoint
        playerBall.transform.position = launchPos;
        playerBall.GetComponent<Rigidbody>().isKinematic = true;
        playerRigidbody = playerBall.GetComponent<Rigidbody>();
        playerRigidbody.isKinematic = true;
        // Set it to isKinematic for now
        appleRigidbody = apple.GetComponent<Rigidbody>();
        appleRigidbody.isKinematic = true;
    }

    void OnTriggerEnter(Collider other) { 
        if (other.gameObject.CompareTag("Apple")) {
            // Instantiate a Apple
            Vector3 randomPos = new Vector3(Random.Range(-5.0f, 5.0f), 2.5f, Random.Range(-5.0f, 5.0f));
            other.transform.position = randomPos;
        }
    } 
}