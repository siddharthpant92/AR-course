using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
 
public class VirtualButtonScript : MonoBehaviour
{
	public GameObject sphereGo;
	VirtualButtonBehaviour[] vbs;

	// Start is called before the first frame update
	void Start()
	{
		vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i)
		{
			vbs[i].RegisterOnButtonPressed(OnButtonPressed);
			vbs[i].RegisterOnButtonReleased(OnButtonReleased);
		}
		sphereGo.SetActive(false);
	}
	 
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		Debug.Log("virtual button pressed");
		sphereGo.SetActive(true);
	}
	 
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		Debug.Log("virtual button released");
		sphereGo.SetActive(false);
	}
}
