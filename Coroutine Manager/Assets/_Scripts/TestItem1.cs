using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem1 : MonoBehaviour {

    [SerializeField] private GameObject objectToShow;
    private Coroutine cr_Appear;

	// Use this for initialization
	void Start () {
        objectToShow.SetActive(false);
        CoroutineManager.BeginCoroutine(CREffects.SetActiveAfterDelay(objectToShow, true, 2.0f, DelegateMethod), ref cr_Appear, this);
        
	}
	
	private void DelegateMethod()
    {
        Debug.Log("Test Item 1: GameObject Enabled: " + objectToShow.activeSelf.ToString());
        CoroutineManager.BeginCoroutine(CREffects.SetActiveAfterDelay(objectToShow, !objectToShow.activeSelf, 2.0f, DelegateMethod), ref cr_Appear, this);
    }
}
