using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eLF_AutoAdmin
{
    //ugly -- i dont think this gets used. or maybe for the ghost objects but reference is as by message
    public class DelayController : MonoBehaviour
    {

        public bool wait(float seconds)
        {
            StartCoroutine(delayForSeconds(seconds));
            return true;
        }

        IEnumerator delayForSeconds(float seconds)
        {
            yield return new WaitForSeconds(seconds);
        }
    }
}