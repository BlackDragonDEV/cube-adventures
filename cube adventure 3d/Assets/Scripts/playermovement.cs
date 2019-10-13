using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public Rigidbody rb;
    public bool canclickcontrol = true;
    public bool hascolided = false;
    public bool forward = false;
    public bool backward = false;
    public bool left = false;
    public bool right = false;
    public bool canforward = true;
    public bool canbackward = true;
    public bool canleft = true;
    public bool canright = true;
    public int ForceMult = 200;
    public int t = 0;
    public bool canmove = true;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    public bool canrotate = true;
    public Transform MyWorld;
    public Transform WorldRotator;
    private float LerpTime = 5f;
    private float CurLerpTime = 0f;
    public bool EWasClicked = false;




    void FixedUpdate()

    {
        if (canmove == true)
        {
            if (hascolided == false)
            {
                 if (t == 1)
                {
                    this.transform.LookAt(t1.transform);
                }
                if (t == 2)
                {
                    this.transform.LookAt(t2.transform);
                }
                if (t == 3)
                {
                    this.transform.LookAt(t3.transform);
                }
                if (t == 4)
                {
                    this.transform.LookAt(t4.transform);
                }
                if (canclickcontrol == true)
                {
                    if (canforward == true)
                    {
                        if (Input.GetKey("w"))
                        {
                            canclickcontrol = false;
                            forward = true;
                        }
                    }
                }
                if (canclickcontrol == true)
                {
                    if (canbackward == true)
                    {
                        if (Input.GetKey("s"))
                        {
                            canclickcontrol = false;
                            backward = true;
                        }
                    }
                }
                if (canclickcontrol == true)
                {
                    if (canright == true)
                    {
                        if (Input.GetKey("d"))
                        {
                            canclickcontrol = false;
                            right = true;
                        }
                    }
                }
                if (canclickcontrol == true)
                {
                    if (canleft == true)
                    {
                        if (Input.GetKey("a"))
                        {
                            canclickcontrol = false;
                            left = true;
                        }
                    }
                }
                if (forward == true)
                {
                    canright = true;
                    canleft = true;
                    canbackward = true;
                    canforward = false;
                    GoForvard();
                }
                if (backward == true)
                {
                    canright = true;
                    canleft = true;
                    canforward = true;
                    canbackward = false;
                    GoBackward();
                }
                if (right == true)
                {
                    canbackward = true;
                    canleft = true;
                    canforward = true;
                    canright = false;
                    GoRight();
                }
                if (left == true)
                {
                    canright = true;
                    canforward = true;
                    canbackward = true;
                    canleft = false;
                    GoLeft();
                }
            }
        }
            if (hascolided == true)
            {
                rb.velocity = Vector3.zero;
                forward = false;
                backward = false;
                left = false;
                right = false;
                if (t == 1)
                {
                    this.transform.LookAt(t1.transform);
                }
                if (t == 2)
                {
                    this.transform.LookAt(t2.transform);
                }
                if (t == 3)
                {
                    this.transform.LookAt(t3.transform);
                }
                if (t == 4)
                {
                    this.transform.LookAt(t4.transform);
                }
                transform.Translate(0f, 0f, -0.04f);
                if (t == 1)
                {
                    this.transform.LookAt(t1.transform);
                }
                if (t == 2)
                {
                    this.transform.LookAt(t2.transform);
                }
                if (t == 3)
                {
                    this.transform.LookAt(t3.transform);
                }
                if (t == 4)
                {
                    this.transform.LookAt(t4.transform);
                }
                rb.velocity = Vector3.zero;
                hascolided = false;
                rb.velocity = Vector3.zero;
                canclickcontrol = true;
                rb.velocity = Vector3.zero;
            }
        if (Input.GetKeyDown("e"))
        {
            rb.velocity = Vector3.zero;
            forward = false;
            backward = false;
            left = false;
            right = false;
            canright = true;
            canleft = true;
            canforward = true;
            canbackward = true;
            rb.velocity = Vector3.zero;
            EWasClicked = true;
            canclickcontrol = true;
        }
        if (EWasClicked == true)
        {
            if (canrotate == true)
            {
                CurLerpTime += Time.deltaTime;
                if (CurLerpTime >= LerpTime)
                {
                    CurLerpTime = LerpTime;
                }
                float Pct = CurLerpTime / LerpTime;
                MyWorld.rotation = Quaternion.Lerp(MyWorld.rotation, WorldRotator.rotation, Pct);
            }
        }
    }
    void GoForvard()
    {
        t = 1;
        this.transform.LookAt(t1.transform);
        rb.AddForce(transform.forward * ForceMult * Time.deltaTime);
    }
    void GoBackward()
    {
        t = 2;
        this.transform.LookAt(t2.transform);
        rb.AddForce(transform.forward * ForceMult * Time.deltaTime);
    }
    void GoRight()
    {
        t = 4;
        this.transform.LookAt(t4.transform);
        rb.AddForce(transform.forward * ForceMult * Time.deltaTime);
    }

    void GoLeft()
    {
        t = 3;
        this.transform.LookAt(t3.transform);
        rb.AddForce(transform.forward * ForceMult * Time.deltaTime);
    }
    public void setcollision()
    {
        hascolided = true;
    }
}
