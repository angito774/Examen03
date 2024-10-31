using Examen03.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen03.ViewModels
{
	public class ViewModelListarProductos : ViewModelBase
	{
		public ObservableCollection<ProductoModel> Productos { get; }

		#region Propiedades
		private string _Nombre;
		public string Nombre
		{
			get { return _Nombre; }
			set
			{
				_Nombre = value;
				OnPropertyChanged(nameof(Nombre));
			}
		}

		private string _Precio;
		public string Precio
		{
			get { return _Precio; }
			set
			{
				_Precio = value;
				OnPropertyChanged(nameof(Precio));
			}
		}

		private string _Descripcion;
		public string Descripcion
		{
			get { return _Descripcion; }
			set
			{
				_Descripcion = value;
				OnPropertyChanged(nameof(Descripcion));
			}
		}
		#endregion

		#region Comando
		public ICommand AgregarProductoCommand { get; }

		private void GuardarProducto()
		{
			var Resultado = string.Concat(Nombre, " ", Precio, " ", Descripcion);

			Productos.Add(new ProductoModel
			{
				Nombre = this.Nombre,
				Precio = this.Precio,
				Descripcion = this.Descripcion				
			});
			this.Nombre = string.Empty; this.Precio=string.Empty; this.Descripcion=string.Empty;
		}

		#endregion


		public ViewModelListarProductos()
		{
			Productos = new ObservableCollection<ProductoModel>();
			AgregarProductoCommand = new RelayCommand(GuardarProducto);			
		}


	}
}
