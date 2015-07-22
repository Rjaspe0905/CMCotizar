﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;

namespace Tier.Data
{
    public abstract class ParentData<T>
    {
        #region [Campos]
        System.Configuration.ConnectionStringSettings objConnectionString;
        DatabaseProviderFactory objDatabaseProviderFactory;
        Database objDatabase;
        #endregion

        #region [Propiedades]
        public System.Configuration.ConnectionStringSettings CurrentConnectionString { get { return this.objConnectionString; } }
        public Database CurrentDatabase { get { return this.objDatabase; } }
        #endregion

        #region [Contructores]
        public ParentData()
        {
            DatabaseSettings objSection = (DatabaseSettings)System.Configuration.ConfigurationManager.GetSection("dataConfiguration");

            objDatabaseProviderFactory = new DatabaseProviderFactory();
            objDatabase = objDatabaseProviderFactory.CreateDefault();
            objConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[objSection.DefaultDatabase];
        }

        public ParentData(string ConnectionStringName)
        {
            objDatabaseProviderFactory = new DatabaseProviderFactory();
            objDatabase = objDatabaseProviderFactory.Create(ConnectionStringName);
            objConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[ConnectionStringName];
        }
        #endregion

        #region [Enumeradores]
        internal enum uspAcciones : byte
        {
            Crear = 1,
            RecuperarFiltrado = 2,
            Actualizar = 3,
            Aliminar = 4
        }
        #endregion

        public abstract IEnumerable<T> RecuperarFiltrados(T obj);
        public abstract bool Insertar(T obj);
        public abstract bool Actualizar(T obj);
        public abstract bool Eliminar(T obj);
    }
}
