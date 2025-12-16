using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterAnimations : MonoBehaviour
{
    //Detta script hanterar våra parametrar i vår animator så vi kan kontrollera när en bool eller trigger ska aktiveras
    public Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Walk(bool walk)
    {
        anim.SetBool("Walk", walk);
    }
    public void Defend(bool defend)
    {
        anim.SetBool("Defend", defend);
    }
    public void Casting(bool casting)
    {
        anim.SetBool("Casting", casting);
    }
    public void Dodge(bool Dodge)
    {
        anim.SetBool("Dodge", Dodge);
    }
    public void Run(bool Run)
    {
        anim.SetBool("Run", Run);
    }
    public void Attack01()
    {
        anim.SetTrigger("Attack01");
    }
    public void Attack02()
    {
        anim.SetTrigger("Attack02");
    }
    public void Death()
    {
        anim.SetTrigger("Death");
    }
}
