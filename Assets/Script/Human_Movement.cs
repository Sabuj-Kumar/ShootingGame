using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Movement : MonoBehaviour
{
    public CharacterController2D controler;
    public Animator animator;
    float Move = 4.0f;
    public void Update()
    {
         transform.Translate(new Vector2(-1.0f, 0.0f) * Move * Time.deltaTime);
         animator.SetFloat("Run", Mathf.Abs(Move));
    }
}
