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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.AchievementUser = new HashSet<AchievementUser>();
            this.PassedExercise = new HashSet<PassedExercise>();
            this.PassedLesson = new HashSet<PassedLesson>();
            this.QuestionResult = new HashSet<QuestionResult>();
            this.Result = new HashSet<Result>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> LevelId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AchievementUser> AchievementUser { get; set; }
        public virtual Language Language { get; set; }
        public virtual Level Level { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassedExercise> PassedExercise { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassedLesson> PassedLesson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionResult> QuestionResult { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Result { get; set; }
        public virtual Role Role { get; set; }
    }
}