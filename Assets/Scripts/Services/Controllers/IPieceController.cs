﻿using UnityEngine;

namespace ThreeInLine.Services.Controllers
{
	public interface IPieceController
	{
		int Index { get; }
		Vector3 Position { get; }
		void SetState(int player);
		void SetSize(float normalized);
	}
}