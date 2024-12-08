using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Планы : MonoBehaviour
{
    public GameObject planeta1;
    public GameObject panel;
    public AudioSource Old;
    public AudioSource New;
    void Start() {
        planeta1.GetComponent<Button>().onClick.AddListener(delegate { LoadLevel(); });
    }
    public void LoadLevel()
    {
        panel.SetActive(false);// в кавычках название сцены на которую осуществляется переход
        Old.Stop();
        New.Play();
    }
}

