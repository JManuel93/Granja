using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class TrigoVida : MonoBehaviour
{
    int estadoTrigo = 0;
    public Animator animator;
    public float tiempo = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }

    private IEnumerator CambiarEstado(){
        while(estadoTrigo < 4){
             animator.SetInteger("estado",estadoTrigo);
             estadoTrigo++;
             yield return new WaitForSeconds(tiempo);
        }

    }
}