using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrackballCamera_sansZoom : MonoBehaviour 
{
    //public GameObject target;
    public float distance;
	
	public float distanceMin = 0f;
	public float distanceMax = 1000f;
	
    public float rx = 0;
    public float ry = 0;
	
	public float rxMin = 0f;
	public float rxMax = 90f;

    private bool dragging = false;
    private bool pinching = false;

    private Vector2 prevDraggingPosition;
    private float prevPinchingDistance = 0f;

    private float dragCoef = 0.125f;
    private float pinchCoef = 0.5f;

    private Queue<float> rxSpeedAccum = new Queue<float>(5);
    private Queue<float> rySpeedAccum = new Queue<float>(5);
    private Queue<float> distanceSpeedAccum = new Queue<float>(5);
    private int accumSize = 7;
	private float speedDiminishCoef = 0.7f;

  

    private void AccumulateRxSpeed(float last)
    {
        if (rxSpeedAccum.Count > accumSize)
            rxSpeedAccum.Dequeue();

        rxSpeedAccum.Enqueue(last);
    }

    private void AccumulateRySpeed(float last)
    {
        if (rySpeedAccum.Count > accumSize)
            rySpeedAccum.Dequeue();

        rySpeedAccum.Enqueue(last);
    }

    private void AccumulateDistanceSpeed(float last)
    {
        if (distanceSpeedAccum.Count > accumSize)
            distanceSpeedAccum.Dequeue();

        distanceSpeedAccum.Enqueue(last);
    }

    private float GetMean(Queue<float> queue)
    {
        
		if(queue.Count == 0)
			return 0;
		
        float t = 0;
        foreach (float f in queue)
            t += f;
        return t /= queue.Count;
    }


		
    #if UNITY_ANDROID || UNITY_IPHONE
	void Update () 
    {
        float screensizeCoef = 1024f / Mathf.Max(Screen.width, Screen.height);

        if (Input.touchCount == 2)
        {
            if (dragging == false)
            {
                dragging = true;
                pinching = false;
                prevDraggingPosition = Input.touches[0].position;
            }
        }
        //else if (Input.touchCount > 1)
        //{
        //    if(pinching == false)
        //    {
        //        dragging = false;
        //        pinching = true;
        //        prevPinchingDistance = (Input.touches[1].position - Input.touches[0].position).magnitude;
        //    }
        //}
        else
        {
         //   pinching = false;
            dragging = false;
        }

        if (dragging)
        {
            Vector2 touchPosition = Input.touches[0].position;

            float dry = dragCoef * (touchPosition.x - prevDraggingPosition.x) * screensizeCoef;
            float drx = -dragCoef * (touchPosition.y - prevDraggingPosition.y) * screensizeCoef;

            AccumulateRxSpeed(drx / Time.deltaTime);
            AccumulateRySpeed(dry / Time.deltaTime);

            ry += dry;
            rx += drx;
            prevDraggingPosition = touchPosition;
        }
   //     else if (pinching)
   //     {
   //         float pinchingDistance = (Input.touches[1].position - Input.touches[0].position).magnitude;
			//float dDistance = -pinchCoef * (pinchingDistance - prevPinchingDistance);// * screensizeCoef * (distanceMax - distanceMin) ;/// 430f;

   //         AccumulateDistanceSpeed(dDistance / Time.deltaTime);

   //         distance += dDistance;
   //         prevPinchingDistance = pinchingDistance;
   //     }
        else
        {
            float rxSpeed = GetMean(rxSpeedAccum);
            float rySpeed = GetMean(rySpeedAccum);
            float distanceSpeed = GetMean(distanceSpeedAccum);

            rx += rxSpeed * Time.deltaTime;
            ry += rySpeed * Time.deltaTime;
            distance += distanceSpeed * Time.deltaTime;
                
            AccumulateRxSpeed(rxSpeed * speedDiminishCoef);
            AccumulateRySpeed(rySpeed * speedDiminishCoef);
            AccumulateDistanceSpeed(distanceSpeed * speedDiminishCoef);
        }

        rx = Mathf.Clamp(rx, rxMin, rxMax);
        //distance = Mathf.Clamp(distance, distanceMin, distanceMax);
		
		//Vector3 p = Vector3.forward* -distance ;
        Quaternion rotation = Quaternion.Euler(rx, ry, 0);
        //p = rotation * p;

		//this.transform.position = p;
		this.transform.rotation = rotation;
		//this.GetComponent<Camera>().orthographicSize =  distance;
	}
    #else
    void Update()
    {
        
        if (this.GetComponent<Camera>().rect.Contains(Input.mousePosition.normalized))
		{

	        float screensizeCoef = 1024f / Mathf.Max(Screen.width, Screen.height);

	        if (Input.GetMouseButton(0))
	        {
	            if (dragging == false)
	            {
	                dragging = true;
	                pinching = false;
	                prevDraggingPosition = Input.mousePosition;
	            }
	        }
	        else
	        {
	            pinching = false;
	            dragging = false;
	        }

	        if (dragging)
	        {
	            Vector2 mousePosition = Input.mousePosition;

	            float dry = dragCoef * (mousePosition.x - prevDraggingPosition.x) * screensizeCoef;
	            float drx = -dragCoef * (mousePosition.y - prevDraggingPosition.y) * screensizeCoef;

	            AccumulateRxSpeed(drx / Time.deltaTime);
	            AccumulateRySpeed(dry / Time.deltaTime);

	            ry += dry;
	            rx += drx;
	            prevDraggingPosition = mousePosition;
	        }
	        else
	        {
	            float rxSpeed = GetMean(rxSpeedAccum);
	            float rySpeed = GetMean(rySpeedAccum);
	            float distanceSpeed = GetMean(distanceSpeedAccum);

	            rx += rxSpeed * Time.deltaTime;
	            ry += rySpeed * Time.deltaTime;
	            distance += distanceSpeed * Time.deltaTime *10;

	            AccumulateRxSpeed(rxSpeed * speedDiminishCoef);
	            AccumulateRySpeed(rySpeed * speedDiminishCoef);
	            AccumulateDistanceSpeed(distanceSpeed * speedDiminishCoef);
	        }

	        AccumulateDistanceSpeed(Input.GetAxis("Mouse ScrollWheel") * - 2f / Time.deltaTime * pinchCoef);

	        rx = Mathf.Clamp(rx, rxMin, rxMax);
	        distance = Mathf.Clamp(distance , distanceMin, distanceMax);

	        Vector3 p = Vector3.forward * -distance;
            //Debug.Log(rx);
            //Debug.Log(ry);
	        Quaternion rotation = Quaternion.Euler(rx, ry, 0);
            //Quaternion rotation = Quaternion.Euler(45, 45, 0);
	        p = rotation * p;

	        //this.transform.position = target.transform.position + p  ;
	        this.transform.rotation = rotation;
			this.GetComponent<Camera>().orthographicSize =  distance;
		}
    }
    #endif


}
