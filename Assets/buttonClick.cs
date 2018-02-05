using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour {

    [SerializeField]
	public GameObject dylanSprite;
    public Sprite newSprite;

    private SpriteRenderer sRend;

	// Use this for initialization
	void Start () {
		sRend = dylanSprite.GetComponent<SpriteRenderer>();
	}
	
	// Executes when a mouse down event is fired on the attached object
    void OnMouseDown()
    {
        sRend.sprite = newSprite;
    }
}
