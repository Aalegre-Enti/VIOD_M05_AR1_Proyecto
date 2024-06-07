using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class TriggerEvent : MonoBehaviour
{
    public string[] tags;
    public LayerMask mask;
    public UnityEvent OnColliderEnter;
    public UnityEvent OnColliderExit;
    public UnityEvent OnColliderStay;
    public UnityEvent OnTriggerEnter;
    public UnityEvent OnTriggerExit;
    public UnityEvent OnTriggerStay;

    public bool CanEnter(GameObject go)
    {
        return tags.Contains(go.tag) && (mask & (1 << go.layer)) != 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CanEnter(collision.gameObject))
        {
            OnColliderEnter.Invoke();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (CanEnter(collision.gameObject))
        {
            OnColliderExit.Invoke();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (CanEnter(collision.gameObject))
        {
            OnColliderStay.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CanEnter(collision.gameObject))
        {
            OnTriggerEnter.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (CanEnter(collision.gameObject))
        {
            OnTriggerExit.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (CanEnter(collision.gameObject))
        {
            OnTriggerStay.Invoke();
        }
    }
}
