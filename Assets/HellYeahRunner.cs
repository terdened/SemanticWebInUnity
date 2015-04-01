using UnityEngine;
using System.Collections;
using ExternalLibrary;

public class HellYeahRunner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var hellYeah = new ExternalLibrary.HellYeah();
        Debug.Log(hellYeah.Get2Plus2());
        Debug.Log(hellYeah.GetHellYeah());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
