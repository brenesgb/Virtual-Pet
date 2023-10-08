using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    Animator anim;
    public GameObject fish;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnFeedPress()
    {
        var cloneFish = Instantiate(fish, new Vector3(-0.76f, -0.32f, -3.61f), fish.transform.rotation);   
        anim.SetTrigger("eat");
        Destroy(cloneFish, 3.1f);

    }

    public void OnPlayPress()
    {
        anim.SetTrigger("play");
    }

    public void OnTalkPress()
    {
        anim.SetTrigger("talk");
    }
}
