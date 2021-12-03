using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "User")]
        public int UserId { get; set; }
        [Display(Name = "User")]
        public User userObj { get; set; }

        [Display(Name = "Project")]
        public int ProjectId { get; set; }
        [Display(Name = "Project")]
        public Project projectObj { get; set; }

        [Display(Name = "TicketType")]
        public int TicketTypeId { get; set; }
        [Display(Name = "TicketType")]
        public TicketType ticketTypeObj { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }
        [Display(Name = "Status")]
        public Status statusObj { get; set; }

        [Display(Name = "Priority")]
        public int PriorityId { get; set; }
        [Display(Name = "Priority")]
        public Priority priorityObj { get; set; }

        public bool IsActive { get; set; }




    }
}
