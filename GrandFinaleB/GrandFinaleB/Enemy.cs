//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrandFinaleB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enemy
    {
        public int Id { get; set; }
        public int PowerLevel { get; set; }
        public string Name { get; set; }
        public Nullable<int> DungeonId { get; set; }
    
        public virtual Dungeon Dungeon { get; set; }
    }
}