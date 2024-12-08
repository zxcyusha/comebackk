using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Портал : MonoBehaviour
{
    public GameObject naberimed;
    public GameObject E;
    public GameObject zastavka;
    public GameObject konzovka1;
    public GameObject konzovka2;
    public GameObject konzovka3;
    public GameObject konzovka4;
    bool inside = false;
    bool ending = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (inside == true && ending == true && Input.GetKeyDown(KeyCode.E)) {
            END();
        }
        if (пополнениемёда.hpp >= 400){
            ending = true;
        }
    }
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "portal") {
            inside = true;
            if (пополнениемёда.hpp < 400) {
            naberimed.SetActive(true);
            }
            else {
            E.SetActive(true);
        }
        }
    }
    void OnTriggerExit(Collider other) {
        naberimed.SetActive(false);
        E.SetActive(false);
        inside = false;
    }
    void END() {
        if (ТелефонсМихаилом.ending1 == true) {
            konzovka1.SetActive(true);
        }
        if (ТелефонсМихаилом.ansfirst == false && ТелефонМихаил2.anssecond == false) {
            konzovka2.SetActive(true);
        }
        if (ТелефонсМихаилом.ansfirst == false || ТелефонМихаил2.anssecond == false) {
            konzovka3.SetActive(true);
        }
        if (ТелефонсМихаилом.ansfirst == true && ТелефонМихаил2.anssecond == true) {
            konzovka4.SetActive(true);
        }
    }
    public void vmenu() {
        zastavka.SetActive(true);
    }
}
