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
        transform.LookAt(player);
    }
}
