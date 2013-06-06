﻿namespace Osiris.Tfs.Monitor
{
	#region Using

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Data;
	using System.Windows.Documents;
	using System.Windows.Input;
	using System.Windows.Media;
	using System.Windows.Media.Imaging;
	using System.Windows.Navigation;
	using System.Windows.Shapes;
	using Microsoft.Windows.Controls.Ribbon;

	#endregion // Using

	public partial class ApplicationRibbonMenuView : RibbonApplicationMenu
	{
		private ApplicationRibbonVm Vm { get { return this.DataContext as ApplicationRibbonVm; } } 

		#region Constructors

		public ApplicationRibbonMenuView()
		{
			InitializeComponent();
		}

		#endregion // Constructors

		#region Methods

		private void RecentFiles_MostRecentFileSelected(object sender, MostRecentFileSelectedEventArgs e)
		{
			this.Vm.OpenRecentFile.Execute(e.SelectedItem.ToString());
		}
		
		#endregion // Methods
	}
}
