using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision2DTrigger : MonoBehaviour
{
    [Header("Tag Settings")]
    public string Tag;

    [Header("Event Settings")]
    public UnityEvent StartEvents;
    public UnityEvent UpdateEvents;

    [Header("Collision Settings")]
    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerStayEvent;
    public UnityEvent OnTriggerExitEvent;

    // Start is called before the first frame update
    void Start()
    {
        StartEvents?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEvents?.Invoke();
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag(Tag))
        {
            OnTriggerEnterEvent.Invoke();
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.transform.CompareTag(Tag))
        {
            OnTriggerStayEvent.Invoke();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.transform.CompareTag(Tag))
        {
            OnTriggerExitEvent.Invoke();
        }
    }
}
