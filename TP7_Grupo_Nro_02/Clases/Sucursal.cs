using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP7_Grupo_Nro_02
{
	public class Sucursal
	{
		private int i_idSucursal;
		private string s_nombreSucursal;
		private string s_descripcionSucursal;
		private int i_idHorarioSucursal;
		private int i_idProvinciaSucursal;
		private string s_direccionSucursal;
		private string s_urlImagenSucursal;

		public Sucursal()
		{
		}

		public Sucursal(int i_idSucursal, string s_nombreSucursal, string s_descripcionSucursal, int i_idHorarioSucursal,
						int i_idProvinciaSucursal, string s_direccionSucursal, string s_urlImagenSucursal)
		{
			this.i_idSucursal = i_idSucursal;
			this.s_nombreSucursal = s_nombreSucursal;
			this.s_descripcionSucursal = s_descripcionSucursal;
			this.i_idHorarioSucursal = i_idHorarioSucursal;
			this.i_idProvinciaSucursal = i_idProvinciaSucursal;
			this.s_direccionSucursal = s_direccionSucursal;
			this.s_urlImagenSucursal = s_urlImagenSucursal;
		}

		public int idSucursal
		{
			get { return i_idSucursal; }
			set { i_idSucursal = value; }
		}

		public string nombreSucursal
		{
			get { return s_nombreSucursal; }
			set { s_nombreSucursal = value; }
		}

		public string descripcionSucursal
		{
			get { return s_descripcionSucursal; }
			set { s_descripcionSucursal = value; }
		}

		public int idHorarioSucursal
		{
			get { return i_idHorarioSucursal; }
			set { i_idHorarioSucursal = value; }
		}

		public int idProvinciaSucursal
		{
			get { return i_idProvinciaSucursal; }
			set { i_idProvinciaSucursal = value; }
		}

		public string direccionSucursal
		{
			get { return s_direccionSucursal; }
			set { s_direccionSucursal = value; }
		}

		public string urlImagenSucursal
		{
			get { return s_urlImagenSucursal; }
			set { s_urlImagenSucursal = value; }
		}
	}
}