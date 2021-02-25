using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class AnimatedRectController : MonoBehaviour
{
#pragma warning disable CS0649

    [SerializeField]
    private Animator _animator;

#pragma warning restore CS0649

    public void SetRed()
    {
        Trigger("Red");
    }

    public void SetYellow()
    {
        Trigger("Yellow");
    }

    public void SetBlue()
    {
        Trigger("Blue");
    }

    private void Trigger(string trigger)
    {
        Debug.Log($"{trigger}[{Time.frameCount}]");
        _animator.SetTrigger(trigger);
    }
}