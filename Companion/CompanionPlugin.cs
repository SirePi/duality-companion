﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;

namespace Duality.Plugins.Companion
{
	/// <summary>
	/// Defines a Duality core plugin.
	/// </summary>
	public class CompanionPlugin : CorePlugin
	{
		// Override methods here for global logic

		protected override void OnBeforeUpdate()
		{
			base.OnBeforeUpdate();

			Timer.OnUpdate();
		}
	}
}
