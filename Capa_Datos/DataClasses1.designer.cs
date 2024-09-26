﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="crudMonolito")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Inserttbl_proveedor(tbl_proveedor instance);
    partial void Updatetbl_proveedor(tbl_proveedor instance);
    partial void Deletetbl_proveedor(tbl_proveedor instance);
    partial void Inserttbl_producto(tbl_producto instance);
    partial void Updatetbl_producto(tbl_producto instance);
    partial void Deletetbl_producto(tbl_producto instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Capa_Datos.Properties.Settings.Default.crudMonolitoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_proveedor> tbl_proveedor
		{
			get
			{
				return this.GetTable<tbl_proveedor>();
			}
		}
		
		public System.Data.Linq.Table<tbl_producto> tbl_producto
		{
			get
			{
				return this.GetTable<tbl_producto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_proveedor")]
	public partial class tbl_proveedor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _prov_id;
		
		private string _prov_nombre;
		
		private System.Nullable<char> _prov_estado;
		
		private EntitySet<tbl_producto> _tbl_producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onprov_idChanging(int value);
    partial void Onprov_idChanged();
    partial void Onprov_nombreChanging(string value);
    partial void Onprov_nombreChanged();
    partial void Onprov_estadoChanging(System.Nullable<char> value);
    partial void Onprov_estadoChanged();
    #endregion
		
		public tbl_proveedor()
		{
			this._tbl_producto = new EntitySet<tbl_producto>(new Action<tbl_producto>(this.attach_tbl_producto), new Action<tbl_producto>(this.detach_tbl_producto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int prov_id
		{
			get
			{
				return this._prov_id;
			}
			set
			{
				if ((this._prov_id != value))
				{
					this.Onprov_idChanging(value);
					this.SendPropertyChanging();
					this._prov_id = value;
					this.SendPropertyChanged("prov_id");
					this.Onprov_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_nombre", DbType="VarChar(50)")]
		public string prov_nombre
		{
			get
			{
				return this._prov_nombre;
			}
			set
			{
				if ((this._prov_nombre != value))
				{
					this.Onprov_nombreChanging(value);
					this.SendPropertyChanging();
					this._prov_nombre = value;
					this.SendPropertyChanged("prov_nombre");
					this.Onprov_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_estado", DbType="Char(1)")]
		public System.Nullable<char> prov_estado
		{
			get
			{
				return this._prov_estado;
			}
			set
			{
				if ((this._prov_estado != value))
				{
					this.Onprov_estadoChanging(value);
					this.SendPropertyChanging();
					this._prov_estado = value;
					this.SendPropertyChanged("prov_estado");
					this.Onprov_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_proveedor_tbl_producto", Storage="_tbl_producto", ThisKey="prov_id", OtherKey="prov_id")]
		public EntitySet<tbl_producto> tbl_producto
		{
			get
			{
				return this._tbl_producto;
			}
			set
			{
				this._tbl_producto.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tbl_producto(tbl_producto entity)
		{
			this.SendPropertyChanging();
			entity.tbl_proveedor = this;
		}
		
		private void detach_tbl_producto(tbl_producto entity)
		{
			this.SendPropertyChanging();
			entity.tbl_proveedor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_producto")]
	public partial class tbl_producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pro_id;
		
		private string _pro_nombre;
		
		private System.Nullable<int> _pro_cantidad;
		
		private System.Nullable<char> _pro_estado;
		
		private System.Nullable<int> _prov_id;
		
		private EntityRef<tbl_proveedor> _tbl_proveedor;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpro_idChanging(int value);
    partial void Onpro_idChanged();
    partial void Onpro_nombreChanging(string value);
    partial void Onpro_nombreChanged();
    partial void Onpro_cantidadChanging(System.Nullable<int> value);
    partial void Onpro_cantidadChanged();
    partial void Onpro_estadoChanging(System.Nullable<char> value);
    partial void Onpro_estadoChanged();
    partial void Onprov_idChanging(System.Nullable<int> value);
    partial void Onprov_idChanged();
    #endregion
		
		public tbl_producto()
		{
			this._tbl_proveedor = default(EntityRef<tbl_proveedor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pro_id
		{
			get
			{
				return this._pro_id;
			}
			set
			{
				if ((this._pro_id != value))
				{
					this.Onpro_idChanging(value);
					this.SendPropertyChanging();
					this._pro_id = value;
					this.SendPropertyChanged("pro_id");
					this.Onpro_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_nombre", DbType="VarChar(50)")]
		public string pro_nombre
		{
			get
			{
				return this._pro_nombre;
			}
			set
			{
				if ((this._pro_nombre != value))
				{
					this.Onpro_nombreChanging(value);
					this.SendPropertyChanging();
					this._pro_nombre = value;
					this.SendPropertyChanged("pro_nombre");
					this.Onpro_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_cantidad", DbType="Int")]
		public System.Nullable<int> pro_cantidad
		{
			get
			{
				return this._pro_cantidad;
			}
			set
			{
				if ((this._pro_cantidad != value))
				{
					this.Onpro_cantidadChanging(value);
					this.SendPropertyChanging();
					this._pro_cantidad = value;
					this.SendPropertyChanged("pro_cantidad");
					this.Onpro_cantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_estado", DbType="Char(1)")]
		public System.Nullable<char> pro_estado
		{
			get
			{
				return this._pro_estado;
			}
			set
			{
				if ((this._pro_estado != value))
				{
					this.Onpro_estadoChanging(value);
					this.SendPropertyChanging();
					this._pro_estado = value;
					this.SendPropertyChanged("pro_estado");
					this.Onpro_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prov_id", DbType="Int")]
		public System.Nullable<int> prov_id
		{
			get
			{
				return this._prov_id;
			}
			set
			{
				if ((this._prov_id != value))
				{
					if (this._tbl_proveedor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onprov_idChanging(value);
					this.SendPropertyChanging();
					this._prov_id = value;
					this.SendPropertyChanged("prov_id");
					this.Onprov_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_proveedor_tbl_producto", Storage="_tbl_proveedor", ThisKey="prov_id", OtherKey="prov_id", IsForeignKey=true)]
		public tbl_proveedor tbl_proveedor
		{
			get
			{
				return this._tbl_proveedor.Entity;
			}
			set
			{
				tbl_proveedor previousValue = this._tbl_proveedor.Entity;
				if (((previousValue != value) 
							|| (this._tbl_proveedor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_proveedor.Entity = null;
						previousValue.tbl_producto.Remove(this);
					}
					this._tbl_proveedor.Entity = value;
					if ((value != null))
					{
						value.tbl_producto.Add(this);
						this._prov_id = value.prov_id;
					}
					else
					{
						this._prov_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_proveedor");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
