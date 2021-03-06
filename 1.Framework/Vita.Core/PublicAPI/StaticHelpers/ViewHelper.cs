﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vita.Entities.Linq;

namespace Vita.Entities {


  // Work in progress!!! very early stage, do not use or look at it

  internal class ViewMap : Dictionary<object, object> { }

  public static class ViewHelper {
    /// <summary>
    /// Returns an instance of <c>EntitySet&lt;TEntity&gt;</c> interface representing a table in the database 
    /// for use LINQ queries not bound to entity session, for example: LINQ queries used for DB Views definition. 
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    /// <returns>An instance of an EntitySet.</returns>
    public static EntitySet<T> EntitySet<T>() {
      return new EntitySet<T>();
    }

  }
}
