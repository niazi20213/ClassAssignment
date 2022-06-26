using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sarafi.Models.DB
{
    [Table("UserLocation")]
    public partial class UserLocation
    {
        [Key]
        [Column("UserID")]
        public Guid UserId { get; set; }
        [Key]
        [Column("LocationID")]
        public byte LocationId { get; set; }
    }
}
