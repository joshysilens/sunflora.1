using UnityEngine;

public class Player : MonoBehaviour
{
    private int numero;
    public float velocidade = 40;
    void Start()
    {
        numero = 0;
    }

    
    void Update()
    {
        //Debug.Log(numero);
        //numero = numero + 1

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(velocidade,0,0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            
        }
    }
}
