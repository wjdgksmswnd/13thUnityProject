using UnityEngine;
using System.Collections;

public class UnityMoveManager : MonoBehaviour
{
	public MopBase[] mopList;
	// Use this for initialization
	void Start ()
	{
	
	}

	// Update is called once per frame
	void Update ()
	{
		
		foreach (MopBase mop in mopList)
		{
			if(idle이면)
			{
				if (공격가능) 
				{
					공격모션진입
				}
				else
				{
					이동
					mop.position += mop.direction * Time.deltaTime;
				}
			}
			else(공격중)
			{
				애니메이션 진행
				if(끝났으면)
					state = idle;
			}
		}
	}
}

