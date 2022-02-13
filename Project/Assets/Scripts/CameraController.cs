using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 point = new Vector3(player.position.x + offset.x, player.position.y + offset.y, -10);
        this.transform.position = Vector3.SmoothDamp(transform.position, point, ref velocity, 0.15f);    
    }
}
