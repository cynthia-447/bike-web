
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace bike_web.Models
{

using System;
    using System.Collections.Generic;
    
    public partial class private_route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public private_route()
        {
            this.private_route_comment = new HashSet<private_route_comment>();
        }
    
        public int id { get; set; }
        public int user_id { get; set; }
        public string article_title { get; set; }
        public Nullable<int> article_img_id { get; set; }
        public string article_img_info { get; set; }
        public string article_context { get; set; }
        public Nullable<System.DateTime> datetime { get; set; }
        public Nullable<int> fav_num { get; set; }
        public Nullable<int> seem_num { get; set; }
        public Nullable<int> star_num_sum { get; set; }
        public Nullable<int> sum_people_give_star { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<private_route_comment> private_route_comment { get; set; }
    }
}
