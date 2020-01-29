using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Sivido.Model.Catalog;
using Sivido.Model.Core;

namespace Sivido.Model.Entities
{
    [Table("T_DIRECCION")]
    public class Direccion: Default
    {
       
        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
