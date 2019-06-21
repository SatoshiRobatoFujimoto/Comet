﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace HotUI {
	public class ScrollView : View, IEnumerable {
		public View View { get; internal set; }
		public void Add (View view)
		{
			if (view == null)
				return;
			if (View != null)
				throw new Exception ("You can only add one view to the ScrollView, Try wrapping in a Stack");
			View = view;
		}

		public IEnumerator GetEnumerator () => new View [] { View }.GetEnumerator ();
	}
}
