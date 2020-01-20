using System;

namespace App_Cole2020.Common.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Payment
    {
        //Id, LLaveRef_Enc, Folio, Serie_Factura, Factura, Importe, Descuento, Abono, Recargo, TotalAbono, FechaAbono, TipoPago, Banco, Referencia, Estatus
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LLaveRef_Enc { get; set; }
        [Key, Column(Order = 1)]
        public int Folio { get; set; }
        [Required]
        public string Serie_Factura { get; set; }
        [Required]
        public string Factura { get; set; }
        public Decimal Importe { get; set; }
        public Decimal Descuento { get; set; }
        public Decimal Abono { get; set; }
        public Decimal Recargo { get; set; }
        public Decimal TotalAbono { get; set; }
        public DateTime FechaAbono { get; set; }
        public string TipoPago { get; set; }
        public string Banco { get; set; }
        public string Referencia { get; set; }
        public bool Estatus { get; set; }
    }
}
