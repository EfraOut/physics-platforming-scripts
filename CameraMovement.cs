using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class will take care of controlling the camera, and making
// sure that it is always looking at thte player on the X-axis
public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}
