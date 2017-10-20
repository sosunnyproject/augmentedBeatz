using UnityEngine;
using UnityEngine.Events;

public class OnGaze : MonoBehaviour
{
    public UnityEvent Event;
    void Start()
    {
        // dummy Start function so we can use this.enabled
    }

    public void OnGazeEnter()
    {
        if (this.enabled == false) return;
        if (Event != null)
        {
            Event.Invoke();
            Debug.Log("Call On Gaze Enter in OnGaze");

           this.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
           
        }
    }

public void OnGazeLeave()
{
    if (this.enabled == false) return;
    if (Event != null)
    {
        Event.Invoke();
        Debug.Log("Gaze Exit in OnGaze");

            this.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
    }
}