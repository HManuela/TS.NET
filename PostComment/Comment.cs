//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostComment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int PostPostId { get; set; }
        public int PostPostId1 { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
