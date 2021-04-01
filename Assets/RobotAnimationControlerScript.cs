using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RelatedObjects{
    public class RobotAnimationControlerScript : MonoBehaviour
    {
        Animator myAnimator;
        // Start is called before the first frame update
        void Start()
        {
            //get the animator component
            myAnimator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        //enter clap state
        public void MakeClap()
        {
            //reset cheering trigger to ensure it is false
            myAnimator.ResetTrigger("Clap");
            //trigger clapping
            myAnimator.SetTrigger("Clap");
        }
    }
}
