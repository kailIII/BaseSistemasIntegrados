﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace datos.Inventario
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class InventarioEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto InventarioEntities usando la cadena de conexión encontrada en la sección 'InventarioEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public InventarioEntities() : base("name=InventarioEntities", "InventarioEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto InventarioEntities.
        /// </summary>
        public InventarioEntities(string connectionString) : base(connectionString, "InventarioEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto InventarioEntities.
        /// </summary>
        public InventarioEntities(EntityConnection connection) : base(connection, "InventarioEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Grupo> Grupo
        {
            get
            {
                if ((_Grupo == null))
                {
                    _Grupo = base.CreateObjectSet<Grupo>("Grupo");
                }
                return _Grupo;
            }
        }
        private ObjectSet<Grupo> _Grupo;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Grupo. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToGrupo(Grupo grupo)
        {
            base.AddObject("Grupo", grupo);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="InventarioModel", Name="Grupo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Grupo : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Grupo.
        /// </summary>
        /// <param name="idGrupo">Valor inicial de la propiedad IdGrupo.</param>
        /// <param name="descripcion">Valor inicial de la propiedad Descripcion.</param>
        public static Grupo CreateGrupo(global::System.Int32 idGrupo, global::System.String descripcion)
        {
            Grupo grupo = new Grupo();
            grupo.IdGrupo = idGrupo;
            grupo.Descripcion = descripcion;
            return grupo;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdEmpresa
        {
            get
            {
                return _IdEmpresa;
            }
            set
            {
                OnIdEmpresaChanging(value);
                ReportPropertyChanging("IdEmpresa");
                _IdEmpresa = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdEmpresa");
                OnIdEmpresaChanged();
            }
        }
        private Nullable<global::System.Int32> _IdEmpresa;
        partial void OnIdEmpresaChanging(Nullable<global::System.Int32> value);
        partial void OnIdEmpresaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdGrupo
        {
            get
            {
                return _IdGrupo;
            }
            set
            {
                if (_IdGrupo != value)
                {
                    OnIdGrupoChanging(value);
                    ReportPropertyChanging("IdGrupo");
                    _IdGrupo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdGrupo");
                    OnIdGrupoChanged();
                }
            }
        }
        private global::System.Int32 _IdGrupo;
        partial void OnIdGrupoChanging(global::System.Int32 value);
        partial void OnIdGrupoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                OnDescripcionChanging(value);
                ReportPropertyChanging("Descripcion");
                _Descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descripcion");
                OnDescripcionChanged();
            }
        }
        private global::System.String _Descripcion;
        partial void OnDescripcionChanging(global::System.String value);
        partial void OnDescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdTipoArticulo
        {
            get
            {
                return _IdTipoArticulo;
            }
            set
            {
                OnIdTipoArticuloChanging(value);
                ReportPropertyChanging("IdTipoArticulo");
                _IdTipoArticulo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdTipoArticulo");
                OnIdTipoArticuloChanged();
            }
        }
        private Nullable<global::System.Int32> _IdTipoArticulo;
        partial void OnIdTipoArticuloChanging(Nullable<global::System.Int32> value);
        partial void OnIdTipoArticuloChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdEstado
        {
            get
            {
                return _IdEstado;
            }
            set
            {
                OnIdEstadoChanging(value);
                ReportPropertyChanging("IdEstado");
                _IdEstado = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdEstado");
                OnIdEstadoChanged();
            }
        }
        private Nullable<global::System.Int32> _IdEstado;
        partial void OnIdEstadoChanging(Nullable<global::System.Int32> value);
        partial void OnIdEstadoChanged();

        #endregion

    
    }

    #endregion

    
}