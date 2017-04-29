using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCanvas1 : MonoBehaviour
{

    public Animation anim;
    public Animation anim2;
    public Animation anim3;
    public Animation anim4;
    public Animation anim5;

    void Start()
    {
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }

        anim2 = GetComponent<Animation>();
        foreach (AnimationState state in anim2)
        {
            state.speed = 0.5F;
        }

        anim3 = GetComponent<Animation>();
        foreach (AnimationState state in anim3)
        {
            state.speed = 0.5F;
        }

        anim4 = GetComponent<Animation>();
        foreach (AnimationState state in anim4)
        {
            state.speed = 0.5F;
        }

        anim5 = GetComponent<Animation>();
        foreach (AnimationState state in anim5)
        {
            state.speed = 0.5F;
        }
    }
}
