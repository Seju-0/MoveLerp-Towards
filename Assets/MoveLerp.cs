using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    public Transform startPoint; 
    public Transform endPoint;
    public float speed;

    private float startTime;
    private float journeyLength;

    void Start()
    {
        startTime = Time.time;

        journeyLength = Vector3.Distance(startPoint.position, endPoint.position);
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;

        float fracJourney = distCovered / journeyLength;

        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, fracJourney);
    }
}
