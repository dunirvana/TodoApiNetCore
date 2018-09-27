using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models {
    /// <summary>
    /// Tarefa
    /// </summary>
    public class TodoItem {

        /// <summary>
        /// ID da tarefa
        /// </summary>
        /// <value></value>
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue (false)]
        public bool IsComplete { get; set; }
    }
}