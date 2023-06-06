using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int velocidad;
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //puntuacion = 10;
        gameObject.name = "NuevoNombre";
        //gameObject.SetActive(false);
        Debug.Log (gameObject.name);
        //Debug.Log(gameObject.transform.position);
        //Debug.Log(gameObject.transform.rotation);
        //Debug.Log(gameObject.transform.localScale);

        //Debug.Log(gameObject.GetComponent<Transform>().position);

        //Debug.Log(gameObject.GetComponent<Jugador>().enabled);
        //gameObject.GetComponent<Jugador>().gameObject.SetActive(false);
        //Debug.Log(gameObject.GetComponent<Jugador>().gameObject.transform.name);


        //Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hola mundo cruel");
        //Debug.Log(gameObject.transform.position);

        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);

        Vector3 direccion = new Vector3(horizontal, 0, vertical);

        controller.Move(direccion * Time.deltaTime * velocidad);


    }
}
