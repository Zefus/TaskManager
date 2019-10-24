using System.ComponentModel.DataAnnotations;

namespace TaskManager.Entities
{
    public enum Status : byte
    {
        [Display(Name = "Назначена")]
        Appointed = 1,
        [Display(Name = "Выполняется")]
        Performed = 2,
        [Display(Name = "Остановлена")]
        Suspended = 3,
        [Display(Name = "Завершена")]
        Completed = 4
    }
}
