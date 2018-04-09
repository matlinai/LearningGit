using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour {

    //Button[] btn;
    private int selectedIndex = 0;
    public GameObject selector;
	// Use this for initialization
	void Start () {
        //btn = GetComponents<Button>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            selectedIndex++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            selectedIndex--;
        }
        selector.gameObject.transform.position = btn[selectedIndex].transform.position;
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Chama o click
        }
    }
}
