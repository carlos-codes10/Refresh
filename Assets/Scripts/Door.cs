using UnityEngine;

public class Door : MonoBehaviour
{

    // refrences
    [SerializeField] Animator myAnimator;
    public void Open()
    {
        myAnimator.SetBool("onTrigger",true);
    }

    public void Close()
    {
        myAnimator.SetBool("onTrigger", false);
    }
}
