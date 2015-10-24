using UnityEngine;
using System.Collections;

public class PawnStartPoint : MonoBehaviour
{
	public GameObject PawnPrefab;

	// Use this for initialization
	void Start ()
	{
		if (null == GameObject.FindObjectOfType<Pawn> () && null != PawnPrefab) {
			Instantiate <GameObject> (PawnPrefab).transform.SetParent (transform);
		}
	}
}
