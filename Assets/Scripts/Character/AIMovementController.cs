using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class AIMovementController : MonoBehaviour
{
	Movement movement;
	private void Awake() {
		movement = GetComponent<Movement>();
	}

	void Update()
    {
        
    }
}
