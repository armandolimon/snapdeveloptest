using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace WebApplication1.Models
{
    [DataWindow("d_sales", DwStyle.Grid)]
    [Table("sales_order")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"sales_order\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    public class SalesModel
    {
        [Key]
        [DwColumn("sales_order", "id")]
        public int Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("sales_order", "cust_id")]
        public int Cust_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("sales_order", "order_date")]
        public DateTime Order_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(2)]
        [DwColumn("sales_order", "fin_code_id")]
        public string Fin_Code_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(7)]
        [DwColumn("sales_order", "region")]
        public string Region { get; set; }

        [ConcurrencyCheck]
        [DwColumn("sales_order", "sales_rep")]
        public int Sales_Rep { get; set; }

    }

}