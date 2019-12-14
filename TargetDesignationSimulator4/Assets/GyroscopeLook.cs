using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public GameObject parent;
	// private int targetLayer = 1 << 8; // Layer 8 (targets)
	// private static bool fireIsDown = false;
	// private static Vector3 lastRaycastHit;
	// public CapsulePrefab teleLocation;
	// public CapsulePrefab tempTele;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetAxis("Horizontal") != 0)
		{
			// Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
			parent.transform.position += (transform.right) * Input.GetAxis("Horizontal") / 4;
		}

		if (Input.GetAxis("Vertical") != 0)
		{
			// Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
			parent.transform.position += (transform.forward) * Input.GetAxis("Vertical") / 4;
		}
    }
}