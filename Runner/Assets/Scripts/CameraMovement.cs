using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform playerPosition;
    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        //offset is the distance between the player(public Transform) and the camera (transform.position)./need to declare which tranform you want (position,rotation or scale ) to make it work with vector 3 .
        offSet = playerPosition.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //the position of the camera will be always updated to the player position and the distance will stay the same.
        transform.position = playerPosition.position - offSet;
    }
}
