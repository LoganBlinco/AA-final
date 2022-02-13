using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace eLF_AutoAdmin
{
	public class DummyScript : MonoBehaviour
	{

		public void Created(float timeToExist)
		{
			StartCoroutine(waitThing(timeToExist));
		}

		public IEnumerator waitThing(float timeToExist)
		{
			yield return new WaitForSeconds(timeToExist);
			DummyController.disabledObjects.Add(this);
			this.gameObject.SetActive(false);
		}
	}
}