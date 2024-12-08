using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Миниигра : MonoBehaviour
{
    public float speed = 0.07f;
    public Rigidbody2D rb;
    public GameObject tochka;
    public GameObject yellow;
    public GameObject zel;
    public GameObject textt;
    public GameObject panel;
    public GameObject player;
    public static bool proshel = false;
    bool right = false;
    bool left = false;
    bool up = false;
    bool down = false;
    bool can = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        RandomNumber();
    }

    void again() {
        float oX = Random.Range(-28.8f, 25.5f);
        float oY = Random.Range(-29f, 5.85f);
        if (!((((oX + 1.7f)*(oX + 1.7f)+(oY + 11.2f)*(oY + 11.2f))>334.89f)&&(((oX + 1.7f)*(oX + 1.7f)+(oY + 11.2f)*(oY + 11.2f))<=817f))) {
            again();
        }
        else {
            Vector2 newpos = new Vector2(oX, oY);
            tochka.transform.localPosition = new Vector2(oX, oY);
        }
    }
    void OnTriggerStay2D(Collider2D other) {
            if (other.gameObject.tag == "nelsa") {
            can = true;
            }
            if (other.gameObject.tag == "yell") {
            yellow.SetActive(true);
            }
            if (other.gameObject.tag == "grin") {
            zel.SetActive(true);
            textt.SetActive(true);
            Invoke("close", 2f);
            proshel = true;

            }
    }
    void OnTriggerExit2D(Collider2D other) {
            yellow.SetActive(false);
            zel.SetActive(false);
            if (other.gameObject.tag == "nelsa") {
            can = false;
            }
    }
    void Update() {
        if (right && can == true) {
        tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x + speed, tochka.transform.localPosition.y);
        }
        if (left && can == true) {
            tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x - speed, tochka.transform.localPosition.y);
        }
        if (up && can == true) {
            tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x, tochka.transform.localPosition.y + speed);
        }
        if (down && can == true) {
            tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x, tochka.transform.localPosition.y - speed);
        }
        if (can == false) {
            speed = 0f;
        }
    }
    public void ButRightDown() {
        speed = 0.07f;
        right = true;
        tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x + speed, tochka.transform.localPosition.y);
    }
    public void ButRightDownUp() {
        tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x, tochka.transform.localPosition.y);
        speed = 0f;
        right = false;
        left = false;
        up = false;
        down = false;
    }
    public void ButLeftDown() {
        speed = 0.07f;
        left = true;
        tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x - speed, tochka.transform.localPosition.y);
    }
    public void ButUpDown() {
        speed = 0.07f;
        up = true;
        tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x, tochka.transform.localPosition.y + speed);
    }
    public void ButDownDown() {
        speed = 0.07f;
        down = true;
        tochka.transform.localPosition = new Vector2(tochka.transform.localPosition.x, tochka.transform.localPosition.y - speed);
    }
    void close() {
        panel.SetActive(false);
        player.SetActive(true);
        textt.SetActive(false);
        мини.canGame = false;
        RandomNumber();
    }
    void RandomNumber() {
        int rand = Random.Range(1, 5);
        if (rand == 1) {
            float oX = -25f;
            float oY = -7.2f;
            tochka.transform.localPosition = new Vector2(oX, oY);
        }
        if (rand == 2) {
            float oX = 24.2f;
            float oY = -15.5f;
            tochka.transform.localPosition = new Vector2(oX, oY);
        }
        if (rand == 3) {
            float oX = 0f;
            float oY = -25.9f;
            tochka.transform.localPosition = new Vector2(oX, oY);
        }
        if (rand == 4) {
            float oX = 4.2f;
            float oY = 1.2f;
            tochka.transform.localPosition = new Vector2(oX, oY);
        }
        if (rand == 5) {
            float oX = -16.2f;
            float oY = -25.79f;
            tochka.transform.localPosition = new Vector2(oX, oY);
        }
    }
    
}
