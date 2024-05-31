using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Classes
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="varchar(255)")]
        public string Title { get; set; }

        [Column(TypeName ="varchar(255)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(255)")]
        bool isCompleted = false;
        public bool IsCompleted { 
            get {
                return isCompleted;
            } 
            set { isCompleted = value; } 
        }
        
    }
}
