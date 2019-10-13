using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{   public playermovement playermovement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            playermovement = GameObject.FindObjectOfType<playermovement>();
            playermovement.setcollision();
        }
    }
}
