using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscogerPersonaje : MonoBehaviour {
    public GameObject personajePrefab;
    public GameObject personajeContainter;

    private void Start() {
        Sprite[] personajes = Resources.LoadAll<Sprite>("Personajes");
        foreach (Sprite personaje in personajes) {
            GameObject container = Instantiate(personajePrefab) as GameObject;
            container.GetComponent<Image>().sprite = personaje;
            container.transform.SetParent(personajeContainter.transform, false);
        }
    }
}
