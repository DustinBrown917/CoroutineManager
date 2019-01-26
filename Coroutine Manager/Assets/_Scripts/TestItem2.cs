using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem2 : MonoBehaviour {

    [SerializeField] private Behaviour behaviourToShow;
    private Coroutine cr_Appear = null;

	// Use this for initialization
	void Start () {
        behaviourToShow.enabled = false;
        CoroutineManager.BeginCoroutine(CREffects.SetActiveAfterDelay(behaviourToShow, true, 2.0f, DelegateMethod), ref cr_Appear, this);
    }

    private void DelegateMethod()
    {
        Debug.Log("Test Item 2: Behaviour Enabled: " + behaviourToShow.enabled.ToString());
        CoroutineManager.BeginCoroutine(CREffects.SetActiveAfterDelay(behaviourToShow, !behaviourToShow.enabled, 2.0f, DelegateMethod), ref cr_Appear, this);
    }

    
}
