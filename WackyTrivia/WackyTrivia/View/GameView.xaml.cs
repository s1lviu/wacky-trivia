﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WackyTrivia.ViewModel;
using Xamarin.Forms;

namespace WackyTrivia.View
{
	public partial class GameView
	{
		public GameView ()
		{
			InitializeComponent ();
            BindingContext = new GameViewModel();
		}
	}
}