//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassedExercise
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ExerciseId { get; set; }
        public bool Outcome { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Exercise Exercise { get; set; }
        public virtual User User { get; set; }
    }
}
