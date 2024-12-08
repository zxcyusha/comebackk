using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TMPro.TMP_Text HP;
    public int level = 0;
    public int health = 3;
    public Rigidbody rb;
    public GameObject zastavka;

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && пополнениемёда.aaa == true) {
            level += Sad.hp;
        }
    }
    public void SavePlayer() {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer() {
        zastavka.SetActive(false);
        rb.isKinematic = true;
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        health = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        HP.text = level.ToString();
        Invoke("kine", 1f);
    }
    void kine() {
        rb.isKinematic = false;
    }
}
