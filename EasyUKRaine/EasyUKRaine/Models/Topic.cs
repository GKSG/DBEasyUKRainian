//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyUKRaine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topic
    {
        public int TopicID { get; set; }
        public string Header { get; set; }
        public string Image { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> MinScoreForAccess { get; set; }
    }
}