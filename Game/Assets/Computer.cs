using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour {

// Start is called before the first frame update
void Start()
    {
        //Debug.Log("this wont end well");
    }
    void OnMouseDown(){
        Debug.Log("wow!");
        this.gameObject.transform.Find("ComputerMenu").gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
