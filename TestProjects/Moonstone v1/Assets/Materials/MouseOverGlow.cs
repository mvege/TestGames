using UnityEngine;
using System.Collections;

public class MouseOverGlow : MonoBehaviour {

	public string levelName = "mapScene";
	private Color initialColor;

	// Use this for initialization
	void Start () {
		initialColor = renderer.material.color;

	}
	
	void OnMouseOver() {
		renderer.material.color = Color.green;
	}

	void OnMouseExit()	{
		renderer.material.color = initialColor;
	}

	
	void OnMouseDown() {
		//Debug.Log ("Hello" + levelName);
		Application.LoadLevel (levelName);

	}	
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	void OnGui(){
			EditorGUIUtility.AddCursorRect (Rect(600,20,80,80), MouseCursor.Link); 
		
	}
	*/
}
