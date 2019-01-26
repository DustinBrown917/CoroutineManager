using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem3 : MonoBehaviour {

    [SerializeField] private ParticleSystem ps;
    private Coroutine cr_Appear = null;

	// Use this for initialization
	void Start () {
        ParticleSystem.EmissionModule em = ps.emission;
        em.enabled = false;
        CoroutineManager.BeginCoroutine(CREffects.SetActiveAfterDelay(ps, true, 2.0f, DelegateMethod), ref cr_Appear, this);
    }

    private void DelegateMethod()
    {
        Debug.Log("Test Item 3: Particles Enabled: " + ps.emission.enabled.ToString());
        CoroutineManager.BeginCoroutine(CREffects.SetActiveAfterDelay(ps, !ps.emission.enabled, 2.0f, DelegateMethod), ref cr_Appear, this);
    }

    
}
