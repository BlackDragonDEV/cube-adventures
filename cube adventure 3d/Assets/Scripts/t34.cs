using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t34 : MonoBehaviour
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
        xzTarget.z = player.transform.position.z;
        xz.z = xzTarget.z;
        transform.position = xz;
    }
}
