using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t12 : MonoBehaviour
{
    public GameObject player;
    private Vector3 xz;
    private Vector3 xzTarget;
    void Start()
    {
        xz.x = transform.position.x;
        xz.y = transform.position.y;
        xz.z = transform.position.z;
    }
    void Update()
    {
        xzTarget.x = player.transform.position.x;
        xz.x = xzTarget.x;
        transform.position = xz;
    }
}
