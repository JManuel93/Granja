using UnityEngine;

public class Ponedora : MonoBehaviour
{
    public GameObject huevo;
    public float intervalo = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // invocar PoneHuevo()
        InvokeRepeating(nameof(PonerHuevo), intervalo, intervalo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PonerHuevo(){
       Instantiate(huevo, transform.position, Quaternion.identity);
       // Debug.Log("Poner Huevo");
    }
}
