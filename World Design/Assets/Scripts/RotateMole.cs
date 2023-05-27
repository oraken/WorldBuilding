using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMole : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform partToRotate;
    private float turnSpeed = 7f;
    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }
}
