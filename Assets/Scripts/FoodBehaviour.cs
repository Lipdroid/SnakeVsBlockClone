using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBehaviour : MonoBehaviour {
	[Header("SnakeManager")]
	public SnakeMovement SM;
	public int foodAmount;

	// Use this for initialization
	void Start () {
		SM = transform.GetComponentInParent <SnakeMovement> ();
		foodAmount = Random.Range (0,10);
		transform.GetComponentInChildren <TextMesh> ().text = "" + foodAmount;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
