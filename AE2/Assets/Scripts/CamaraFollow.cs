using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 distanciaCamara;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distanciaCamara = new Vector3 (0, 4, 4);
        transform.position = player.position + distanciaCamara;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        // Posición deseada
        Vector3 posicionDeseada = player.position + distanciaCamara;

        // Movimiento suave
        transform.position = Vector3.Lerp(
            transform.position,
            posicionDeseada,
            suavidad * Time.deltaTime
        );

        // Mirar al jugador
        transform.LookAt(player);
    }
}
