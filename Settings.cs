﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvaluator
{
	public class Settings : Menu
	{
		public override void Enter()
		{
			MenuStateEnterText($"You are now in Settings.");
		}
	}
}
