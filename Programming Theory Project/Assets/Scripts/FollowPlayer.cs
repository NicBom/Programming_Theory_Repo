using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    Vector3 offset;
    float turnSpeed = 0.75f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = new Vector3(0,5,-10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * turnSpeed, Vector3.up) * offset;
        transform.LookAt(player.transform.position);
    }
}
