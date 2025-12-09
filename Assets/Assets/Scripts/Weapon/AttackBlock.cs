using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBlock : MonoBehaviour
{
	public static int blockSword;
	public int internalBlock;

	void Update()
	{
		internalBlock = blockSword;
	}
}
