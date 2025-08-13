using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Search_Logging")]
public partial class Search_Logging
{
    [Key]
    public long ID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? CASE_ID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SUBS_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SHARED { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CASETYPE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CASELIAB { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CASESTAT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CASEDEPT { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? CASEHDLR { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? SPECIALITY { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? PRACTICE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? COUNTRY { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? FILECLASS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LOCATION { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? POSTCODE { get; set; }

    public byte? NOTTYPE { get; set; }

    public byte? NOTLIAB { get; set; }

    public byte? NOTSTAT { get; set; }

    public byte? NOTDEPT { get; set; }

    public byte? NOTHDLR { get; set; }

    public byte? NOTSPLY { get; set; }

    public byte? NOTPRAC { get; set; }

    public byte? NOTCOUN { get; set; }

    public byte? NOTFILE { get; set; }

    public byte? NOTLOCA { get; set; }

    public byte? NOTPOST { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRACNAME { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? PRACINIT { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? PRACNUM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PRACLEAD { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PRACGROUP { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? PRACDDR { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PATINAME { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PATIINIT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PATISEX { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PATIDOB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PATISOLI { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? SOLIEXT { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? SOLIINT { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? SOLIREF { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? INCDTFRM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? INCDTTO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOTDTFRM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOTDTTO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SETDTFRM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SETDTTO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CLSDTFRM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CLSDTTO { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? COMMENTS { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CMTTYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CMTDTFRM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CMTDTTO { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? KEYWORDS { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? ORKEYWORDS { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? NOTKEYWORDS { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? ANDKEYWORDS { get; set; }

    public int? ANDKEYCOUNT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SUMMARY { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? ORSUMMARY { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? NOTSUMMARY { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? ANDSUMMARY { get; set; }

    public int? ANDSUMMCOUNT { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? KEYSUMJOIN { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Key { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PAYEEREF { get; set; }

    public int? CD_WEIGHT { get; set; }

    public int? PD_WEIGHT { get; set; }

    public int? PA_WEIGHT { get; set; }

    public int? SD_WEIGHT { get; set; }

    public int? CA_WEIGHT { get; set; }

    public int? OT_WEIGHT { get; set; }

    public int? WEIGHT { get; set; }

    public int? TOTWEIGHT { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? STAFF_NO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CREATEDDATE { get; set; }

    public bool MDU_Connect { get; set; }
}
