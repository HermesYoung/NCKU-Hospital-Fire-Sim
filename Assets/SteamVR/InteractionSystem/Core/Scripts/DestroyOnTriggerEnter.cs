//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Destroys this object when it enters a trigger
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class DestroyOnTriggerEnter : MonoBehaviour
	{
		public string tagFilter;

		private bool useTag;

		//-------------------------------------------------
		void Start()
		{
			
			if ( !string.IsNullOrEmpty( tagFilter ) )
			{
				useTag = true;
			}
		}


		//-------------------------------------------------
		public void OnTriggerEnter( Collider collider )
		{
			if ( !useTag || ( useTag && collider.gameObject.tag == tagFilter ) )
			{
				Destroy( collider.gameObject.transform.root.gameObject );
				collider.gameObject.SetActive(false);
				
			}
		}
	
	}
}
