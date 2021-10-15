using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

 void Awake () {
         Debug.Log ("Awake");
 }
 
 void Start () {
         Debug.Log ("Start");
 }
     void Update () {
         Debug.Log ("Update: "+Time.deltaTime);
     } 
       
    void FixedUpdate () {
        Debug.Log ("FixedUpdate: "+Time.deltaTime);
    }
}
