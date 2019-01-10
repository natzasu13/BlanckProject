namespace GestionReservas.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUserLogins
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string LoginProvider { get; set; }

        [StringLength(50)]
        public string ProviderKey { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
    }
}
