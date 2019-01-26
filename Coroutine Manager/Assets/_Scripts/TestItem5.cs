using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem5 : MonoBehaviour {

    [SerializeField] private Transform transformToZoom;
    [SerializeField] private Vector3 initialScale;
    [SerializeField] private Vector3 targetScale;
    [SerializeField] private float smoothTime;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float scaleError;
    private Coroutine cr_ScaleZoom;

	// Use this for initialization
	void Start () {
        CoroutineManager.BeginCoroutine(CREffects.SmoothZoomToScale(transformToZoom, initialScale, targetScale, smoothTime, maxSpeed, scaleError, DelegateMethod), ref cr_ScaleZoom, this);
	}
	
	private void DelegateMethod()
    {
        Debug.Log("Test Item 5: Zooming to scale: " + targetScale.ToString());
        CoroutineManager.BeginCoroutine(CREffects.SmoothZoomToScale(transformToZoom, initialScale, targetScale, smoothTime, maxSpeed, scaleError, DelegateMethod), ref cr_ScaleZoom, this);
    }
}
