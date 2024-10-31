using Examen03.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Examen03.Views
{
	/// <summary>
	/// Lógica de interacción para ListarProductos.xaml
	/// </summary>
	public partial class ListarProductos : Window
	{
		public ListarProductos()
		{
			InitializeComponent();
			this.DataContext = new ViewModelListarProductos();
		}
	}
}
