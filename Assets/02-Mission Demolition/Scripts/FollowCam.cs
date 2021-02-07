using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
    static public GameObject POI; // The static point of interest 

    [Header("Set Dynamically")]
    public float camZ; // The desired Z pos of the camera 

    void Awake() {
        camZ = this.transform.position.z; 
    }


}
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
