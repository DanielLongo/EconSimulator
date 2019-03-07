using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPressedMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    public static void ShowMenu() {
        Debug.Log("set show to trye");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
