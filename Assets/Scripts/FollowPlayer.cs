using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Vehicle");
    }

    // Update is called once per frame, LateUpdate later in the frame, after the vehicle has moved
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
