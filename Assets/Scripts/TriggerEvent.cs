using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class TriggerEvent : MonoBehaviour
{
    public string[] tags;
    public UnityEvent OnColliderEnter;
    public UnityEvent OnColliderExit;
    public UnityEvent OnColliderStay;
    public UnityEvent OnTriggerEnter;
    public UnityEvent OnTriggerExit;
    public UnityEvent OnTrggerStay;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tags.Contains(collision.gameObject.tag))
        {
            OnColliderEnter.Invoke();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (tags.Contains(collision.gameObject.tag))
        {
            OnColliderExit.Invoke();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (tags.Contains(collision.gameObject.tag))
        {
            OnColliderStay.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tags.Contains(collision.gameObject.tag))
        {
            OnColliderEnter.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (tags.Contains(collision.gameObject.tag))
        {
            OnColliderExit.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (tags.Contains(collision.gameObject.tag))
        {
            OnColliderStay.Invoke();
        }
    }
}
