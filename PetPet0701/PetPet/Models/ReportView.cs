//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetPet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class ReportView
    {
        [DisplayName("發文者帳號")]
        public string Post_Email { get; set; }
        [DisplayName("檢舉編號")]
        public int Report_no { get; set; }
        public int Expr1 { get; set; }
        [DisplayName("檢舉者帳號")]
        public string Expr2 { get; set; }
        [DisplayName("被檢舉違規類別編號")]
        public int VType_no { get; set; }
        [DisplayName("被檢舉違規類別")]
        public string VType_name { get; set; }
        [DisplayName("凍結時間")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public int Freeze_day { get; set; }
        [DisplayName("文章編號")]
        public int Post_no { get; set; }
        [DisplayName("處理狀況")]
        public bool Processing_stsus { get; set; }
        [DisplayName("被檢舉次數")]
        public int Report_amount { get; set; }
        [DisplayName("解凍日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Unfreeze_date { get; set; }
        public List<Post> RPost { get; internal set; }
        public List<Member> RMember { get; internal set; }
    }
}