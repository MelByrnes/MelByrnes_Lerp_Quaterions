using Unity.Mathematics;
using UnityEngine;

public class followTarget : MonoBehaviour
{
    Vector3 relativePos;
    Quaternion targetRotation;
    public Transform target;
    public float speed = 0.1f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            relativePos = target.position - transform.position;
            targetRotation = Quaternion.LookRotation(relativePos);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.time * speed);




    }
}
