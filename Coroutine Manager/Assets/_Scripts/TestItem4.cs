using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem4 : MonoBehaviour {

    [SerializeField] private Transform transformToZoom;
    [SerializeField] private Vector3 initialScale;
    [SerializeField] private Vector3 targetScale;
    [SerializeField] private float zoomTime;
    private Coroutine cr_ScaleZoom;

	// Use this for initialization
	void Start () {
        CoroutineManager.BeginCoroutine(CREffects.ZoomToScale(transformToZoom, initialScale, targetScale, zoomTime, DelegateMethod), ref cr_ScaleZoom, this);
        
	}
	
	private void DelegateMethod()
    {
        Debug.Log("Test Item 4: Zooming to scale: " + targetScale.ToString());
        CoroutineManager.BeginCoroutine(CREffects.ZoomToScale(transformToZoom, initialScale, targetScale, zoomTime, DelegateMethod), ref cr_ScaleZoom, this);
    }
}
