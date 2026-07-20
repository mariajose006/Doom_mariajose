using UnityEngine;
using System.Collections;

public static class AnimatorExtensions 
{
    public static IEnumerator WaitForCurrentAnimation(this Animator animator, int layer = 0)
    {
        while (animator.IsInTransition(layer))
        {
            yield return null;
        }
        AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(layer);
        while (!animator.IsInTransition(layer) && stateinfo.normalizedTime < 1f)
        {
            yield return null;
            stateinfo = animator.GetCurrentAnimatorStateInfo(layer);
        }
    }
}
