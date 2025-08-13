using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class MT_EntityRelationship
{
    [Key]
    public int ERID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string RelationshipID { get; set; } = null!;

    public int EID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;
}
