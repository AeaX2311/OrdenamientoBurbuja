﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_OrdenamientoBurbuja {
    class FabricaArticulosNavidenios : IComparable<FabricaArticulosNavidenios> {
		private string _strNombre;

		public string Nombre {
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private double _dblTamanioTerritorio;

		public double TamanioTerritorio {
			get { return _dblTamanioTerritorio; }
			set { _dblTamanioTerritorio = value; }
		}

		private char _chrClasificacion;

		public char Clasificacion {
			get { return _chrClasificacion; }
			set { _chrClasificacion = value; }
		}

		private DateTime _dtmFechaInauguracion;

		public DateTime FechaInauguracion {
			get { return _dtmFechaInauguracion; }
			set { _dtmFechaInauguracion = value; }
		}

		private bool _blnTieneCredito;

		public bool TieneCredito {
			get { return _blnTieneCredito; }
			set { _blnTieneCredito = value; }
		}

		private int _intCantidadEmpleados;

		public int CantidadEmpleados{
			get { return _intCantidadEmpleados; }
			set { _intCantidadEmpleados = value; }
		}

		private int _intCantidadProveedores;

		public int CantidadProveedores {
			get { return _intCantidadProveedores; }
			set { _intCantidadProveedores = value; }
		}

		private string _strTipoSegunDependencia;

		public string TipoSegunDependencia{
			get { return _strTipoSegunDependencia; }
			set { _strTipoSegunDependencia = value; }
		}

		public int CompareTo(FabricaArticulosNavidenios otraFabrica) {
			return Nombre.CompareTo(otraFabrica.Nombre);
		}
	}
}
