using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Collidable : MonoBehaviour
{
    [SerializeField] private ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];
    protected virtual void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update() {
        // Collision work
        boxCollider.OverlapCollider(filter, hits);
		for (int i = 0; i < hits.Length; i++) {
            if(hits[i] == null) {
                continue;
			}

            OnColide(hits[i]);
            //The arry is not cleaned up, so we 
            hits[i] = null;

        }
	}

    protected virtual void OnColide(Collider2D coll) {
        Debug.Log(coll.name);
    }

}
